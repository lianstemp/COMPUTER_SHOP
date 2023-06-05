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

namespace TesLKS
{
    public partial class Employee : Form
    {
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=MRXAZK\MSSQLSERVER01;Initial Catalog=LKS_COMPUTER_SHOP;Integrated Security=True");
        SqlDataReader dr;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKS_COMPUTER_SHOPDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.lKS_COMPUTER_SHOPDataSet.Employee);

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Ambil nilai yang diubah oleh pengguna
            DataGridViewRow editedRow = dgvEmployee.Rows[e.RowIndex];
            int id = Convert.ToInt32(editedRow.Cells["IdEmployee"].Value);
            string name = editedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            string phoneNumber = editedRow.Cells["phoneNumberDataGridViewTextBoxColumn"].Value.ToString();
            string email = editedRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            string pass = editedRow.Cells["passDataGridViewTextBoxColumn"].Value.ToString();

            // Periksa apakah nilai ID kosong (baris baru) atau tidak (update data)
            if (id == 0)
            {
                // Insert data baru ke database
                conn.Open();
                string insertQuery = "INSERT INTO Employee (Name, PhoneNumber, Email, Pass) VALUES (@Name, @PhoneNumber, @Email, @Pass)";
                cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Pass", pass);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                // Update data di database
                conn.Open();
                string updateQuery = "UPDATE Employee SET Name = @Name, PhoneNumber = @PhoneNumber, Email = @Email, Pass = @Pass WHERE IdEmployee = @IdEmployee";
                cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Pass", pass);
                cmd.Parameters.AddWithValue("@IdEmployee", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


    }
}
