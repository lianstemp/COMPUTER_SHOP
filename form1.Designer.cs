namespace TesLKS
{
    partial class form1
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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKSCOMPUTERSHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKS_COMPUTER_SHOPDataSet = new TesLKS.LKS_COMPUTER_SHOPDataSet();
            this.customerTableAdapter = new TesLKS.LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).BeginInit();
            this.SuspendLayout();
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
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSCOMPUTERSHOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKS_COMPUTER_SHOPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lKSCOMPUTERSHOPDataSetBindingSource;
        private LKS_COMPUTER_SHOPDataSet lKS_COMPUTER_SHOPDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private LKS_COMPUTER_SHOPDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}

