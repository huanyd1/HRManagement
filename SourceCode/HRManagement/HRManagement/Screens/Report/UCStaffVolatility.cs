using DevExpress.XtraEditors;
using LiveCharts;
using LiveCharts.Wpf;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace HRManagement.Screens.Report
{
    public partial class UCStaffVolatility : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffVolatility()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadStaffVolatility()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            ReportDAO dao = new ReportDAO();

            int currentYear = DateTime.Now.Year;
            var results = dao.GetStaffVolatility(currentYear);

            foreach (var item in results)
            {
                pieChart1.Series.Add(new PieSeries
                {
                    Title = item.JOININGMONTH.ToString(),
                    Values = new ChartValues<double>() { double.Parse(item.TOTAL.ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                });
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void UCStaffVolatility_Load(object sender, EventArgs e)
        {
            LoadStaffVolatility();
        }
    }
}
