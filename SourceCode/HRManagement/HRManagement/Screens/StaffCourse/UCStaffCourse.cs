using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using HRManagement.ImportData;
using HRManagement.Screens.BackUp;
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
            if(InfoStaffCommon.IsAdmin || InfoStaffCommon.AdminApprove)
            {
                btnImport.Visible = true;
            }
            else
            {
                btnImport.Visible = false;
            }

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = save.FileName;
                    gStaffCourse.ExportToXlsx(path);
                    Process.Start(path);
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportStaffCourse import = new ImportStaffCourse();
                if (import.ImportDataStaffCourse(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }
    }
}
