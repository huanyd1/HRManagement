namespace HRManagement.Screens.Position
{
    partial class UCPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPosition));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbInsuranceType = new System.Windows.Forms.ComboBox();
            this.txtInsuranceName = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDInsurance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gInsurance = new DevExpress.XtraGrid.GridControl();
            this.gvInsurance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsuranceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsurance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tablePanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.cbInsuranceType);
            this.panel3.Controls.Add(this.txtInsuranceName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDInsurance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 70);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(721, 63);
            this.panel3.TabIndex = 2;
            // 
            // cbInsuranceType
            // 
            this.cbInsuranceType.Font = new System.Drawing.Font("Cascadia Code", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInsuranceType.FormattingEnabled = true;
            this.cbInsuranceType.Location = new System.Drawing.Point(450, 44);
            this.cbInsuranceType.Name = "cbInsuranceType";
            this.cbInsuranceType.Size = new System.Drawing.Size(190, 20);
            this.cbInsuranceType.TabIndex = 12;
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceName.Location = new System.Drawing.Point(240, 44);
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.Size = new System.Drawing.Size(190, 20);
            this.txtInsuranceName.TabIndex = 10;
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
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại bảo hiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên bảo hiểm";
            // 
            // txtIDInsurance
            // 
            this.txtIDInsurance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDInsurance.Location = new System.Drawing.Point(29, 44);
            this.txtIDInsurance.Name = "txtIDInsurance";
            this.txtIDInsurance.Size = new System.Drawing.Size(190, 20);
            this.txtIDInsurance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bảo hiểm";
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gInsurance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 138);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(721, 410);
            this.panel2.TabIndex = 1;
            // 
            // gInsurance
            // 
            this.gInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gInsurance.Location = new System.Drawing.Point(0, 0);
            this.gInsurance.MainView = this.gvInsurance;
            this.gInsurance.Name = "gInsurance";
            this.gInsurance.Size = new System.Drawing.Size(721, 410);
            this.gInsurance.TabIndex = 4;
            this.gInsurance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInsurance});
            // 
            // gvInsurance
            // 
            this.gvInsurance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDInsurance,
            this.InsuranceName,
            this.IDInsuranceType,
            this.TypeName,
            this.Amount});
            this.gvInsurance.GridControl = this.gInsurance;
            this.gvInsurance.Name = "gvInsurance";
            this.gvInsurance.OptionsView.ShowGroupPanel = false;
            // 
            // IDInsurance
            // 
            this.IDInsurance.Caption = "Mã Bảo Hiểm";
            this.IDInsurance.FieldName = "IDInsurance";
            this.IDInsurance.MinWidth = 25;
            this.IDInsurance.Name = "IDInsurance";
            this.IDInsurance.Visible = true;
            this.IDInsurance.VisibleIndex = 0;
            this.IDInsurance.Width = 94;
            // 
            // InsuranceName
            // 
            this.InsuranceName.Caption = "Tên Bảo Hiểm";
            this.InsuranceName.FieldName = "InsuranceName";
            this.InsuranceName.MinWidth = 25;
            this.InsuranceName.Name = "InsuranceName";
            this.InsuranceName.Visible = true;
            this.InsuranceName.VisibleIndex = 1;
            this.InsuranceName.Width = 94;
            // 
            // IDInsuranceType
            // 
            this.IDInsuranceType.Caption = "Loại Bảo Hiểm";
            this.IDInsuranceType.DisplayFormat.FormatString = "fe";
            this.IDInsuranceType.FieldName = "IDInsuranceType";
            this.IDInsuranceType.MinWidth = 25;
            this.IDInsuranceType.Name = "IDInsuranceType";
            this.IDInsuranceType.Width = 94;
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Loại Bảo Hiểm";
            this.TypeName.FieldName = "TypeName";
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 2;
            // 
            // Amount
            // 
            this.Amount.Caption = "Số Tiền";
            this.Amount.DisplayFormat.FormatString = "#,### VNĐ";
            this.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Vị trí";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // UCPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCPosition";
            this.Size = new System.Drawing.Size(907, 688);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsurance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbInsuranceType;
        private System.Windows.Forms.TextBox txtInsuranceName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDInsurance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gInsurance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceName;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsuranceType;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
