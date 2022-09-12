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
            this.gExplanation = new DevExpress.XtraGrid.GridControl();
            this.gvExplanation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Checkin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnStudy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefuse = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgree = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gExplanation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExplanation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gExplanation
            // 
            this.gExplanation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gExplanation.Location = new System.Drawing.Point(0, 0);
            this.gExplanation.MainView = this.gvExplanation;
            this.gExplanation.Name = "gExplanation";
            this.gExplanation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnStudy});
            this.gExplanation.Size = new System.Drawing.Size(901, 597);
            this.gExplanation.TabIndex = 6;
            this.gExplanation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExplanation});
            // 
            // gvExplanation
            // 
            this.gvExplanation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTime,
            this.IDStaff,
            this.Checkin,
            this.Type,
            this.Description,
            this.Status});
            this.gvExplanation.GridControl = this.gExplanation;
            this.gvExplanation.Name = "gvExplanation";
            this.gvExplanation.OptionsView.ShowGroupPanel = false;
            this.gvExplanation.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvExplanation_FocusedRowChanged);
            this.gvExplanation.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvExplanation_CustomColumnDisplayText);
            // 
            // IDTime
            // 
            this.IDTime.Caption = "Mã Chấm Công";
            this.IDTime.FieldName = "IDTime";
            this.IDTime.MinWidth = 25;
            this.IDTime.Name = "IDTime";
            this.IDTime.Width = 94;
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
            // Checkin
            // 
            this.Checkin.Caption = "Ngày";
            this.Checkin.FieldName = "Checkin";
            this.Checkin.MinWidth = 25;
            this.Checkin.Name = "Checkin";
            this.Checkin.Visible = true;
            this.Checkin.VisibleIndex = 1;
            this.Checkin.Width = 94;
            // 
            // Type
            // 
            this.Type.Caption = "Type";
            this.Type.FieldName = "Type";
            this.Type.MinWidth = 25;
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 2;
            this.Type.Width = 94;
            // 
            // Description
            // 
            this.Description.Caption = "Ghi chú/ Giải trình";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 25;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 94;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            this.Status.Width = 94;
            // 
            // btnStudy
            // 
            this.btnStudy.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnStudy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnStudy.Name = "btnStudy";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefuse);
            this.panel1.Controls.Add(this.btnAgree);
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
            this.btnRefuse.TabIndex = 7;
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
            this.btnAgree.TabIndex = 6;
            this.btnAgree.Text = "Duyệt";
            this.btnAgree.Visible = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
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
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách giải trình";
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
            this.panel2.Controls.Add(this.gExplanation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 1);
            this.panel2.Size = new System.Drawing.Size(901, 597);
            this.panel2.TabIndex = 7;
            // 
            // UCExplanation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCExplanation";
            this.Size = new System.Drawing.Size(907, 688);
            this.Load += new System.EventHandler(this.UCExplanation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gExplanation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExplanation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gExplanation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExplanation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnStudy;
        private DevExpress.XtraGrid.Columns.GridColumn IDTime;
        private DevExpress.XtraGrid.Columns.GridColumn Checkin;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.SimpleButton btnRefuse;
        private DevExpress.XtraEditors.SimpleButton btnAgree;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
    }
}
