namespace TesLKS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lKS_COMPUTER_SHOPDataSet = new TesLKS.LKS_COMPUTER_SHOPDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.ProductTableAdapter();
            this.bt_customer = new System.Windows.Forms.Button();
            this.bt_product = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_employee = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lKS_COMPUTER_SHOPDataSet
            // 
            this.lKS_COMPUTER_SHOPDataSet.DataSetName = "LKS_COMPUTER_SHOPDataSet";
            this.lKS_COMPUTER_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.lKS_COMPUTER_SHOPDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // bt_customer
            // 
            this.bt_customer.Location = new System.Drawing.Point(235, 111);
            this.bt_customer.Name = "bt_customer";
            this.bt_customer.Size = new System.Drawing.Size(333, 43);
            this.bt_customer.TabIndex = 0;
            this.bt_customer.Text = "Customer";
            this.bt_customer.UseVisualStyleBackColor = true;
            this.bt_customer.Click += new System.EventHandler(this.bt_customer_Click);
            // 
            // bt_product
            // 
            this.bt_product.Location = new System.Drawing.Point(235, 160);
            this.bt_product.Name = "bt_product";
            this.bt_product.Size = new System.Drawing.Size(333, 43);
            this.bt_product.TabIndex = 1;
            this.bt_product.Text = "Product";
            this.bt_product.UseVisualStyleBackColor = true;
            this.bt_product.Click += new System.EventHandler(this.bt_product_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(333, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transaction";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_employee
            // 
            this.bt_employee.Location = new System.Drawing.Point(235, 209);
            this.bt_employee.Name = "bt_employee";
            this.bt_employee.Size = new System.Drawing.Size(333, 43);
            this.bt_employee.TabIndex = 3;
            this.bt_employee.Text = "Employee";
            this.bt_employee.UseVisualStyleBackColor = true;
            this.bt_employee.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(333, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Payment";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_employee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_product);
            this.Controls.Add(this.bt_customer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LKS_COMPUTER_SHOPDataSet lKS_COMPUTER_SHOPDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button bt_customer;
        private System.Windows.Forms.Button bt_product;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_employee;
        private System.Windows.Forms.Button button5;
    }
}