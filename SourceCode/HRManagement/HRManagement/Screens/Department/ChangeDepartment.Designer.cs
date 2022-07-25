namespace HRManagement.Screens.Department
{
    partial class ChangeDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDepartment));
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtIDDepartment = new System.Windows.Forms.TextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIDDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepartmentName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIDDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartmentName)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(135, 114);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(241, 21);
            this.cbStatus.TabIndex = 15;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(135, 61);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(241, 20);
            this.txtDepartmentName.TabIndex = 14;
            // 
            // txtIDDepartment
            // 
            this.txtIDDepartment.Location = new System.Drawing.Point(135, 12);
            this.txtIDDepartment.Name = "txtIDDepartment";
            this.txtIDDepartment.Size = new System.Drawing.Size(241, 20);
            this.txtIDDepartment.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(241, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(84, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã phòng ban:";
            // 
            // errorIDDepartment
            // 
            this.errorIDDepartment.ContainerControl = this;
            // 
            // errorDepartmentName
            // 
            this.errorDepartmentName.ContainerControl = this;
            // 
            // ChangeDepartment
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 280);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtIDDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeDepartment";
            this.Load += new System.EventHandler(this.ChangeDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIDDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartmentName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtIDDepartment;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIDDepartment;
        private System.Windows.Forms.ErrorProvider errorDepartmentName;
    }
}