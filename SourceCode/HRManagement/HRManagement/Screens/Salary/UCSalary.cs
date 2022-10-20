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

namespace HRManagement.Screens.Salary
{
    public partial class UCSalary : DevExpress.XtraEditors.XtraUserControl
    {
        public UCSalary()
        {
            InitializeComponent();
        }

        private void LoadAllSalary()
        {
            SalaryDAO dao = new SalaryDAO();
            gSalary.DataSource = dao.GetAllInfoSalaries();
        }

        private void UCSalary_Load(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();
           // var a = dao.IsExistTimekeeping("VP01924", DateTime.Now);

            LoadAllSalary();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (gvSalary.RowCount > 0)
            {
                string idStaff = gvSalary.GetFocusedRowCellValue("IDStaff").ToString();

                ChangeSalary editSalary = new ChangeSalary();
                editSalary.IsInfo = true;
                editSalary.IdStaff = idStaff;
                editSalary.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvSalary.RowCount > 0)
            {
                string idStaff = gvSalary.GetFocusedRowCellValue("IDStaff").ToString();

                ChangeSalary editSalary = new ChangeSalary();
                editSalary.IsInfo = false;
                editSalary.IdStaff = idStaff;
                editSalary.Show();
            }
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
                    gSalary.ExportToXlsx(path);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idStaff = txtIDStaff.Text.ToString();
            string staffName = txtStaffName.Text.ToString();

            SalaryDAO dao = new SalaryDAO();
            gSalary.DataSource = dao.GetSalaryByFilter(idStaff, staffName);
        }
    }
}
