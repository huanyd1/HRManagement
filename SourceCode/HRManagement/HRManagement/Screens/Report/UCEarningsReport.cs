using DevExpress.XtraEditors;
using LiveCharts;
using LiveCharts.Wpf;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace HRManagement.Screens.Report
{
    public partial class UCEarningsReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UCEarningsReport()
        {
            InitializeComponent();
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void UCEarningsReport_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            PointLabel = chartPoint =>
              string.Format("{0} ({1:P})", chartPoint.X, chartPoint.Participation);

            ReportDAO dao = new ReportDAO();
            var result = dao.GetEarningsReport();

            var value = new ChartValues<double>();

            cartesianChart1.Series = new SeriesCollection();

            List<string> lstLabel = new List<string>();

            SeriesCollection series = new SeriesCollection();

            bool isFirt = true;

            foreach (var item in result)
            {
                ColumnSeries column = new ColumnSeries();

                value.Add(double.Parse(item.Total.ToString()));
                column.Title = item.SalaryAmount.ToString();
                column.Values = value;

                series = new SeriesCollection();
                series.Add(column);

                //if (isFirt)
                //{
                //cartesianChart1.Series = new SeriesCollection
                //{
                //    new ColumnSeries
                //    {
                //        Title = item.SalaryAmount.ToString(),
                //        Values = new ChartValues<double> { double.Parse(item.Total.ToString()) }
                //    }
                //};

                //isFirt = !isFirt;
                //}
                //else
                //{
                //cartesianChart1.Series.Add(new ColumnSeries
                //{
                //    Title = item.SalaryAmount.ToString(),
                //    Values = new ChartValues<double> { double.Parse(item.Total.ToString()) }
                //});
                //}

                lstLabel.Add(double.Parse(item.SalaryAmount.ToString()).ToString("#,###", cul.NumberFormat));
            }


            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Báo cáo thu nhập Nhân viên",
                Labels = lstLabel,
                Separator = new LiveCharts.Wpf.Separator { Step = 1 },
                FontSize = 12,
                ShowLabels = true,
                Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("IndianRed"),
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Separator = new LiveCharts.Wpf.Separator { Step = 1 },
                Title = "Số lượng",
            });

            cartesianChart1.DataTooltip = null;

            cartesianChart1.Series = series ;
        }
    }
}
