namespace HRManagement.Screens.Timekeeping
{
    partial class FormInfoTimekeeping
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
            this.gSalary = new DevExpress.XtraGrid.GridControl();
            this.gvSalary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // gSalary
            // 
            this.gSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSalary.Location = new System.Drawing.Point(0, 0);
            this.gSalary.MainView = this.gvSalary;
            this.gSalary.Name = "gSalary";
            this.gSalary.Size = new System.Drawing.Size(755, 552);
            this.gSalary.TabIndex = 5;
            this.gSalary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSalary});
            // 
            // gvSalary
            // 
            this.gvSalary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.Time});
            this.gvSalary.GridControl = this.gSalary;
            this.gvSalary.Name = "gvSalary";
            this.gvSalary.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSalary.OptionsView.ShowGroupPanel = false;
            this.gvSalary.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvSalary_CustomColumnDisplayText);
            // 
            // Date
            // 
            this.Date.Caption = "Ngày";
            this.Date.FieldName = "Date";
            this.Date.MinWidth = 25;
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            this.Date.Width = 94;
            // 
            // Time
            // 
            this.Time.Caption = "Công";
            this.Time.FieldName = "Time";
            this.Time.MinWidth = 25;
            this.Time.Name = "Time";
            this.Time.Visible = true;
            this.Time.VisibleIndex = 1;
            this.Time.Width = 94;
            // 
            // FormInfoTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 552);
            this.Controls.Add(this.gSalary);
            this.Name = "FormInfoTimekeeping";
            this.Text = "FormInfoTimekeeping";
            this.Load += new System.EventHandler(this.FormInfoTimekeeping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSalary;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
    }
}