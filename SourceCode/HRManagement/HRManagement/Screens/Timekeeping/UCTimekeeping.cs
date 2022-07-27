using DevExpress.XtraEditors;
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

namespace HRManagement.Screens.Timekeeping
{
    public partial class UCTimekeeping : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTimekeeping()
        {
            InitializeComponent();
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void LoadAllMonth()
        {
            cbMonth.Items.Add("Tháng 1");
            cbMonth.Items.Add("Tháng 2");
            cbMonth.Items.Add("Tháng 3");
            cbMonth.Items.Add("Tháng 4");
            cbMonth.Items.Add("Tháng 5");
            cbMonth.Items.Add("Tháng 6");
            cbMonth.Items.Add("Tháng 7");
            cbMonth.Items.Add("Tháng 8");
            cbMonth.Items.Add("Tháng 9");
            cbMonth.Items.Add("Tháng 10");
            cbMonth.Items.Add("Tháng 11");
            cbMonth.Items.Add("Tháng 12");

            cbMonth.SelectedText = "Tháng " + DateTime.Now.Month.ToString();
        }

        private void LoadAllTimekeeping()
        {
            string idDepartment = cbDepartment.SelectedValue.ToString();
            int month = int.Parse(cbMonth.Text.Replace("Tháng ", ""));

            TimekeepingDAO dao = new TimekeepingDAO();
            gTimekeeping.DataSource = dao.GetAllInfoTimekeeping(idDepartment, month);
        }

        private void UCTimekeeping_Load(object sender, EventArgs e)
        {
            LoadAllDepartment();
            LoadAllMonth();
            LoadAllTimekeeping();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idDepartment = cbDepartment.SelectedValue.ToString();
            int month = int.Parse(cbMonth.Text.Replace("Tháng ", ""));
            string staffName = txtStaffName.Text;

            TimekeepingDAO dao = new TimekeepingDAO();
            gTimekeeping.DataSource = dao.GetInfoTimeByFilter(idDepartment, staffName, month);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvTimekeeping.RowCount > 0)
            {
                string idStaff = gvTimekeeping.GetFocusedRowCellValue("IDStaff").ToString();
                int month = int.Parse(cbMonth.Text.Replace("Tháng ", ""));
                int time = int.Parse(gvTimekeeping.GetFocusedRowCellValue("TotalTime").ToString());

                FormInfoTimekeeping infoTime = new FormInfoTimekeeping();
                infoTime.IdStaff = idStaff;
                infoTime.Month = month;
                infoTime.TotalTime = time;
                infoTime.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gvTimekeeping.RowCount > 0)
            {
                string idStaff = gvTimekeeping.GetFocusedRowCellValue("IDStaff").ToString();
                string idDepartment = gvTimekeeping.GetFocusedRowCellValue("IDDepartment").ToString();

                FormChangeTimekeeping addTime = new FormChangeTimekeeping();
                addTime.IsAdd = true;
                addTime.IdDepartment = idDepartment;
                addTime.IdStaff = idStaff;
                addTime.Show();
            }
            else
            {
                FormChangeTimekeeping addTime = new FormChangeTimekeeping();
                addTime.IsAddNotID = true;
                addTime.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTimekeeping.RowCount > 0)
            {
                string idStaff = gvTimekeeping.GetFocusedRowCellValue("IDStaff").ToString();
                FormChangeTimekeeping deleteTime = new FormChangeTimekeeping();
                deleteTime.IsAdd = false;
                deleteTime.IdStaff = idStaff;
                deleteTime.Show();
            }
        }
    }
}
