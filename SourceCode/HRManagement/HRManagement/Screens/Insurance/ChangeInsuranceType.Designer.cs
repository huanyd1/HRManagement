namespace HRManagement.Screens.Insurance
{
    partial class ChangeInsuranceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInsuranceType));
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtIDInsuranceType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIDInsuranceType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTypeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorIDInsuranceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(138, 80);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(241, 20);
            this.txtTypeName.TabIndex = 34;
            // 
            // txtIDInsuranceType
            // 
            this.txtIDInsuranceType.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDInsuranceType.Location = new System.Drawing.Point(138, 31);
            this.txtIDInsuranceType.Name = "txtIDInsuranceType";
            this.txtIDInsuranceType.Size = new System.Drawing.Size(241, 20);
            this.txtIDInsuranceType.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên loại bảo hiểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã loại bảo hiểm:";
            // 
            // errorIDInsuranceType
            // 
            this.errorIDInsuranceType.ContainerControl = this;
            // 
            // errorTypeName
            // 
            this.errorTypeName.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(244, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(87, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangeInsuranceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 193);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtIDInsuranceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "ChangeInsuranceType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeInsuranceType";
            this.Load += new System.EventHandler(this.ChangeInsuranceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIDInsuranceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtIDInsuranceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIDInsuranceType;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ErrorProvider errorTypeName;
    }
}