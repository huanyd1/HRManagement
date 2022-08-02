namespace HRManagement.Screens.LeaveAbsence
{
    partial class UCLeaveAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLeaveAbsence));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefuse = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgree = new DevExpress.XtraEditors.SimpleButton();
            this.lbRemain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gLeaveAbsence = new DevExpress.XtraGrid.GridControl();
            this.gvLeaveAbsence = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDLeaveAbsence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descript = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gLeaveAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefuse);
            this.panel1.Controls.Add(this.btnAgree);
            this.panel1.Controls.Add(this.lbRemain);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 79);
            this.panel1.TabIndex = 6;
            // 
            // btnRefuse
            // 
            this.btnRefuse.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefuse.Appearance.Options.UseFont = true;
            this.btnRefuse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefuse.ImageOptions.Image")));
            this.btnRefuse.Location = new System.Drawing.Point(783, 41);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(115, 35);
            this.btnRefuse.TabIndex = 9;
            this.btnRefuse.Text = "Từ chối";
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Appearance.Options.UseFont = true;
            this.btnAgree.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgree.ImageOptions.Image")));
            this.btnAgree.Location = new System.Drawing.Point(663, 41);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(115, 35);
            this.btnAgree.TabIndex = 8;
            this.btnAgree.Text = "Duyệt";
            this.btnAgree.Visible = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemain.Location = new System.Drawing.Point(201, 55);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(16, 17);
            this.lbRemain.TabIndex = 7;
            this.lbRemain.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số ngày phép còn lại:";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(783, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(663, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đơn xin nghỉ phép";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(907, 688);
            this.tablePanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gLeaveAbsence);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 1);
            this.panel2.Size = new System.Drawing.Size(901, 597);
            this.panel2.TabIndex = 7;
            // 
            // gLeaveAbsence
            // 
            this.gLeaveAbsence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gLeaveAbsence.Location = new System.Drawing.Point(0, 0);
            this.gLeaveAbsence.MainView = this.gvLeaveAbsence;
            this.gLeaveAbsence.Name = "gLeaveAbsence";
            this.gLeaveAbsence.Size = new System.Drawing.Size(901, 597);
            this.gLeaveAbsence.TabIndex = 6;
            this.gLeaveAbsence.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLeaveAbsence});
            // 
            // gvLeaveAbsence
            // 
            this.gvLeaveAbsence.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDLeaveAbsence,
            this.IDStaff,
            this.FromDate,
            this.ToDate,
            this.TotalDay,
            this.Descript,
            this.Status});
            this.gvLeaveAbsence.GridControl = this.gLeaveAbsence;
            this.gvLeaveAbsence.Name = "gvLeaveAbsence";
            this.gvLeaveAbsence.OptionsView.ShowGroupPanel = false;
            // 
            // IDLeaveAbsence
            // 
            this.IDLeaveAbsence.Caption = "Mã Đơn Xin";
            this.IDLeaveAbsence.FieldName = "IDLeaveAbsence";
            this.IDLeaveAbsence.MinWidth = 25;
            this.IDLeaveAbsence.Name = "IDLeaveAbsence";
            this.IDLeaveAbsence.Width = 94;
            // 
            // IDStaff
            // 
            this.IDStaff.Caption = "Mã Nhân Viên";
            this.IDStaff.FieldName = "IDStaff";
            this.IDStaff.MinWidth = 25;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.Visible = true;
            this.IDStaff.VisibleIndex = 0;
            this.IDStaff.Width = 94;
            // 
            // FromDate
            // 
            this.FromDate.Caption = "Từ Ngày";
            this.FromDate.FieldName = "FromDate";
            this.FromDate.MinWidth = 25;
            this.FromDate.Name = "FromDate";
            this.FromDate.Visible = true;
            this.FromDate.VisibleIndex = 1;
            this.FromDate.Width = 94;
            // 
            // ToDate
            // 
            this.ToDate.Caption = "Đến Ngày";
            this.ToDate.FieldName = "ToDate";
            this.ToDate.MinWidth = 25;
            this.ToDate.Name = "ToDate";
            this.ToDate.Visible = true;
            this.ToDate.VisibleIndex = 2;
            this.ToDate.Width = 94;
            // 
            // TotalDay
            // 
            this.TotalDay.Caption = "Tổng Số Ngày";
            this.TotalDay.FieldName = "TotalDay";
            this.TotalDay.MinWidth = 25;
            this.TotalDay.Name = "TotalDay";
            this.TotalDay.Visible = true;
            this.TotalDay.VisibleIndex = 3;
            this.TotalDay.Width = 94;
            // 
            // Descript
            // 
            this.Descript.Caption = "Giải trình";
            this.Descript.FieldName = "Descript";
            this.Descript.MinWidth = 25;
            this.Descript.Name = "Descript";
            this.Descript.Visible = true;
            this.Descript.VisibleIndex = 4;
            this.Descript.Width = 94;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng Thái";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 5;
            this.Status.Width = 94;
            // 
            // UCLeaveAbsence
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCLeaveAbsence";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCLeaveAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gLeaveAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gLeaveAbsence;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLeaveAbsence;
        private DevExpress.XtraGrid.Columns.GridColumn FromDate;
        private DevExpress.XtraGrid.Columns.GridColumn ToDate;
        private DevExpress.XtraGrid.Columns.GridColumn Descript;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private System.Windows.Forms.Label lbRemain;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn IDLeaveAbsence;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDay;
        private DevExpress.XtraEditors.SimpleButton btnRefuse;
        private DevExpress.XtraEditors.SimpleButton btnAgree;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
    }
}
