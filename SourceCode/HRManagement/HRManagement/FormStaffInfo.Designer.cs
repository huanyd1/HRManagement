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
            this.btnCheckout = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckin = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnStaffCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimeSheets = new DevExpress.XtraEditors.SimpleButton();
            this.btnExplanation = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeaveAbsence = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeAvatar = new DevExpress.XtraEditors.SimpleButton();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnCheckin);
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
            // btnCheckout
            // 
            this.btnCheckout.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Appearance.Options.UseFont = true;
            this.btnCheckout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.ImageOptions.Image")));
            this.btnCheckout.Location = new System.Drawing.Point(180, 432);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(162, 35);
            this.btnCheckout.TabIndex = 14;
            this.btnCheckout.Text = "Chấm về";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Appearance.Options.UseFont = true;
            this.btnCheckin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckin.ImageOptions.Image")));
            this.btnCheckin.Location = new System.Drawing.Point(12, 432);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(162, 35);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Chấm vào";
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineThickness = 3;
            this.separatorControl2.Location = new System.Drawing.Point(3, 478);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(337, 23);
            this.separatorControl2.TabIndex = 12;
            // 
            // btnStaffCourse
            // 
            this.btnStaffCourse.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCourse.Appearance.Options.UseFont = true;
            this.btnStaffCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffCourse.ImageOptions.Image")));
            this.btnStaffCourse.Location = new System.Drawing.Point(12, 549);
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
            this.btnTimeSheets.Location = new System.Drawing.Point(12, 508);
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
            this.panel2.Controls.Add(this.lbPosition);
            this.panel2.Controls.Add(this.lbStaffName);
            this.panel2.Controls.Add(this.pboxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 385);
            this.panel2.TabIndex = 1;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAvatar.ImageOptions.Image")));
            this.btnChangeAvatar.Location = new System.Drawing.Point(312, 27);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(22, 25);
            this.btnChangeAvatar.TabIndex = 3;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPosition.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbPosition.Location = new System.Drawing.Point(18, 345);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPosition.Size = new System.Drawing.Size(316, 22);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStaffName
            // 
            this.lbStaffName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStaffName.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.Location = new System.Drawing.Point(44, 310);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(264, 22);
            this.lbStaffName.TabIndex = 1;
            this.lbStaffName.Text = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            this.lbStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.Location = new System.Drawing.Point(41, 27);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(267, 267);
            this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAvatar.TabIndex = 0;
            this.pboxAvatar.TabStop = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStaffInfo_FormClosing);
            this.Load += new System.EventHandler(this.FormStaffInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbStaffName;
        private DevExpress.XtraEditors.SimpleButton btnExplanation;
        private DevExpress.XtraEditors.SimpleButton btnLeaveAbsence;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnStaffCourse;
        private DevExpress.XtraEditors.SimpleButton btnTimeSheets;
        private System.Windows.Forms.Panel panelSelect;
        private DevExpress.XtraEditors.SimpleButton btnChangeAvatar;
        private DevExpress.XtraEditors.SimpleButton btnCheckout;
        private DevExpress.XtraEditors.SimpleButton btnCheckin;
    }
}