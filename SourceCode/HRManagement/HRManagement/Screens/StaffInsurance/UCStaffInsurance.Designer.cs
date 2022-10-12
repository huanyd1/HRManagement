namespace HRManagement.Screens.StaffInsurance
{
    partial class UCStaffInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStaffInsurance));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsuranceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaffInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gStaffInsurance = new DevExpress.XtraGrid.GridControl();
            this.gvStaffInsurance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbInsurance = new System.Windows.Forms.ComboBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInsurance)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Tên Loại Bảo Hiểm";
            this.TypeName.FieldName = "TypeName";
            this.TypeName.MinWidth = 23;
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 6;
            this.TypeName.Width = 87;
            // 
            // IDInsuranceType
            // 
            this.IDInsuranceType.Caption = "Mã Loại Bảo Hiểm";
            this.IDInsuranceType.FieldName = "IDInsuranceType";
            this.IDInsuranceType.MinWidth = 23;
            this.IDInsuranceType.Name = "IDInsuranceType";
            this.IDInsuranceType.Visible = true;
            this.IDInsuranceType.VisibleIndex = 5;
            this.IDInsuranceType.Width = 87;
            // 
            // InsuranceName
            // 
            this.InsuranceName.Caption = "Tên Bảo Hiểm";
            this.InsuranceName.FieldName = "InsuranceName";
            this.InsuranceName.MinWidth = 23;
            this.InsuranceName.Name = "InsuranceName";
            this.InsuranceName.Visible = true;
            this.InsuranceName.VisibleIndex = 4;
            this.InsuranceName.Width = 87;
            // 
            // IDInsurance
            // 
            this.IDInsurance.Caption = "Mã Bảo Hiểm";
            this.IDInsurance.FieldName = "IDInsurance";
            this.IDInsurance.MinWidth = 29;
            this.IDInsurance.Name = "IDInsurance";
            this.IDInsurance.Visible = true;
            this.IDInsurance.VisibleIndex = 3;
            this.IDInsurance.Width = 110;
            // 
            // IDStaffInsurance
            // 
            this.IDStaffInsurance.Caption = "Mã Nhân Viên - Bảo hiểm";
            this.IDStaffInsurance.FieldName = "IDStaffInsurance";
            this.IDStaffInsurance.MinWidth = 29;
            this.IDStaffInsurance.Name = "IDStaffInsurance";
            this.IDStaffInsurance.Visible = true;
            this.IDStaffInsurance.VisibleIndex = 0;
            this.IDStaffInsurance.Width = 110;
            // 
            // StaffName
            // 
            this.StaffName.Caption = "Tên Nhân Viên";
            this.StaffName.FieldName = "StaffName";
            this.StaffName.MinWidth = 29;
            this.StaffName.Name = "StaffName";
            this.StaffName.Visible = true;
            this.StaffName.VisibleIndex = 2;
            this.StaffName.Width = 110;
            // 
            // IDStaff
            // 
            this.IDStaff.Caption = "Mã Nhân Viên";
            this.IDStaff.FieldName = "IDStaff";
            this.IDStaff.MinWidth = 29;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.Visible = true;
            this.IDStaff.VisibleIndex = 1;
            this.IDStaff.Width = 110;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gStaffInsurance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(1050, 629);
            this.panel2.TabIndex = 1;
            // 
            // gStaffInsurance
            // 
            this.gStaffInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStaffInsurance.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gStaffInsurance.Location = new System.Drawing.Point(0, 0);
            this.gStaffInsurance.MainView = this.gvStaffInsurance;
            this.gStaffInsurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gStaffInsurance.Name = "gStaffInsurance";
            this.gStaffInsurance.Size = new System.Drawing.Size(1050, 629);
            this.gStaffInsurance.TabIndex = 4;
            this.gStaffInsurance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStaffInsurance});
            // 
            // gvStaffInsurance
            // 
            this.gvStaffInsurance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDStaff,
            this.StaffName,
            this.IDStaffInsurance,
            this.IDInsurance,
            this.InsuranceName,
            this.IDInsuranceType,
            this.TypeName});
            this.gvStaffInsurance.DetailHeight = 431;
            this.gvStaffInsurance.GridControl = this.gStaffInsurance;
            this.gvStaffInsurance.Name = "gvStaffInsurance";
            this.gvStaffInsurance.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvStaffInsurance.OptionsView.ShowGroupPanel = false;
            // 
            // cbInsurance
            // 
            this.cbInsurance.Font = new System.Drawing.Font("Cascadia Code", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInsurance.FormattingEnabled = true;
            this.cbInsurance.Location = new System.Drawing.Point(540, 41);
            this.cbInsurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInsurance.Name = "cbInsurance";
            this.cbInsurance.Size = new System.Drawing.Size(220, 24);
            this.cbInsurance.TabIndex = 14;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(536, 6);
            this.lbMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(90, 22);
            this.lbMonth.TabIndex = 13;
            this.lbMonth.Text = "Bảo hiểm";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(282, 42);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(221, 23);
            this.txtStaffName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên nhân viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(772, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 43);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(913, 27);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 43);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Xuất DL";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.cbInsurance);
            this.panel3.Controls.Add(this.lbMonth);
            this.panel3.Controls.Add(this.txtStaffName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(1050, 97);
            this.panel3.TabIndex = 2;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F)});
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(1058, 847);
            this.tablePanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(1050, 97);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInfo);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 97);
            this.panel4.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.Location = new System.Drawing.Point(490, 27);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(134, 43);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Xem CT";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(913, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(772, 27);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 43);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(631, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Nhân viên - Bảo hiểm";
            // 
            // UCStaffInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCStaffInsurance";
            this.Size = new System.Drawing.Size(1058, 847);
            this.Load += new System.EventHandler(this.UCStaffInsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gStaffInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInsurance)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsuranceType;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceName;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaffInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn StaffName;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbInsurance;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.GridControl gStaffInsurance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaffInsurance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
    }
}
