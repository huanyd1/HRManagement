namespace HRManagement
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnDepartment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnInsurance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStaffInsurance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnContract = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSalary = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTimekeeping = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnExplanation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemBreadCrumbEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnStaffCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnDepartment,
            this.btnInsurance,
            this.btnContract,
            this.btnSalary,
            this.btnCourse,
            this.btnTimekeeping,
            this.btnStaff});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(362, 688);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnDepartment
            // 
            this.btnDepartment.ImageOptions.Image = global::HRManagement.Properties.Resources.department1;
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Text = "Phòng ban";
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnStaffInsurance});
            this.btnInsurance.Expanded = true;
            this.btnInsurance.ImageOptions.Image = global::HRManagement.Properties.Resources.insurance;
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Text = "Bảo hiểm";
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // btnStaffInsurance
            // 
            this.btnStaffInsurance.Name = "btnStaffInsurance";
            this.btnStaffInsurance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStaffInsurance.Text = "Nhân viên - Bảo hiểm";
            // 
            // btnContract
            // 
            this.btnContract.ImageOptions.Image = global::HRManagement.Properties.Resources.contract;
            this.btnContract.Name = "btnContract";
            this.btnContract.Text = "Hợp đồng";
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.ImageOptions.Image = global::HRManagement.Properties.Resources.salary;
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Text = "Tiền lương";
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnStaffCourse});
            this.btnCourse.Expanded = true;
            this.btnCourse.ImageOptions.Image = global::HRManagement.Properties.Resources.course;
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Text = "Khóa học";
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnTimekeeping
            // 
            this.btnTimekeeping.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnExplanation});
            this.btnTimekeeping.ImageOptions.Image = global::HRManagement.Properties.Resources.clock;
            this.btnTimekeeping.Name = "btnTimekeeping";
            this.btnTimekeeping.Text = "Chấm công";
            this.btnTimekeeping.Click += new System.EventHandler(this.btnTimekeeping_Click);
            // 
            // btnExplanation
            // 
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnExplanation.Text = "Quản lý giải trình";
            this.btnExplanation.Click += new System.EventHandler(this.btnExplanation_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.ImageOptions.Image = global::HRManagement.Properties.Resources.staff;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem2,
            this.barSubItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barEditItem2,
            this.barEditItem3});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemComboBox2,
            this.repositoryItemBreadCrumbEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1278, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barSubItem2);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Caption = "Xin chào, Admin";
            this.barEditItem1.Edit = this.repositoryItemHypertextLabel1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinDropDownButtonItem1.Id = 6;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem1.Id = 7;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem2
            // 
            this.skinPaletteDropDownButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem2.Id = 8;
            this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem2.Caption = "Xin chào, Admin";
            this.barSubItem2.Id = 12;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đổi mật khẩu";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemImageEdit1;
            this.barEditItem2.Id = 16;
            this.barEditItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem2.ImageOptions.Image")));
            this.barEditItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barEditItem2.ImageOptions.LargeImage")));
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemPictureEdit1;
            this.barEditItem3.Id = 17;
            this.barEditItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItem3.ImageOptions.SvgImage")));
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem2,
            this.barSubItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barEditItem2,
            this.barEditItem3});
            this.fluentFormDefaultManager1.MaxItemId = 18;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemComboBox2,
            this.repositoryItemBreadCrumbEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemBreadCrumbEdit1
            // 
            this.repositoryItemBreadCrumbEdit1.AutoHeight = false;
            this.repositoryItemBreadCrumbEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBreadCrumbEdit1.Name = "repositoryItemBreadCrumbEdit1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = global::HRManagement.Properties.Resources.department1;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Phòng ban";
            // 
            // panelSelect
            // 
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(362, 31);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(916, 688);
            this.panelSelect.TabIndex = 3;
            // 
            // btnStaffCourse
            // 
            this.btnStaffCourse.Name = "btnStaffCourse";
            this.btnStaffCourse.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStaffCourse.Text = "Nhân viên - Khóa học";
            this.btnStaffCourse.Click += new System.EventHandler(this.btnStaffCourse_Click);
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1278, 719);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý Nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDepartment;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit repositoryItemBreadCrumbEdit1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInsurance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnContract;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSalary;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCourse;
        private System.Windows.Forms.Panel panelSelect;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTimekeeping;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnExplanation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStaffInsurance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStaffCourse;
    }
}