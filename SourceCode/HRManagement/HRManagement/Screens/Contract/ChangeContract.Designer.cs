namespace HRManagement.Screens.Contract
{
    partial class ChangeContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeContract));
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.txtNumberContract = new System.Windows.Forms.TextBox();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorNumberContract = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContractName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddType = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtimeStartDate = new DevExpress.XtraEditors.DateEdit();
            this.dtimeEndDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContractName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeEndDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbContractType
            // 
            this.cbContractType.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(138, 120);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(208, 25);
            this.cbContractType.TabIndex = 23;
            // 
            // txtNumberContract
            // 
            this.txtNumberContract.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberContract.Location = new System.Drawing.Point(135, 174);
            this.txtNumberContract.Name = "txtNumberContract";
            this.txtNumberContract.Size = new System.Drawing.Size(244, 23);
            this.txtNumberContract.TabIndex = 22;
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(138, 18);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(241, 23);
            this.txtIDStaff.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Loại hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã nhân viên:";
            // 
            // errorNumberContract
            // 
            this.errorNumberContract.ContainerControl = this;
            // 
            // errorContractName
            // 
            this.errorContractName.ContainerControl = this;
            // 
            // btnAddType
            // 
            this.btnAddType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddType.ImageOptions.Image")));
            this.btnAddType.Location = new System.Drawing.Point(352, 120);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(24, 22);
            this.btnAddType.TabIndex = 28;
            this.btnAddType.ToolTip = "Thêm mới Loại hợp đồng";
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(244, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(87, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(135, 66);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(241, 23);
            this.txtStaffName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tên nhân viên:";
            // 
            // txtContractName
            // 
            this.txtContractName.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractName.Location = new System.Drawing.Point(135, 225);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(244, 23);
            this.txtContractName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên hợp đồng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày BĐ:";
            // 
            // dtimeStartDate
            // 
            this.dtimeStartDate.EditValue = null;
            this.dtimeStartDate.Location = new System.Drawing.Point(135, 281);
            this.dtimeStartDate.Name = "dtimeStartDate";
            this.dtimeStartDate.Properties.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeStartDate.Properties.Appearance.Options.UseFont = true;
            this.dtimeStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtimeStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtimeStartDate.Size = new System.Drawing.Size(241, 24);
            this.dtimeStartDate.TabIndex = 34;
            // 
            // dtimeEndDate
            // 
            this.dtimeEndDate.EditValue = null;
            this.dtimeEndDate.Location = new System.Drawing.Point(135, 334);
            this.dtimeEndDate.Name = "dtimeEndDate";
            this.dtimeEndDate.Properties.Appearance.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeEndDate.Properties.Appearance.Options.UseFont = true;
            this.dtimeEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtimeEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtimeEndDate.Size = new System.Drawing.Size(241, 24);
            this.dtimeEndDate.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày HH:";
            // 
            // ChangeContract
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 483);
            this.Controls.Add(this.dtimeEndDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtimeStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContractName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.txtNumberContract);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeContract";
            this.Load += new System.EventHandler(this.ChangeContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContractName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeEndDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.TextBox txtNumberContract;
        private System.Windows.Forms.TextBox txtIDStaff;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorNumberContract;
        private System.Windows.Forms.ErrorProvider errorContractName;
        private DevExpress.XtraEditors.SimpleButton btnAddType;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtimeEndDate;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dtimeStartDate;
        private System.Windows.Forms.Label label6;
    }
}