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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gTimeInfo = new DevExpress.XtraGrid.GridControl();
            this.gvTimeInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gTotalTime = new DevExpress.XtraGrid.GridControl();
            this.gvTotalTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 77);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bảng công chi tiết tháng";
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
            this.tablePanel1.SetColumn(this.panel4, 0);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 86);
            this.panel4.Name = "panel4";
            this.tablePanel1.SetRow(this.panel4, 1);
            this.panel4.Size = new System.Drawing.Size(901, 599);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gTimeInfo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(642, 599);
            this.panel6.TabIndex = 8;
            this.panel6.Tag = "`";
            // 
            // gTimeInfo
            // 
            this.gTimeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gTimeInfo.Location = new System.Drawing.Point(0, 0);
            this.gTimeInfo.MainView = this.gvTimeInfo;
            this.gTimeInfo.Name = "gTimeInfo";
            this.gTimeInfo.Size = new System.Drawing.Size(642, 599);
            this.gTimeInfo.TabIndex = 10;
            this.gTimeInfo.Tag = "`";
            this.gTimeInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTimeInfo,
            this.gridView4});
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
            this.gvTimeInfo.Tag = "`";
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
            this.Date.Tag = "`";
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
            this.CheckTime.Tag = "`";
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
            this.Time.Tag = "`";
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
            this.Description.Tag = "`";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 94;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gTimeInfo;
            this.gridView4.Name = "gridView4";
            this.gridView4.Tag = "`";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gTotalTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(642, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 599);
            this.panel5.TabIndex = 5;
            // 
            // gTotalTime
            // 
            this.gTotalTime.Location = new System.Drawing.Point(0, 0);
            this.gTotalTime.MainView = this.gvTotalTime;
            this.gTotalTime.Name = "gTotalTime";
            this.gTotalTime.Size = new System.Drawing.Size(246, 69);
            this.gTotalTime.TabIndex = 6;
            this.gTotalTime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTotalTime,
            this.gridView2,
            this.gridView3});
            // 
            // gvTotalTime
            // 
            this.gvTotalTime.GridControl = this.gTotalTime;
            this.gvTotalTime.Name = "gvTotalTime";
            this.gvTotalTime.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvTotalTime.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gTotalTime;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gTotalTime;
            this.gridView3.Name = "gridView3";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1029, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 936);
            this.panel3.TabIndex = 3;
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
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // UCStaffTimekeeping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCStaffTimekeeping";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCStaffTimekeeping_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTimeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn Month;
        private DevExpress.XtraGrid.Columns.GridColumn TotalTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl gTotalTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTotalTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl gTimeInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTimeInfo;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn CheckTime;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}
