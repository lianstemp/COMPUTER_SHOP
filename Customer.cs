using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace TesLKS
{
    public partial class Customer : Form
    {
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=MRXAZK\MSSQLSERVER01;Initial Catalog=LKS_COMPUTER_SHOP;Integrated Security=True");

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKS_COMPUTER_SHOPDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lKS_COMPUTER_SHOPDataSet.Customer);

        }

        private void bt_add_cus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Customer (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", tb_name.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email.Text);
            cmd.Parameters.AddWithValue("@Phone", tb_phone.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Berhasil Menambahkan Customer");

            // Kosongkan kembali field, agar user dapat menambahkan kembali data berikutnya
            tb_name.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";

            // Restart DataGridView Agar data yang baru saja di tambah muncul
            this.customerTableAdapter.Fill(this.lKS_COMPUTER_SHOPDataSet.Customer);

        }
    }
}
