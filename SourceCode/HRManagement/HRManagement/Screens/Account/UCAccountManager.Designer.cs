namespace HRManagement.Screens.Account
{
    partial class UCAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAccountManager));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gAccount = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(541, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.cbContractType);
            this.panel3.Controls.Add(this.txtStaffName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDStaff);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(901, 79);
            this.panel3.TabIndex = 2;
            // 
            // cbContractType
            // 
            this.cbContractType.Font = new System.Drawing.Font("Cascadia Code", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(450, 44);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(190, 23);
            this.cbContractType.TabIndex = 12;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(240, 44);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(190, 23);
            this.txtStaffName.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(662, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(783, 29);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 35);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Xuất DL";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại hợp đồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
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
            // btnReset
            // 
            this.btnReset.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.Location = new System.Drawing.Point(420, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
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
            // Username
            // 
            this.Username.Caption = "Tên Đăng Nhập";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 1;
            // 
            // StaffName
            // 
            this.StaffName.Caption = "Tên Nhân Viên";
            this.StaffName.FieldName = "StaffName";
            this.StaffName.Name = "StaffName";
            this.StaffName.Visible = true;
            this.StaffName.VisibleIndex = 0;
            // 
            // IDStaff
            // 
            this.IDStaff.Caption = "Mã Nhân Viên";
            this.IDStaff.FieldName = "IDStaff";
            this.IDStaff.MinWidth = 25;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.Width = 94;
            // 
            // gvAccount
            // 
            this.gvAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDStaff,
            this.StaffName,
            this.Username,
            this.Type,
            this.Status});
            this.gvAccount.GridControl = this.gAccount;
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.OptionsView.ShowGroupPanel = false;
            this.gvAccount.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvAccount_CustomColumnDisplayText);
            // 
            // Type
            // 
            this.Type.Caption = "Phân quyền";
            this.Type.FieldName = "Type";
            this.Type.MinWidth = 25;
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 2;
            this.Type.Width = 94;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 94;
            // 
            // gAccount
            // 
            this.gAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gAccount.Location = new System.Drawing.Point(0, 0);
            this.gAccount.MainView = this.gvAccount;
            this.gAccount.Name = "gAccount";
            this.gAccount.Size = new System.Drawing.Size(901, 512);
            this.gAccount.TabIndex = 4;
            this.gAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccount});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Tài khoản";
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 173);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(901, 512);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 99);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.Location = new System.Drawing.Point(299, 41);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(115, 35);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Xem CT";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F)});
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(907, 688);
            this.tablePanel1.TabIndex = 3;
            // 
            // UCAccountManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCAccountManager";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccount;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
        private DevExpress.XtraGrid.Columns.GridColumn StaffName;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.TextBox txtStaffName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
    }
}
