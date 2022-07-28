using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.StaffCourse
{
    public partial class UCStaffCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffCourse()
        {
            InitializeComponent();
        }

        private void LoadInfoCourse()
        {
            CourseDAO dao = new CourseDAO();
            cbCourse.DataSource = dao.GetAll();
            cbCourse.DisplayMember = "CourseName";
            cbCourse.ValueMember = "IDCourse";
        }

        private void LoadAllStaffCourse()
        {
            StaffCourseDAO dao = new StaffCourseDAO();
            gStaffCourse.DataSource = dao.AllInfoStaffCourse();
        }

        private void UCStaffCourse_Load(object sender, EventArgs e)
        {
            LoadInfoCourse();
            gvStaffCourse.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Result")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };

            LoadAllStaffCourse();
            gvStaffCourse.OptionsView.AllowCellMerge = true; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(gvStaffCourse.RowCount > 0)
            {
                string idStaff = gvStaffCourse.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeStaffCourse addStaffCourse = new FormChangeStaffCourse();
                addStaffCourse.IdStaff = idStaff;
                addStaffCourse.Show();
            }

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvStaffCourse.RowCount > 0)
            {
                string idStaff = gvStaffCourse.GetFocusedRowCellValue("IDStaff").ToString();

                FormInfoStaffCourse addStaffCourse = new FormInfoStaffCourse();
                addStaffCourse.IdStaff = idStaff;
                addStaffCourse.Show();
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvStaffCourse.RowCount > 0)
            {
                string courseName = gvStaffCourse.GetFocusedRowCellValue("CourseName").ToString();
                string staffName = gvStaffCourse.GetFocusedRowCellValue("StaffName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteStaffCourse(courseName, staffName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int point = int.Parse(gvStaffCourse.GetFocusedRowCellValue("Point").ToString());

                    if (point >= 80)
                    {
                        MessageBox.Show("Không thể xóa khóa học đã hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int idStaffCourse = int.Parse(gvStaffCourse.GetFocusedRowCellValue("IDStaffCourse").ToString());

                        StaffCourseDAO dao = new StaffCourseDAO();
                        if (dao.Delete(idStaffCourse))
                        {
                            Model.NotificationCommon.DeleteSuccess("Khóa học");
                            LoadAllStaffCourse();
                        }
                        else
                        {
                            Model.NotificationCommon.DeleteFaild("Khóa học");
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string staffName = txtStaffName.Text.ToString();
            string idCourse = cbCourse.SelectedValue.ToString();

            StaffCourseDAO dao = new StaffCourseDAO();
            gStaffCourse.DataSource = dao.GetAllCourseByFilter(staffName, idCourse);
        }
    }
}
