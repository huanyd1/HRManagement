namespace HRManagement.Screens.StaffCourse
{
    partial class FormInfoStaffCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoStaffCourse));
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTax = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAllowance = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gStaffCourse = new DevExpress.XtraGrid.GridControl();
            this.gvStaffCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDStaffCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAllowance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // errorTax
            // 
            this.errorTax.ContainerControl = this;
            // 
            // errorAllowance
            // 
            this.errorAllowance.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 104);
            this.panel1.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(538, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 55);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStaffName);
            this.panel2.Controls.Add(this.txtIDStaff);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 65);
            this.panel2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(470, 22);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(193, 23);
            this.txtStaffName.TabIndex = 55;
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(140, 22);
            this.txtIDStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(193, 23);
            this.txtIDStaff.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã nhân viên:";
            // 
            // gStaffCourse
            // 
            this.gStaffCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStaffCourse.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gStaffCourse.Location = new System.Drawing.Point(0, 65);
            this.gStaffCourse.MainView = this.gvStaffCourse;
            this.gStaffCourse.Margin = new System.Windows.Forms.Padding(4);
            this.gStaffCourse.Name = "gStaffCourse";
            this.gStaffCourse.Size = new System.Drawing.Size(698, 131);
            this.gStaffCourse.TabIndex = 52;
            this.gStaffCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStaffCourse});
            // 
            // gvStaffCourse
            // 
            this.gvStaffCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDStaffCourse,
            this.IDCourse,
            this.CourseName,
            this.Point,
            this.Result});
            this.gvStaffCourse.DetailHeight = 431;
            this.gvStaffCourse.GridControl = this.gStaffCourse;
            this.gvStaffCourse.Name = "gvStaffCourse";
            this.gvStaffCourse.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvStaffCourse.OptionsView.ShowGroupPanel = false;
            this.gvStaffCourse.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvStaffCourse_CustomColumnDisplayText);
            // 
            // IDStaffCourse
            // 
            this.IDStaffCourse.Caption = "Mã Nhân Viên - Khóa học";
            this.IDStaffCourse.FieldName = "IDStaffCourse";
            this.IDStaffCourse.MinWidth = 29;
            this.IDStaffCourse.Name = "IDStaffCourse";
            this.IDStaffCourse.Visible = true;
            this.IDStaffCourse.VisibleIndex = 0;
            this.IDStaffCourse.Width = 110;
            // 
            // IDCourse
            // 
            this.IDCourse.Caption = "Mã Khóa Học";
            this.IDCourse.FieldName = "IDCourse";
            this.IDCourse.MinWidth = 29;
            this.IDCourse.Name = "IDCourse";
            this.IDCourse.Visible = true;
            this.IDCourse.VisibleIndex = 1;
            this.IDCourse.Width = 110;
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Tên Khóa Học";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.MinWidth = 23;
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 2;
            this.CourseName.Width = 87;
            // 
            // Point
            // 
            this.Point.Caption = "Điểm số";
            this.Point.FieldName = "Point";
            this.Point.MinWidth = 23;
            this.Point.Name = "Point";
            this.Point.Visible = true;
            this.Point.VisibleIndex = 3;
            this.Point.Width = 87;
            // 
            // Result
            // 
            this.Result.Caption = "Kết quả";
            this.Result.FieldName = "Result";
            this.Result.MinWidth = 23;
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 4;
            this.Result.Width = 87;
            // 
            // FormInfoStaffCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(698, 300);
            this.Controls.Add(this.gStaffCourse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInfoStaffCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangeStaffCourse";
            this.Load += new System.EventHandler(this.FormChangeStaffCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAllowance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gStaffCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorAmount;
        private System.Windows.Forms.ErrorProvider errorTax;
        private System.Windows.Forms.ErrorProvider errorAllowance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl gStaffCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaffCourse;
        private DevExpress.XtraGrid.Columns.GridColumn IDStaffCourse;
        private DevExpress.XtraGrid.Columns.GridColumn IDCourse;
        private DevExpress.XtraGrid.Columns.GridColumn CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn Point;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label2;
    }
}