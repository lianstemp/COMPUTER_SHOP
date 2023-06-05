using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesLKS
{
    public partial class Product : Form
    {
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=MRXAZK\MSSQLSERVER01;Initial Catalog=LKS_COMPUTER_SHOP;Integrated Security=True");
        SqlDataReader dr;

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKS_COMPUTER_SHOPDataSet.DetailTransaction' table. You can move, or remove it, as needed.
            this.detailTransactionTableAdapter.Fill(this.lKS_COMPUTER_SHOPDataSet.DetailTransaction);

            // Mengisi DataGridView dengan data produk dari database
            UpdateDataGridView();
        }

        private void bt_add_product_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_id_product.Text))
            {
                // Validasi input field
                if (string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(cb_category.Text) || tb_price.Value == 0 || string.IsNullOrWhiteSpace(tb_stock.Text))
                {
                    MessageBox.Show("Harap isi semua field.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = tb_name.Text;
                string category = cb_category.Text;
                decimal price = tb_price.Value;
                int stock = int.Parse(tb_stock.Text);

                // Mengupload data produk ke database
                UploadProductToDatabase(name, category, price, stock);

                // Mengosongkan input TextBox setelah data diupload
                ClearInputFields();

                // Memperbarui DataGridView dengan data terbaru dari database
                UpdateDataGridView();
            }
            else
            {
                // Validasi input field
                if (string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(cb_category.Text) || tb_price.Value == 0 || string.IsNullOrWhiteSpace(tb_stock.Text))
                {
                    MessageBox.Show("Harap isi semua field.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = int.Parse(tb_id_product.Text);
                string name = tb_name.Text;
                string category = cb_category.Text;
                decimal price = tb_price.Value;
                int stock = int.Parse(tb_stock.Text);

                // Mengupdate data produk ke database
                UpdateProductInDatabase(id, name, category, price, stock);

                // Mengosongkan input TextBox setelah data diupdate
                ClearInputFields();

                // Memperbarui DataGridView dengan data terbaru dari database
                UpdateDataGridView();
            }
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.SafeFileName;
                    string sourceFilePath = openFileDialog.FileName;
                    string destinationFolderPath = Path.Combine(Application.StartupPath, "images");
                    string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

                    // Validasi file dipilih
                    if (string.IsNullOrWhiteSpace(fileName) || string.IsNullOrWhiteSpace(sourceFilePath))
                    {
                        MessageBox.Show("Harap pilih file gambar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Buat direktori "images" jika belum ada
                    if (!Directory.Exists(destinationFolderPath))
                        Directory.CreateDirectory(destinationFolderPath);

                    // Salin file gambar ke folder "images"
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    lb_lokasi.Text = destinationFilePath;

                    MessageBox.Show("Gambar berhasil diupload.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengupload gambar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UploadProductToDatabase(string name, string category, decimal price, int stock)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO Product (Category, Name, Price, Stock, Image, CreatedAt, UpdatedAt) " +
                               "VALUES (@Category, @Name, @Price, @Stock, @Image, GETDATE(), GETDATE())";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Image", lb_lokasi.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produk berhasil ditambahkan ke database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateProductInDatabase(int id, string name, string category, decimal price, int stock)
        {
            try
            {
                conn.Open();

                string query = "UPDATE Product SET Category = @Category, Name = @Name, Price = @Price, Stock = @Stock, Image = @Image, UpdatedAt = GETDATE() " +
                               "WHERE IdProduct = @IdProduct";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Image", lb_lokasi.Text);
                cmd.Parameters.AddWithValue("@IdProduct", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produk berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearInputFields()
        {
            tb_id_product.Text = "";
            tb_name.Text = "";
            cb_category.Text = "";
            tb_price.Text = "";
            tb_stock.Text = "";
            bt_add_product.Text = "Add Product";

        }

        private void UpdateDataGridView()
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM Product";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
                tb_id_product.Text = row.Cells["IdProduct"].Value.ToString();
                tb_name.Text = row.Cells["PName"].Value.ToString();
                cb_category.Text = row.Cells["Category"].Value.ToString();
                tb_price.Text = row.Cells["Price"].Value.ToString();
                tb_stock.Text = row.Cells["Stock"].Value.ToString();

                // Ubah teks label lb_lokasi sesuai dengan nilai dari kolom "Image" pada DataGridView
                lb_lokasi.Text = row.Cells["Image"].Value.ToString();

                // Ubah teks pada tombol "Add Product" menjadi "Update Product"
                bt_add_product.Text = "Update Product";
            }
        }

    }
}
