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
    public partial class UCStaffTimekeeping : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffTimekeeping()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
                    if (query.Checkin.ToString() != "12:00:00" && query.Type != "1")
                    {
                        dr[1] = query.Checkin.ToString() + " - " + query.Checkout.ToString();
                        dr[2] = "Công làm việc: 1.0";
                    }
                    if (query.Type == "1")
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

        private void LoadTableTotalTime()
        {
            TimekeepingDAO dao = new TimekeepingDAO();
            DataTable dt = new DataTable();
            dt.Columns.Add("Month");
            dt.Columns.Add("TotalTime");

            int time = dao.totalTime(InfoStaffCommon.IDDepartment, DateTime.Now.Month, InfoStaffCommon.IDStaff);

            DataRow dr = dt.NewRow();
            dr[0] = "Công thực tế";
            dr[1] = time.ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Công tính lương";
            dr[1] = time.ToString();
            dt.Rows.Add(dr);

            gTotalTime.DataSource = dt;
        }

        private void UCStaffTimekeeping_Load(object sender, EventArgs e)
        {
            LoadTableTimekeeping(InfoStaffCommon.IDStaff, DateTime.Now.Month);
            LoadTableTotalTime();
        }
    }
}
