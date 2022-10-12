using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using LiveCharts;
using LiveCharts.Wpf;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Model.EF.EarningsReport_Result> lstData = new List<Model.EF.EarningsReport_Result>();
        GridControl grid = new GridControl();
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
                    panel3.Controls.Add(grid);
                    grid.DataSource = lstData;

                    string path = save.FileName;
                    grid.ExportToXlsx(path);
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

        private void btnSavePng_Click(object sender, EventArgs e)
        {
            string ext = "png";
            string filter = "PNG File |*.png";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var chart = panel1;

                    using (var bmp = new Bitmap(chart.Width, chart.Height))
                    {
                        chart.DrawToBitmap(bmp, new Rectangle(0, 0, chart.Width, chart.Height));
                        bmp.Save(save.FileName);

                        Process.Start(save.FileName);
                        System.Windows.MessageBox.Show("Sao lưu dữ liệu thành công!");
                    }
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
