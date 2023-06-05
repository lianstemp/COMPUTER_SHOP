using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesLKS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKS_COMPUTER_SHOPDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.lKS_COMPUTER_SHOPDataSet.Product);

        }

        private void bt_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void bt_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }

        private void bt_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.Show();
        }
    }
}
