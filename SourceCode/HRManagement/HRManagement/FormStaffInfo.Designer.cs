namespace HRManagement
{
    partial class FormStaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnStaffCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimeSheets = new DevExpress.XtraEditors.SimpleButton();
            this.btnExplanation = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeaveAbsence = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnChangeAvatar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.separatorControl2);
            this.panel1.Controls.Add(this.btnStaffCourse);
            this.panel1.Controls.Add(this.btnTimeSheets);
            this.panel1.Controls.Add(this.btnExplanation);
            this.panel1.Controls.Add(this.btnLeaveAbsence);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 680);
            this.panel1.TabIndex = 0;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineThickness = 3;
            this.separatorControl2.Location = new System.Drawing.Point(3, 445);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(337, 23);
            this.separatorControl2.TabIndex = 12;
            // 
            // btnStaffCourse
            // 
            this.btnStaffCourse.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCourse.Appearance.Options.UseFont = true;
            this.btnStaffCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffCourse.ImageOptions.Image")));
            this.btnStaffCourse.Location = new System.Drawing.Point(12, 516);
            this.btnStaffCourse.Name = "btnStaffCourse";
            this.btnStaffCourse.Size = new System.Drawing.Size(328, 35);
            this.btnStaffCourse.TabIndex = 11;
            this.btnStaffCourse.Text = "Đào tạo";
            this.btnStaffCourse.Click += new System.EventHandler(this.btnStaffCourse_Click);
            // 
            // btnTimeSheets
            // 
            this.btnTimeSheets.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSheets.Appearance.Options.UseFont = true;
            this.btnTimeSheets.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeSheets.ImageOptions.Image")));
            this.btnTimeSheets.Location = new System.Drawing.Point(12, 475);
            this.btnTimeSheets.Name = "btnTimeSheets";
            this.btnTimeSheets.Size = new System.Drawing.Size(328, 35);
            this.btnTimeSheets.TabIndex = 10;
            this.btnTimeSheets.Text = "Bảng công tháng";
            this.btnTimeSheets.Click += new System.EventHandler(this.btnTimeSheets_Click);
            // 
            // btnExplanation
            // 
            this.btnExplanation.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplanation.Appearance.Options.UseFont = true;
            this.btnExplanation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExplanation.ImageOptions.Image")));
            this.btnExplanation.Location = new System.Drawing.Point(180, 391);
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.Size = new System.Drawing.Size(162, 35);
            this.btnExplanation.TabIndex = 9;
            this.btnExplanation.Text = "Giải trình";
            this.btnExplanation.Click += new System.EventHandler(this.btnExplanation_Click);
            // 
            // btnLeaveAbsence
            // 
            this.btnLeaveAbsence.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveAbsence.Appearance.Options.UseFont = true;
            this.btnLeaveAbsence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLeaveAbsence.ImageOptions.Image")));
            this.btnLeaveAbsence.Location = new System.Drawing.Point(12, 391);
            this.btnLeaveAbsence.Name = "btnLeaveAbsence";
            this.btnLeaveAbsence.Size = new System.Drawing.Size(162, 35);
            this.btnLeaveAbsence.TabIndex = 7;
            this.btnLeaveAbsence.Text = "Đăng ký nghỉ";
            this.btnLeaveAbsence.Click += new System.EventHandler(this.btnLeaveAbsence_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChangeAvatar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbStaffName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 385);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(95, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Position";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.Location = new System.Drawing.Point(113, 307);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(110, 22);
            this.lbStaffName.TabIndex = 1;
            this.lbStaffName.Text = "Staff Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineThickness = 3;
            this.separatorControl1.Location = new System.Drawing.Point(340, 0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 680);
            this.separatorControl1.TabIndex = 0;
            // 
            // panelSelect
            // 
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(360, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(918, 680);
            this.panelSelect.TabIndex = 1;
            this.panelSelect.Resize += new System.EventHandler(this.panelSelect_Resize);
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnChangeAvatar.Location = new System.Drawing.Point(312, 27);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(22, 25);
            this.btnChangeAvatar.TabIndex = 3;
            // 
            // FormStaffInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormStaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStaffInfo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStaffName;
        private DevExpress.XtraEditors.SimpleButton btnExplanation;
        private DevExpress.XtraEditors.SimpleButton btnLeaveAbsence;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnStaffCourse;
        private DevExpress.XtraEditors.SimpleButton btnTimeSheets;
        private System.Windows.Forms.Panel panelSelect;
        private DevExpress.XtraEditors.SimpleButton btnChangeAvatar;
    }
}