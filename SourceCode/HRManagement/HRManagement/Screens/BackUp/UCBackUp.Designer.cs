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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBackUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnImportDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackUp = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnImportCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportInsurance = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportStaffCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportStaff = new DevExpress.XtraEditors.SimpleButton();
            this.btnTempDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.btnTempCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnTempInsurance = new DevExpress.XtraEditors.SimpleButton();
            this.btnTempStaffCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnTempStaff = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTempStaff);
            this.panel1.Controls.Add(this.btnTempStaffCourse);
            this.panel1.Controls.Add(this.btnTempInsurance);
            this.panel1.Controls.Add(this.btnTempCourse);
            this.panel1.Controls.Add(this.btnTempDepartment);
            this.panel1.Controls.Add(this.btnImportStaff);
            this.panel1.Controls.Add(this.btnImportStaffCourse);
            this.panel1.Controls.Add(this.btnImportInsurance);
            this.panel1.Controls.Add(this.btnImportCourse);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnImportDepartment);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 688);
            this.panel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Sao lưu dữ liệu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Cấu hình phần mềm";
            // 
            // btnImportDepartment
            // 
            this.btnImportDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.ImageOptions.Image")));
            this.btnImportDepartment.Location = new System.Drawing.Point(237, 315);
            this.btnImportDepartment.Name = "btnImportDepartment";
            this.btnImportDepartment.Size = new System.Drawing.Size(115, 35);
            this.btnImportDepartment.TabIndex = 2;
            this.btnImportDepartment.Text = "Import File";
            this.btnImportDepartment.Click += new System.EventHandler(this.btnImportDepartment_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.Location = new System.Drawing.Point(194, 174);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(115, 35);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Khôi phục";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackUp.ImageOptions.Image")));
            this.btnBackUp.Location = new System.Drawing.Point(194, 112);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(115, 35);
            this.btnBackUp.TabIndex = 0;
            this.btnBackUp.Text = "Sao lưu";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(33, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 17);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Sao lưu dữ liệu:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 255);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(200, 22);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Nhập dữ liệu theo lô";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 324);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(184, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Nhập dữ liệu phòng ban:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(33, 373);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(176, 17);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Nhập dữ liệu khóa học:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(33, 427);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(176, 17);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Nhập dữ liệu bảo hiểm:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(27, 485);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(168, 17);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Nhập dữ liệu NV - KH:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(27, 540);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(184, 17);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Nhập dữ liệu Nhân viên:";
            // 
            // btnImportCourse
            // 
            this.btnImportCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image5")));
            this.btnImportCourse.Location = new System.Drawing.Point(237, 364);
            this.btnImportCourse.Name = "btnImportCourse";
            this.btnImportCourse.Size = new System.Drawing.Size(115, 35);
            this.btnImportCourse.TabIndex = 14;
            this.btnImportCourse.Text = "Import File";
            this.btnImportCourse.Click += new System.EventHandler(this.btnImportCourse_Click);
            // 
            // btnImportInsurance
            // 
            this.btnImportInsurance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image4")));
            this.btnImportInsurance.Location = new System.Drawing.Point(237, 418);
            this.btnImportInsurance.Name = "btnImportInsurance";
            this.btnImportInsurance.Size = new System.Drawing.Size(115, 35);
            this.btnImportInsurance.TabIndex = 15;
            this.btnImportInsurance.Text = "Import File";
            this.btnImportInsurance.Click += new System.EventHandler(this.btnImportInsurance_Click);
            // 
            // btnImportStaffCourse
            // 
            this.btnImportStaffCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image3")));
            this.btnImportStaffCourse.Location = new System.Drawing.Point(237, 476);
            this.btnImportStaffCourse.Name = "btnImportStaffCourse";
            this.btnImportStaffCourse.Size = new System.Drawing.Size(115, 35);
            this.btnImportStaffCourse.TabIndex = 16;
            this.btnImportStaffCourse.Text = "Import File";
            this.btnImportStaffCourse.Click += new System.EventHandler(this.btnImportStaffCourse_Click);
            // 
            // btnImportStaff
            // 
            this.btnImportStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btnImportStaff.Location = new System.Drawing.Point(237, 531);
            this.btnImportStaff.Name = "btnImportStaff";
            this.btnImportStaff.Size = new System.Drawing.Size(115, 35);
            this.btnImportStaff.TabIndex = 17;
            this.btnImportStaff.Text = "Import File";
            this.btnImportStaff.Click += new System.EventHandler(this.btnImportStaff_Click);
            // 
            // btnTempDepartment
            // 
            this.btnTempDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnTempDepartment.Location = new System.Drawing.Point(375, 315);
            this.btnTempDepartment.Name = "btnTempDepartment";
            this.btnTempDepartment.Size = new System.Drawing.Size(115, 35);
            this.btnTempDepartment.TabIndex = 18;
            this.btnTempDepartment.Text = "File mẫu";
            this.btnTempDepartment.Click += new System.EventHandler(this.btnTempDepartment_Click);
            // 
            // btnTempCourse
            // 
            this.btnTempCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTempCourse.Location = new System.Drawing.Point(375, 364);
            this.btnTempCourse.Name = "btnTempCourse";
            this.btnTempCourse.Size = new System.Drawing.Size(115, 35);
            this.btnTempCourse.TabIndex = 19;
            this.btnTempCourse.Text = "File mẫu";
            this.btnTempCourse.Click += new System.EventHandler(this.btnTempCourse_Click);
            // 
            // btnTempInsurance
            // 
            this.btnTempInsurance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnTempInsurance.Location = new System.Drawing.Point(375, 418);
            this.btnTempInsurance.Name = "btnTempInsurance";
            this.btnTempInsurance.Size = new System.Drawing.Size(115, 35);
            this.btnTempInsurance.TabIndex = 20;
            this.btnTempInsurance.Text = "File mẫu";
            this.btnTempInsurance.Click += new System.EventHandler(this.btnTempInsurance_Click);
            // 
            // btnTempStaffCourse
            // 
            this.btnTempStaffCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnTempStaffCourse.Location = new System.Drawing.Point(375, 476);
            this.btnTempStaffCourse.Name = "btnTempStaffCourse";
            this.btnTempStaffCourse.Size = new System.Drawing.Size(115, 35);
            this.btnTempStaffCourse.TabIndex = 21;
            this.btnTempStaffCourse.Text = "File mẫu";
            this.btnTempStaffCourse.Click += new System.EventHandler(this.btnTempStaffCourse_Click);
            // 
            // btnTempStaff
            // 
            this.btnTempStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnTempStaff.Location = new System.Drawing.Point(375, 531);
            this.btnTempStaff.Name = "btnTempStaff";
            this.btnTempStaff.Size = new System.Drawing.Size(115, 35);
            this.btnTempStaff.TabIndex = 22;
            this.btnTempStaff.Text = "File mẫu";
            this.btnTempStaff.Click += new System.EventHandler(this.btnTempStaff_Click);
            // 
            // UCBackUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UCBackUp";
            this.Size = new System.Drawing.Size(907, 688);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnBackUp;
        private DevExpress.XtraEditors.SimpleButton btnImportDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnImportStaff;
        private DevExpress.XtraEditors.SimpleButton btnImportStaffCourse;
        private DevExpress.XtraEditors.SimpleButton btnImportInsurance;
        private DevExpress.XtraEditors.SimpleButton btnImportCourse;
        private DevExpress.XtraEditors.SimpleButton btnTempStaff;
        private DevExpress.XtraEditors.SimpleButton btnTempStaffCourse;
        private DevExpress.XtraEditors.SimpleButton btnTempInsurance;
        private DevExpress.XtraEditors.SimpleButton btnTempCourse;
        private DevExpress.XtraEditors.SimpleButton btnTempDepartment;
    }
}
