using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HRManagement.Screens.Course
{
    public partial class UCStaffCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffCourse()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tabNavigationPage1.PageText = "Các khóa học đang mở";
            tabNavigationPage2.PageText = "Các khóa học đã hoàn thành";
        }

        private void LoadAllCourse()
        {
            CourseDAO dao = new CourseDAO();
            gCourse.DataSource = dao.GetAll();
        }

        private void LoadAllCourseComplete()
        {
            StaffCourseDAO dao = new StaffCourseDAO();
            gStaffCourse.DataSource = dao.AllCourseCompleteByIDStaff(InfoStaffCommon.IDStaff);
        }

        private void UCStaffCourse_Load(object sender, EventArgs e)
        {
            LoadAllCourse();
            LoadAllCourseComplete();

            gvCourse.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Status")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };

            gvStaffCourse.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Result")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };
        }

        private void gvCourse_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Không hoạt động"; break;
                    case "1": e.DisplayText = "Hoạt động"; break;
                }
            }
        }

        private void gvStaffCourse_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
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
