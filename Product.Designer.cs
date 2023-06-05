namespace TesLKS
{
    partial class Product
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
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lKSCOMPUTERSHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKS_COMPUTER_SHOPDataSet = new TesLKS.LKS_COMPUTER_SHOPDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter();
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_add_product = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_upload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_lokasi = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.fKDetailTraIdPro44FF419ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTransactionTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.DetailTransactionTableAdapter();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_id_product = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.NumericUpDown();
            this.tb_price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetailTraIdPro44FF419ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_price)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.lKSCOMPUTERSHOPDataSetBindingSource;
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
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lKSCOMPUTERSHOPDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(771, 228);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(38, 16);
            this.lb.TabIndex = 18;
            this.lb.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(770, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add Data Product";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(770, 124);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(170, 22);
            this.tb_name.TabIndex = 12;
            // 
            // bt_add_product
            // 
            this.bt_add_product.Location = new System.Drawing.Point(793, 423);
            this.bt_add_product.Name = "bt_add_product";
            this.bt_add_product.Size = new System.Drawing.Size(122, 30);
            this.bt_add_product.TabIndex = 11;
            this.bt_add_product.Text = "Add Product";
            this.bt_add_product.UseVisualStyleBackColor = true;
            this.bt_add_product.Click += new System.EventHandler(this.bt_add_product_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.lKSCOMPUTERSHOPDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stock";
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(775, 376);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(35, 23);
            this.bt_upload.TabIndex = 21;
            this.bt_upload.Text = "...";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Upload";
            // 
            // lb_lokasi
            // 
            this.lb_lokasi.AutoSize = true;
            this.lb_lokasi.Location = new System.Drawing.Point(816, 379);
            this.lb_lokasi.Name = "lb_lokasi";
            this.lb_lokasi.Size = new System.Drawing.Size(112, 16);
            this.lb_lokasi.TabIndex = 23;
            this.lb_lokasi.Text = "Nama Lokasi File";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Laptop",
            "Keyboard",
            "Mouse",
            "Tablet",
            "Other"});
            this.cb_category.Location = new System.Drawing.Point(771, 188);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(170, 24);
            this.cb_category.TabIndex = 24;
            // 
            // fKDetailTraIdPro44FF419ABindingSource
            // 
            this.fKDetailTraIdPro44FF419ABindingSource.DataMember = "FK__DetailTra__IdPro__44FF419A";
            this.fKDetailTraIdPro44FF419ABindingSource.DataSource = this.productBindingSource1;
            // 
            // detailTransactionTableAdapter
            // 
            this.detailTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.PName,
            this.Category,
            this.Price,
            this.Stock,
            this.Image});
            this.dgvProduct.DataSource = this.productBindingSource2;
            this.dgvProduct.Location = new System.Drawing.Point(29, 46);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(705, 423);
            this.dgvProduct.TabIndex = 25;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "IdProduct";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.MinimumWidth = 6;
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Visible = false;
            this.IdProduct.Width = 125;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.lKS_COMPUTER_SHOPDataSet;
            // 
            // tb_id_product
            // 
            this.tb_id_product.Location = new System.Drawing.Point(771, 74);
            this.tb_id_product.Name = "tb_id_product";
            this.tb_id_product.Size = new System.Drawing.Size(170, 22);
            this.tb_id_product.TabIndex = 26;
            this.tb_id_product.Visible = false;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(772, 313);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(170, 22);
            this.tb_stock.TabIndex = 27;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(772, 249);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(170, 22);
            this.tb_price.TabIndex = 28;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 489);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_id_product);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lb_lokasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_add_product);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetailTraIdPro44FF419ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource lKSCOMPUTERSHOPDataSetBindingSource;
        private LKS_COMPUTER_SHOPDataSet lKS_COMPUTER_SHOPDataSet;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_add_product;
        private System.Windows.Forms.BindingSource productBindingSource;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_lokasi;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.BindingSource fKDetailTraIdPro44FF419ABindingSource;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.DetailTransactionTableAdapter detailTransactionTableAdapter;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.TextBox tb_id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.NumericUpDown tb_stock;
        private System.Windows.Forms.NumericUpDown tb_price;
    }
}