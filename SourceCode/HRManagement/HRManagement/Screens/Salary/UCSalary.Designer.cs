﻿namespace HRManagement.Screens.Salary
{
    partial class UCSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSalary));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gSalary = new DevExpress.XtraGrid.GridControl();
            this.gvSalary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalaryAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coefficient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Allowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(907, 688);
            this.tablePanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(901, 79);
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 79);
            this.panel4.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.Location = new System.Drawing.Point(420, 41);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(115, 35);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Xem CT";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(783, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(662, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(541, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Lương";
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.txtStaffName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.txtIDStaff);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(901, 79);
            this.panel3.TabIndex = 2;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(264, 44);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(190, 23);
            this.txtStaffName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 15);
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
            this.btnSearch.Location = new System.Drawing.Point(511, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(632, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 35);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Xuất DL";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(29, 44);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(190, 23);
            this.txtIDStaff.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gSalary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 173);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(901, 512);
            this.panel2.TabIndex = 1;
            // 
            // gSalary
            // 
            this.gSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSalary.Location = new System.Drawing.Point(0, 0);
            this.gSalary.MainView = this.gvSalary;
            this.gSalary.Name = "gSalary";
            this.gSalary.Size = new System.Drawing.Size(901, 512);
            this.gSalary.TabIndex = 4;
            this.gSalary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSalary});
            // 
            // gvSalary
            // 
            this.gvSalary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDStaff,
            this.StaffName,
            this.IDDepartment,
            this.DepartmentName,
            this.SalaryAmount,
            this.Coefficient,
            this.Allowance,
            this.Tax});
            this.gvSalary.GridControl = this.gSalary;
            this.gvSalary.Name = "gvSalary";
            this.gvSalary.OptionsView.ShowGroupPanel = false;
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
            // StaffName
            // 
            this.StaffName.Caption = "Tên Nhân Viên";
            this.StaffName.FieldName = "StaffName";
            this.StaffName.MinWidth = 25;
            this.StaffName.Name = "StaffName";
            this.StaffName.Visible = true;
            this.StaffName.VisibleIndex = 1;
            this.StaffName.Width = 94;
            // 
            // IDDepartment
            // 
            this.IDDepartment.Caption = "Mã Phòng Ban";
            this.IDDepartment.FieldName = "IDDepartment";
            this.IDDepartment.MinWidth = 25;
            this.IDDepartment.Name = "IDDepartment";
            this.IDDepartment.Width = 94;
            // 
            // DepartmentName
            // 
            this.DepartmentName.Caption = "Tên Phòng Ban";
            this.DepartmentName.FieldName = "DepartmentName";
            this.DepartmentName.MinWidth = 25;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Visible = true;
            this.DepartmentName.VisibleIndex = 2;
            this.DepartmentName.Width = 94;
            // 
            // SalaryAmount
            // 
            this.SalaryAmount.Caption = "Số tiền";
            this.SalaryAmount.DisplayFormat.FormatString = "#,### VNĐ";
            this.SalaryAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalaryAmount.FieldName = "SalaryAmount";
            this.SalaryAmount.MinWidth = 25;
            this.SalaryAmount.Name = "SalaryAmount";
            this.SalaryAmount.Visible = true;
            this.SalaryAmount.VisibleIndex = 3;
            this.SalaryAmount.Width = 94;
            // 
            // Coefficient
            // 
            this.Coefficient.Caption = "Hệ số lương";
            this.Coefficient.FieldName = "Coefficient";
            this.Coefficient.MinWidth = 25;
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Visible = true;
            this.Coefficient.VisibleIndex = 5;
            this.Coefficient.Width = 94;
            // 
            // Allowance
            // 
            this.Allowance.Caption = "Phụ cấp";
            this.Allowance.DisplayFormat.FormatString = "#,### VNĐ";
            this.Allowance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Allowance.FieldName = "Allowance";
            this.Allowance.MinWidth = 25;
            this.Allowance.Name = "Allowance";
            this.Allowance.Visible = true;
            this.Allowance.VisibleIndex = 4;
            this.Allowance.Width = 94;
            // 
            // Tax
            // 
            this.Tax.Caption = "Thuế TNCN";
            this.Tax.DisplayFormat.FormatString = "#,### VNĐ";
            this.Tax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Tax.FieldName = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.Visible = true;
            this.Tax.VisibleIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // UCSalary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCSalary";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSalary;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryAmount;
        private DevExpress.XtraGrid.Columns.GridColumn Allowance;
        private DevExpress.XtraGrid.Columns.GridColumn Tax;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
        private DevExpress.XtraGrid.Columns.GridColumn StaffName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn IDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn Coefficient;
    }
}
