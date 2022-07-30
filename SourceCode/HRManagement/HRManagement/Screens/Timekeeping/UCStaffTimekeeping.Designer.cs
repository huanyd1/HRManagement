namespace HRManagement.Screens.Timekeeping
{
    partial class UCStaffTimekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStaffTimekeeping));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gTimeInfo = new DevExpress.XtraGrid.GridControl();
            this.gvTimeInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gTotalTime = new DevExpress.XtraGrid.GridControl();
            this.gvTotalTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalTime)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.panel4);
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 83F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(907, 688);
            this.tablePanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gTimeInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 599);
            this.panel4.TabIndex = 4;
            // 
            // gTimeInfo
            // 
            this.gTimeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gTimeInfo.Location = new System.Drawing.Point(0, 0);
            this.gTimeInfo.MainView = this.gvTimeInfo;
            this.gTimeInfo.Name = "gTimeInfo";
            this.gTimeInfo.Size = new System.Drawing.Size(649, 599);
            this.gTimeInfo.TabIndex = 8;
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
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(658, 86);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(246, 599);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gTotalTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 599);
            this.panel5.TabIndex = 0;
            // 
            // gTotalTime
            // 
            this.gTotalTime.Location = new System.Drawing.Point(0, 0);
            this.gTotalTime.MainView = this.gvTotalTime;
            this.gTotalTime.Name = "gTotalTime";
            this.gTotalTime.Size = new System.Drawing.Size(246, 69);
            this.gTotalTime.TabIndex = 6;
            this.gTotalTime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTotalTime});
            // 
            // gvTotalTime
            // 
            this.gvTotalTime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Month,
            this.TotalTime});
            this.gvTotalTime.GridControl = this.gTotalTime;
            this.gvTotalTime.Name = "gvTotalTime";
            this.gvTotalTime.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvTotalTime.OptionsView.ShowGroupPanel = false;
            // 
            // Month
            // 
            this.Month.Caption = "Tổng Công";
            this.Month.FieldName = "Month";
            this.Month.MinWidth = 25;
            this.Month.Name = "Month";
            this.Month.Visible = true;
            this.Month.VisibleIndex = 0;
            this.Month.Width = 94;
            // 
            // TotalTime
            // 
            this.TotalTime.Caption = "Số Lượng";
            this.TotalTime.FieldName = "TotalTime";
            this.TotalTime.MinWidth = 25;
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Visible = true;
            this.TotalTime.VisibleIndex = 1;
            this.TotalTime.Width = 94;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 0);
            this.panel2.Size = new System.Drawing.Size(901, 77);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 77);
            this.panel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(783, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG CÔNG CHI TIẾT THÁNG";
            // 
            // UCStaffTimekeeping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCStaffTimekeeping";
            this.Size = new System.Drawing.Size(907, 688);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl gTotalTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTotalTime;
        private DevExpress.XtraGrid.Columns.GridColumn Month;
        private DevExpress.XtraGrid.Columns.GridColumn TotalTime;
        private DevExpress.XtraGrid.GridControl gTimeInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTimeInfo;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn CheckTime;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}
