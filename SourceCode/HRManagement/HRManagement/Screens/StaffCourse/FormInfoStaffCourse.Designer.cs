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
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 66);
            this.panel1.TabIndex = 50;
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
            this.panel2.TabIndex = 51;
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
            // gStaffCourse
            // 
            this.gStaffCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStaffCourse.Location = new System.Drawing.Point(0, 53);
            this.gStaffCourse.MainView = this.gvStaffCourse;
            this.gStaffCourse.Name = "gStaffCourse";
            this.gStaffCourse.Size = new System.Drawing.Size(598, 211);
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
            this.gvStaffCourse.GridControl = this.gStaffCourse;
            this.gvStaffCourse.Name = "gvStaffCourse";
            this.gvStaffCourse.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvStaffCourse.OptionsView.ShowGroupPanel = false;
            // 
            // IDStaffCourse
            // 
            this.IDStaffCourse.Caption = "Mã Nhân Viên - Khóa học";
            this.IDStaffCourse.FieldName = "IDStaffCourse";
            this.IDStaffCourse.MinWidth = 25;
            this.IDStaffCourse.Name = "IDStaffCourse";
            this.IDStaffCourse.Visible = true;
            this.IDStaffCourse.VisibleIndex = 0;
            this.IDStaffCourse.Width = 94;
            // 
            // IDCourse
            // 
            this.IDCourse.Caption = "Mã Khóa Học";
            this.IDCourse.FieldName = "IDCourse";
            this.IDCourse.MinWidth = 25;
            this.IDCourse.Name = "IDCourse";
            this.IDCourse.Visible = true;
            this.IDCourse.VisibleIndex = 1;
            this.IDCourse.Width = 94;
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Tên Khóa Học";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 2;
            // 
            // Point
            // 
            this.Point.Caption = "Điểm số";
            this.Point.FieldName = "Point";
            this.Point.Name = "Point";
            this.Point.Visible = true;
            this.Point.VisibleIndex = 3;
            // 
            // Result
            // 
            this.Result.Caption = "Kết quả";
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 4;
            // 
            // FormChangeStaffCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 330);
            this.Controls.Add(this.gStaffCourse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChangeStaffCourse";
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