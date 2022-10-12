using DevExpress.XtraEditors;
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

namespace HRManagement.Screens.StaffInsurance
{
    public partial class UCStaffInsurance : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffInsurance()
        {
            InitializeComponent();
        }

        private void LoadAllStaffInsurance()
        {
            StaffInsuranceDAO dao = new StaffInsuranceDAO();
            gStaffInsurance.DataSource = dao.AllInfoStaffInsurance();
        }

        private void UCStaffInsurance_Load(object sender, EventArgs e)
        {
            LoadAllStaffInsurance();
            gvStaffInsurance.OptionsView.AllowCellMerge = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvStaffInsurance.RowCount > 0)
            {
                string idStaff = gvStaffInsurance.GetFocusedRowCellValue("IDStaff").ToString();

                FormInfoStaffInsurance infoStaffInsurance = new FormInfoStaffInsurance();
                infoStaffInsurance.IdStaff = idStaff;
                infoStaffInsurance.Show();
            } 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(gvStaffInsurance.RowCount > 0)
            {
                string idStaff = gvStaffInsurance.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeStaffInsurance addStaffInsurance = new FormChangeStaffInsurance();
                addStaffInsurance.IdStaff = idStaff;
                addStaffInsurance.Show();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvStaffInsurance.RowCount > 0)
            {
                string courseName = gvStaffInsurance.GetFocusedRowCellValue("InsuranceName").ToString();
                string staffName = gvStaffInsurance.GetFocusedRowCellValue("StaffName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteStaffCourse(courseName, staffName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int idStaffCourse = int.Parse(gvStaffInsurance.GetFocusedRowCellValue("IDStaffInsurance").ToString());

                    StaffInsuranceDAO dao = new StaffInsuranceDAO();
                    if (dao.Delete(idStaffCourse))
                    {
                        Model.NotificationCommon.DeleteSuccess("Bảo hiểm");
                        LoadAllStaffInsurance();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Bảo hiểm");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string staffName = txtStaffName.Text.ToString();
            string idInsurance = cbInsurance.SelectedValue.ToString();

            StaffInsuranceDAO dao = new StaffInsuranceDAO();
            gStaffInsurance.DataSource = dao.GetAllInsuranceByFilter(staffName, idInsurance);
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
                    gStaffInsurance.ExportToXlsx(path);
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
    }
}
