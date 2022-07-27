namespace HRManagement.Screens.Timekeeping
{
    partial class FormInfoTimekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoTimekeeping));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gTimeInfo = new DevExpress.XtraGrid.GridControl();
            this.gvTimeInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gTimeInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 660);
            this.panel1.TabIndex = 6;
            // 
            // gTimeInfo
            // 
            this.gTimeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gTimeInfo.Location = new System.Drawing.Point(0, 152);
            this.gTimeInfo.MainView = this.gvTimeInfo;
            this.gTimeInfo.Name = "gTimeInfo";
            this.gTimeInfo.Size = new System.Drawing.Size(758, 448);
            this.gTimeInfo.TabIndex = 7;
            this.gTimeInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTimeInfo});
            // 
            // gvTimeInfo
            // 
            this.gvTimeInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.CheckTime,
            this.Time,
            this.Description});
            this.gvTimeInfo.GridControl = this.gTimeInfo;
            this.gvTimeInfo.Name = "gvTimeInfo";
            this.gvTimeInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvTimeInfo.OptionsView.ShowGroupPanel = false;
            // 
            // Date
            // 
            this.Date.AppearanceCell.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.AppearanceCell.Options.UseFont = true;
            this.Date.AppearanceHeader.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.AppearanceHeader.Options.UseFont = true;
            this.Date.Caption = "Ngày";
            this.Date.FieldName = "Date";
            this.Date.MinWidth = 25;
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.OptionsColumn.AllowMove = false;
            this.Date.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Date.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Date.OptionsColumn.ReadOnly = true;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            this.Date.Width = 94;
            // 
            // CheckTime
            // 
            this.CheckTime.AppearanceCell.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTime.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.CheckTime.AppearanceCell.Options.UseFont = true;
            this.CheckTime.AppearanceCell.Options.UseTextOptions = true;
            this.CheckTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CheckTime.AppearanceHeader.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTime.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.CheckTime.AppearanceHeader.Options.UseFont = true;
            this.CheckTime.Caption = "Giờ vào - Giờ ra";
            this.CheckTime.FieldName = "CheckTime";
            this.CheckTime.MinWidth = 25;
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.OptionsColumn.AllowEdit = false;
            this.CheckTime.OptionsColumn.AllowMove = false;
            this.CheckTime.OptionsColumn.ReadOnly = true;
            this.CheckTime.Visible = true;
            this.CheckTime.VisibleIndex = 1;
            this.CheckTime.Width = 94;
            // 
            // Time
            // 
            this.Time.AppearanceCell.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.AppearanceCell.Options.UseFont = true;
            this.Time.AppearanceCell.Options.UseTextOptions = true;
            this.Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceHeader.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.AppearanceHeader.Options.UseFont = true;
            this.Time.Caption = "Công";
            this.Time.FieldName = "Time";
            this.Time.MinWidth = 25;
            this.Time.Name = "Time";
            this.Time.OptionsColumn.AllowEdit = false;
            this.Time.OptionsColumn.AllowMove = false;
            this.Time.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Time.OptionsColumn.ReadOnly = true;
            this.Time.Visible = true;
            this.Time.VisibleIndex = 2;
            this.Time.Width = 94;
            // 
            // Description
            // 
            this.Description.AppearanceCell.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.AppearanceCell.Options.UseFont = true;
            this.Description.AppearanceHeader.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.AppearanceHeader.Options.UseFont = true;
            this.Description.Caption = "Ghi chú/Giải trình";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 25;
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.OptionsColumn.AllowFocus = false;
            this.Description.OptionsColumn.AllowMove = false;
            this.Description.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Description.OptionsColumn.ReadOnly = true;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 94;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 60);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(616, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTotalTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbMonth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbStaffName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbDepartmentName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 152);
            this.panel2.TabIndex = 0;
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTime.Location = new System.Drawing.Point(162, 122);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(16, 17);
            this.lbTotalTime.TabIndex = 8;
            this.lbTotalTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số ngày công:";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(162, 86);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(48, 17);
            this.lbMonth.TabIndex = 6;
            this.lbMonth.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tháng:";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.Location = new System.Drawing.Point(162, 51);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(112, 17);
            this.lbStaffName.TabIndex = 4;
            this.lbStaffName.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên:";
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.AutoSize = true;
            this.lbDepartmentName.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartmentName.Location = new System.Drawing.Point(162, 18);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(112, 17);
            this.lbDepartmentName.TabIndex = 2;
            this.lbDepartmentName.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban:";
            // 
            // FormInfoTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInfoTimekeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoTimekeeping";
            this.Load += new System.EventHandler(this.FormInfoTimekeeping_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDepartmentName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gTimeInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTimeInfo;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn CheckTime;
    }
}