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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=MRXAZK\MSSQLSERVER01;Initial Catalog=LKS_COMPUTER_SHOP;Integrated Security=True");
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Employee where Email=@email and Pass=@pass", conn);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);

            conn.Open();

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Login Failure");
            }
            conn.Close();
        }

    }
}
