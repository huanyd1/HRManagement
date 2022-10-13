namespace HRManagement.Screens.BackUp
{
    partial class UCBackUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportExcel2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportExcel2);
            this.panel1.Controls.Add(this.btnImportExcel);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 688);
            this.panel1.TabIndex = 0;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(324, 33);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(223, 81);
            this.btnImportExcel.TabIndex = 2;
            this.btnImportExcel.Text = "Import Excel File";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(35, 134);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(223, 81);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Khôi phục dữ liệu";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(35, 33);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(223, 81);
            this.btnBackUp.TabIndex = 0;
            this.btnBackUp.Text = "Sao lưu dữ liệu";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnImportExcel2
            // 
            this.btnImportExcel2.Location = new System.Drawing.Point(324, 134);
            this.btnImportExcel2.Name = "btnImportExcel2";
            this.btnImportExcel2.Size = new System.Drawing.Size(223, 81);
            this.btnImportExcel2.TabIndex = 3;
            this.btnImportExcel2.Text = "Import Excel File Insurance";
            this.btnImportExcel2.Click += new System.EventHandler(this.btnImportExcel2_Click);
            // 
            // UCBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCBackUp";
            this.Size = new System.Drawing.Size(907, 688);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnBackUp;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel2;
    }
}
