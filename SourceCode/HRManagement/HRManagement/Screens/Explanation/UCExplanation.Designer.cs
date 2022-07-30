namespace HRManagement.Screens.Explanation
{
    partial class UCExplanation
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExplanation));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gInsurance = new DevExpress.XtraGrid.GridControl();
            this.gvInsurance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsuranceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // gInsurance
            // 
            this.gInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gInsurance.Location = new System.Drawing.Point(0, 0);
            this.gInsurance.MainView = this.gvInsurance;
            this.gInsurance.Name = "gInsurance";
            this.gInsurance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnStudy});
            this.gInsurance.Size = new System.Drawing.Size(901, 597);
            this.gInsurance.TabIndex = 6;
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
            this.Amount.ColumnEdit = this.btnStudy;
            this.Amount.DisplayFormat.FormatString = "#,### VNĐ";
            this.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 79);
            this.panel1.TabIndex = 6;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH GIẢI TRÌNH";
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
            this.tablePanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.gInsurance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 1);
            this.panel2.Size = new System.Drawing.Size(901, 597);
            this.panel2.TabIndex = 7;
            // 
            // btnStudy
            // 
            this.btnStudy.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnStudy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnStudy.Name = "btnStudy";
            // 
            // UCExplanation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCExplanation";
            this.Size = new System.Drawing.Size(907, 688);
            ((System.ComponentModel.ISupportInitialize)(this.gInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStudy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gInsurance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceName;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsuranceType;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnStudy;
    }
}
