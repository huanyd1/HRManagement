namespace HRManagement.Screens.StaffInsurance
{
    partial class FormInfoStaffInsurance
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoStaffInsurance));
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorAllowance = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTax = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.gStaffInsurance = new DevExpress.XtraGrid.GridControl();
            this.gvStaffInsurance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDStaffInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDInsuranceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(389, 13);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(166, 21);
            this.txtStaffName.TabIndex = 55;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(461, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Thoát";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(108, 13);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(166, 21);
            this.txtIDStaff.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã nhân viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 66);
            this.panel1.TabIndex = 53;
            // 
            // errorAllowance
            // 
            this.errorAllowance.ContainerControl = this;
            // 
            // errorTax
            // 
            this.errorTax.ContainerControl = this;
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStaffName);
            this.panel2.Controls.Add(this.txtIDStaff);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 53);
            this.panel2.TabIndex = 54;
            // 
            // gStaffInsurance
            // 
            this.gStaffInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStaffInsurance.Location = new System.Drawing.Point(0, 53);
            this.gStaffInsurance.MainView = this.gvStaffInsurance;
            this.gStaffInsurance.Name = "gStaffInsurance";
            this.gStaffInsurance.Size = new System.Drawing.Size(598, 211);
            this.gStaffInsurance.TabIndex = 55;
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
            this.gvStaffInsurance.GridControl = this.gStaffInsurance;
            this.gvStaffInsurance.Name = "gvStaffInsurance";
            this.gvStaffInsurance.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvStaffInsurance.OptionsView.ShowGroupPanel = false;
            // 
            // IDStaff
            // 
            this.IDStaff.Caption = "Mã Nhân Viên";
            this.IDStaff.FieldName = "IDStaff";
            this.IDStaff.MinWidth = 25;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.Visible = true;
            this.IDStaff.VisibleIndex = 1;
            this.IDStaff.Width = 94;
            // 
            // StaffName
            // 
            this.StaffName.Caption = "Tên Nhân Viên";
            this.StaffName.FieldName = "StaffName";
            this.StaffName.MinWidth = 25;
            this.StaffName.Name = "StaffName";
            this.StaffName.Visible = true;
            this.StaffName.VisibleIndex = 2;
            this.StaffName.Width = 94;
            // 
            // IDStaffInsurance
            // 
            this.IDStaffInsurance.Caption = "Mã Nhân Viên - Bảo hiểm";
            this.IDStaffInsurance.FieldName = "IDStaffInsurance";
            this.IDStaffInsurance.MinWidth = 25;
            this.IDStaffInsurance.Name = "IDStaffInsurance";
            this.IDStaffInsurance.Visible = true;
            this.IDStaffInsurance.VisibleIndex = 0;
            this.IDStaffInsurance.Width = 94;
            // 
            // IDInsurance
            // 
            this.IDInsurance.Caption = "Mã Bảo Hiểm";
            this.IDInsurance.FieldName = "IDInsurance";
            this.IDInsurance.MinWidth = 25;
            this.IDInsurance.Name = "IDInsurance";
            this.IDInsurance.Visible = true;
            this.IDInsurance.VisibleIndex = 3;
            this.IDInsurance.Width = 94;
            // 
            // InsuranceName
            // 
            this.InsuranceName.Caption = "Tên Bảo Hiểm";
            this.InsuranceName.FieldName = "InsuranceName";
            this.InsuranceName.Name = "InsuranceName";
            this.InsuranceName.Visible = true;
            this.InsuranceName.VisibleIndex = 4;
            // 
            // IDInsuranceType
            // 
            this.IDInsuranceType.Caption = "Mã Loại Bảo Hiểm";
            this.IDInsuranceType.FieldName = "IDInsuranceType";
            this.IDInsuranceType.Name = "IDInsuranceType";
            this.IDInsuranceType.Visible = true;
            this.IDInsuranceType.VisibleIndex = 5;
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Tên Loại Bảo Hiểm";
            this.TypeName.FieldName = "TypeName";
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 6;
            // 
            // FormInfoStaffInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 330);
            this.Controls.Add(this.gStaffInsurance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormInfoStaffInsurance";
            this.Text = "FormInfoStaffInsurance";
            this.Load += new System.EventHandler(this.FormInfoStaffInsurance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInsurance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorAllowance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorTax;
        private System.Windows.Forms.ErrorProvider errorAmount;
        private DevExpress.XtraGrid.GridControl gStaffInsurance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaffInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaff;
        private DevExpress.XtraGrid.Columns.GridColumn StaffName;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaffInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceName;
        private DevExpress.XtraGrid.Columns.GridColumn IDInsuranceType;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
    }
}