namespace HRManagement.Screens.Course
{
    partial class UCStaffCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gCourse = new DevExpress.XtraGrid.GridControl();
            this.gvCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gStaffCourse = new DevExpress.XtraGrid.GridControl();
            this.gvStaffCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDStaffCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffCourse)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 77);
            this.panel1.TabIndex = 2;
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
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.tabPane1);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 83F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(907, 688);
            this.tablePanel1.TabIndex = 1;
            // 
            // tabPane1
            // 
            this.tablePanel1.SetColumn(this.tabPane1, 0);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(3, 86);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(901, 599);
            this.tablePanel1.SetRow(this.tabPane1, 1);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(901, 599);
            this.tabPane1.TabIndex = 3;
            this.tabPane1.Text = "Các khóa học đang mở";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.gCourse);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(901, 558);
            // 
            // gCourse
            // 
            this.gCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCourse.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gCourse.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gCourse.Location = new System.Drawing.Point(0, 0);
            this.gCourse.MainView = this.gvCourse;
            this.gCourse.Name = "gCourse";
            this.gCourse.Size = new System.Drawing.Size(901, 558);
            this.gCourse.TabIndex = 6;
            this.gCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // gvCourse
            // 
            this.gvCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCourse,
            this.CourseName,
            this.Status});
            this.gvCourse.GridControl = this.gCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            // 
            // IDCourse
            // 
            this.IDCourse.Caption = "Mã Khóa Học";
            this.IDCourse.FieldName = "IDCourse";
            this.IDCourse.MinWidth = 25;
            this.IDCourse.Name = "IDCourse";
            this.IDCourse.Visible = true;
            this.IDCourse.VisibleIndex = 0;
            this.IDCourse.Width = 440;
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Tên Khóa Học";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.MinWidth = 25;
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 1;
            this.CourseName.Width = 251;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng Thái";
            this.Status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 2;
            this.Status.Width = 94;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.gStaffCourse);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(901, 558);
            // 
            // gStaffCourse
            // 
            this.gStaffCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStaffCourse.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gStaffCourse.Location = new System.Drawing.Point(0, 0);
            this.gStaffCourse.MainView = this.gvStaffCourse;
            this.gStaffCourse.Margin = new System.Windows.Forms.Padding(4);
            this.gStaffCourse.Name = "gStaffCourse";
            this.gStaffCourse.Size = new System.Drawing.Size(901, 558);
            this.gStaffCourse.TabIndex = 53;
            this.gStaffCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStaffCourse});
            // 
            // gvStaffCourse
            // 
            this.gvStaffCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDStaffCourse,
            this.gridColumn1,
            this.gridColumn2,
            this.Point,
            this.Result});
            this.gvStaffCourse.DetailHeight = 431;
            this.gvStaffCourse.GridControl = this.gStaffCourse;
            this.gvStaffCourse.Name = "gvStaffCourse";
            this.gvStaffCourse.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvStaffCourse.OptionsView.ShowGroupPanel = false;
            // 
            // IDStaffCourse
            // 
            this.IDStaffCourse.Caption = "Mã Nhân Viên - Khóa học";
            this.IDStaffCourse.FieldName = "IDStaffCourse";
            this.IDStaffCourse.MinWidth = 29;
            this.IDStaffCourse.Name = "IDStaffCourse";
            this.IDStaffCourse.Width = 110;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Khóa Học";
            this.gridColumn1.FieldName = "IDCourse";
            this.gridColumn1.MinWidth = 29;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 110;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Khóa Học";
            this.gridColumn2.FieldName = "CourseName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 87;
            // 
            // Point
            // 
            this.Point.Caption = "Điểm số";
            this.Point.FieldName = "Point";
            this.Point.MinWidth = 23;
            this.Point.Name = "Point";
            this.Point.Visible = true;
            this.Point.VisibleIndex = 3;
            this.Point.Width = 87;
            // 
            // Result
            // 
            this.Result.Caption = "Kết quả";
            this.Result.FieldName = "Result";
            this.Result.MinWidth = 23;
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 4;
            this.Result.Width = 87;
            // 
            // UCStaffCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCStaffCourse";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCStaffCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gStaffCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl gCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
        private DevExpress.XtraGrid.Columns.GridColumn IDCourse;
        private DevExpress.XtraGrid.Columns.GridColumn CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.GridControl gStaffCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaffCourse;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaffCourse;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn Point;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
    }
}
