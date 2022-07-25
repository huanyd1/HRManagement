namespace HRManagement.Screens.Contract
{
    partial class UCContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContract));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.IDType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDContract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvContract = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gContract = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContract)).BeginInit();
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
            // btnAddDepartment
            // 
            this.btnAddDepartment.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Appearance.Options.UseFont = true;
            this.btnAddDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.ImageOptions.Image")));
            this.btnAddDepartment.Location = new System.Drawing.Point(541, 41);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(115, 35);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Thêm mới";
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.txtDepartmentName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDDepartment);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(901, 79);
            this.panel3.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Cascadia Code", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(450, 44);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 23);
            this.cbStatus.TabIndex = 12;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(240, 44);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(190, 23);
            this.txtDepartmentName.TabIndex = 10;
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
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên hợp đồng";
            // 
            // txtIDDepartment
            // 
            this.txtIDDepartment.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDepartment.Location = new System.Drawing.Point(29, 44);
            this.txtIDDepartment.Name = "txtIDDepartment";
            this.txtIDDepartment.Size = new System.Drawing.Size(190, 23);
            this.txtIDDepartment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hợp đồng";
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
            // 
            // IDType
            // 
            this.IDType.Caption = "Mã Loại Hợp Đồng";
            this.IDType.FieldName = "IDType";
            this.IDType.MinWidth = 25;
            this.IDType.Name = "IDType";
            this.IDType.Visible = true;
            this.IDType.VisibleIndex = 2;
            this.IDType.Width = 94;
            // 
            // ContractName
            // 
            this.ContractName.Caption = "Tên Hợp Đồng";
            this.ContractName.FieldName = "ContractName";
            this.ContractName.MinWidth = 25;
            this.ContractName.Name = "ContractName";
            this.ContractName.Visible = true;
            this.ContractName.VisibleIndex = 1;
            this.ContractName.Width = 94;
            // 
            // IDContract
            // 
            this.IDContract.Caption = "Mã Hợp Đồng";
            this.IDContract.FieldName = "IDContract";
            this.IDContract.MinWidth = 25;
            this.IDContract.Name = "IDContract";
            this.IDContract.Visible = true;
            this.IDContract.VisibleIndex = 0;
            this.IDContract.Width = 94;
            // 
            // gvContract
            // 
            this.gvContract.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDContract,
            this.ContractName,
            this.IDType,
            this.TypeName});
            this.gvContract.GridControl = this.gContract;
            this.gvContract.Name = "gvContract";
            this.gvContract.OptionsView.ShowGroupPanel = false;
            // 
            // gContract
            // 
            this.gContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gContract.Location = new System.Drawing.Point(0, 0);
            this.gContract.MainView = this.gvContract;
            this.gContract.Name = "gContract";
            this.gContract.Size = new System.Drawing.Size(901, 512);
            this.gContract.TabIndex = 4;
            this.gContract.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContract});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Hợp đồng";
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gContract);
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
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddDepartment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 124);
            this.panel1.TabIndex = 0;
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
            this.tablePanel1.TabIndex = 1;
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Loại Hợp Đồng";
            this.TypeName.FieldName = "TypeName";
            this.TypeName.MinWidth = 25;
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 3;
            this.TypeName.Width = 94;
            // 
            // UCContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCContract";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContract)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAddDepartment;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gContract;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContract;
        private DevExpress.XtraGrid.Columns.GridColumn IDContract;
        private DevExpress.XtraGrid.Columns.GridColumn ContractName;
        private DevExpress.XtraGrid.Columns.GridColumn IDType;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDDepartment;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
    }
}
