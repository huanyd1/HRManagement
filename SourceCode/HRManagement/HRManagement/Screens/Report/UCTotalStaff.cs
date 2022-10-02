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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace HRManagement.Screens.Report
{
    public partial class UCTotalStaff : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTotalStaff()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadTotalStaff()
        {
            List<string> lstLabel = new List<string>();

            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            ReportDAO dao = new ReportDAO();

            var results = dao.GetTotalStaffByDepartment();

            //Nam
            ChartValues<double> valuesMale = new ChartValues<double>();
            for (int i = 0; i < results.Count; i++)
            {
                valuesMale.Add(double.Parse(results[i].Nam.ToString()));
            }

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "Nam",
                Values = valuesMale,
                DataLabels = true,
                LabelPoint = labelPoint,
            });

            //Nữ
            ChartValues<double> valuesFemale = new ChartValues<double>();
            for (int i = 0; i < results.Count; i++)
            {
                valuesFemale.Add(double.Parse(results[i].Nữ.ToString()));
            }

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "Nữ",
                Values = valuesFemale,
                DataLabels = true,
                LabelPoint = labelPoint,
            });

            //Tổng nhân viên
            ChartValues<double> valuesTotal = new ChartValues<double>();
            for (int i = 0; i < results.Count; i++)
            {
                valuesTotal.Add(double.Parse(results[i].Tổng.ToString()));
            }

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "Tổng nhân viên",
                Values = valuesTotal,
                DataLabels = true,
                LabelPoint = labelPoint,
            });

            foreach(var item in results)
            {
                lstLabel.Add(item.DepartmentName.ToString());
            }

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Báo cáo tổng Nhân viên theo Phòng ban",
                Labels = lstLabel,
                Separator = new LiveCharts.Wpf.Separator { Step = 1 },
                FontSize = 12,
                ShowLabels = true,
                Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("IndianRed"),
            });

            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void UCTotalStaff_Load(object sender, EventArgs e)
        {
            LoadTotalStaff();
        }
    }
}
