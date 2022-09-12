using DevExpress.XtraEditors;
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

namespace HRManagement.Screens.Timekeeping
{
    public partial class FormInfoTimekeeping : DevExpress.XtraEditors.XtraForm
    {
        private string _idStaff;
        private int _month;
        private int _time;

        public FormInfoTimekeeping()
        {
            InitializeComponent();
        }

        public string IdStaff
        {
            set { _idStaff = value; }
        }

        public int Month
        {
            set { _month = value; }
        }

        public int TotalTime
        {
            set { _time = value; }
        }

        private void LoadInfoStaff()
        {
            DepartmentDAO department = new DepartmentDAO();
            StaffDAO staff = new StaffDAO();

            Model.EF.Staff info = staff.GetSingleByID(_idStaff);

            lbStaffName.Text = info.StaffName;
            lbDepartmentName.Text = department.GetDepartmentNameByIDStaff(_idStaff);
            lbMonth.Text = "Tháng " + _month;
            lbTotalTime.Text = _time.ToString();
        }


        private void LoadTableTimekeeping(string idStaff, int month)
        {
            TimekeepingDAO dao = new TimekeepingDAO();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date"); 
            dt.Columns.Add("CheckTime");
            dt.Columns.Add("Time");
            dt.Columns.Add("Description");

            int year = DateTime.Now.Year;
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                DataRow dr = dt.NewRow();
                DateTime newDate = new DateTime(year, month, day);

                string dayString = "";

                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        dayString = "Thứ hai";
                        break;
                    case "Tuesday":
                        dayString = "Thứ ba";
                        break;
                    case "Wednesday":
                        dayString = "Thứ tư";
                        break;
                    case "Thursday":
                        dayString = "Thứ năm";
                        break;
                    case "Friday":
                        dayString = "Thứ sáu";
                        break;
                    case "Saturday":
                        dayString = "Thứ bảy";
                        break;
                    case "Sunday":
                        dayString = "Chủ nhật";
                        break;
                    default:
                        dayString = "";
                        break;
                }

                string dayInTable = dayString + ", " + newDate.ToString("dd/MM/yyyy");
                dr[0] = dayInTable;

                var query = dao.IsExistTimekeeping(idStaff, newDate);
                if (query != null)
                {
                    if(query.Checkin.ToString() != "12:00:00" && query.Type != "1")
                    {
                        dr[1] = query.Checkin.ToString() + " - " + query.Checkout.ToString();
                        dr[2] = "Công làm việc: 1.0";
                    }

                    if(query.Type == "1")
                    {
                        dr[1] = "";
                        dr[2] = "Đã giải trình";
                    }
                }
                dr[3] = (query == null ? "" : query.Description);

                dt.Rows.Add(dr);
            }
            gTimeInfo.DataSource = dt;
        }

        private void FormInfoTimekeeping_Load(object sender, EventArgs e)
        {
            this.Text = Model.ActionCommon.InfoAction("Chấm công");

            LoadInfoStaff();
            LoadTableTimekeeping(_idStaff, _month);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}