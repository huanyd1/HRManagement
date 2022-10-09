using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HRManagement.Screens.Course
{
    public partial class UCCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCourse()
        {
            InitializeComponent();
        }

        private void LoadAllCourse()
        {
            CourseDAO dao = new CourseDAO();
            gCourse.DataSource = dao.GetAll();
        }

        private void UCCourse_Load(object sender, EventArgs e)
        {
            LoadAllCourse();

            gvCourse.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Status")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvCourse.RowCount > 0)
            {
                string idCourse = gvCourse.GetFocusedRowCellValue("IDCourse").ToString();

                ChangeCourse infoCourse = new ChangeCourse();
                infoCourse.IsAdd = false;
                infoCourse.IdCourse = idCourse;
                infoCourse.IsInfo = true;
                infoCourse.Show();
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            ChangeCourse addCourse = new ChangeCourse();
            addCourse.IsAdd = true;
            addCourse.Show();

            if (addCourse.IsSave)
            {
                LoadAllCourse();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvCourse.RowCount > 0)
            {
                string idCourse = gvCourse.GetFocusedRowCellValue("IDCourse").ToString();

                ChangeCourse editCourse = new ChangeCourse();
                editCourse.IsAdd = false;
                editCourse.IdCourse = idCourse;
                editCourse.Show();

                if (editCourse.IsSave)
                {
                    LoadAllCourse();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvCourse.RowCount > 0)
            {
                string courseName = gvCourse.GetFocusedRowCellValue("CourseName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteVariable("Khóa học", courseName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string idCourse = gvCourse.GetFocusedRowCellValue("IDCourse").ToString();

                    CourseDAO dao = new CourseDAO();
                    if (dao.Delete(idCourse))
                    {
                        Model.NotificationCommon.DeleteSuccess("Khóa học");
                        LoadAllCourse();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Khóa học");
                    }
                }
            }
        }

        private void gvCourse_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Ngừng hoạt động"; break;
                    case "1": e.DisplayText = "Hoạt động"; break;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gCourse.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
