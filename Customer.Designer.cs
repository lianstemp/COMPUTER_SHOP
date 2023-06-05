namespace TesLKS
{
    partial class Customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKSCOMPUTERSHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKS_COMPUTER_SHOPDataSet = new TesLKS.LKS_COMPUTER_SHOPDataSet();
            this.customerTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter();
            this.bt_add_cus = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lKSCOMPUTERSHOPDataSetBindingSource;
            // 
            // lKSCOMPUTERSHOPDataSetBindingSource
            // 
            this.lKSCOMPUTERSHOPDataSetBindingSource.DataSource = this.lKS_COMPUTER_SHOPDataSet;
            this.lKSCOMPUTERSHOPDataSetBindingSource.Position = 0;
            // 
            // lKS_COMPUTER_SHOPDataSet
            // 
            this.lKS_COMPUTER_SHOPDataSet.DataSetName = "LKS_COMPUTER_SHOPDataSet";
            this.lKS_COMPUTER_SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // bt_add_cus
            // 
            this.bt_add_cus.Location = new System.Drawing.Point(612, 352);
            this.bt_add_cus.Name = "bt_add_cus";
            this.bt_add_cus.Size = new System.Drawing.Size(122, 30);
            this.bt_add_cus.TabIndex = 1;
            this.bt_add_cus.Text = "Add Customer";
            this.bt_add_cus.UseVisualStyleBackColor = true;
            this.bt_add_cus.Click += new System.EventHandler(this.bt_add_cus_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(584, 156);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(170, 22);
            this.tb_name.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(584, 223);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(170, 22);
            this.tb_email.TabIndex = 3;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(584, 294);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(170, 22);
            this.tb_phone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(579, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Data Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(581, 269);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(46, 16);
            this.lb.TabIndex = 9;
            this.lb.Text = "Phone";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_add_cus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lKSCOMPUTERSHOPDataSetBindingSource;
        private LKS_COMPUTER_SHOPDataSet lKS_COMPUTER_SHOPDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_add_cus;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb;
    }
}