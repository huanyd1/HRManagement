using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Model;
using Model.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HRManagement.Screens.StaffCourse
{
    public partial class FormInfoStaffCourse : DevExpress.XtraEditors.XtraForm
    {
        private string _idStaff;

        public FormInfoStaffCourse()
        {
            InitializeComponent();
        }

        public string IdStaff
        {
            set { _idStaff = value; }
        }

        private void LoadInfoStaffCourse()
        {
            StaffDAO staff = new StaffDAO();
            StaffCourseDAO dao = new StaffCourseDAO();

            txtIDStaff.Text = _idStaff;
            txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
            gStaffCourse.DataSource = dao.AllInfoStaffCourseByIDStaff(_idStaff);
        }

        private void FormChangeStaffCourse_Load(object sender, EventArgs e)
        {
            this.Text = ActionCommon.InfoAction("Nhân viên - Khóa học");
            LoadInfoStaffCourse();

            gvStaffCourse.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Result")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvStaffCourse_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Result" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Result").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Chưa hoàn thành"; break;
                    case "1": e.DisplayText = "Hoàn thành"; break;
                }
            }
        }
    }
}