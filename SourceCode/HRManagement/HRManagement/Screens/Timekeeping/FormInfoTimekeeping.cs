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
        public FormInfoTimekeeping()
        {
            InitializeComponent();

            gSalary.DataSource = null;
        }

        private void gvSalary_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void FormInfoTimekeeping_Load(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                DataRow dr = dt.NewRow();
                DateTime newDate = new DateTime(year, month, day);
                dr[0] = newDate.ToShortDateString();

                var query = dao.IsExistTimekeeping("VP01924", newDate);

                dt.Rows.Add(dr);
            }
            gSalary.DataSource = dt;
        }
    }
}