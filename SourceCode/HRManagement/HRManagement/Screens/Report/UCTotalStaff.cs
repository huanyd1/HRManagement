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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HRManagement.Screens.Report
{
    public partial class UCTotalStaff : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Model.EF.TotalStaffByDepartment_Result> lstData = new List<Model.EF.TotalStaffByDepartment_Result>();
        GridControl grid = new GridControl();
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
            lstData = results;

            //Nam
            ChartValues<double> valuesMale = new ChartValues<double>();
            for (int i = 0; i < results.Count; i++)
            {
                valuesMale.Add(double.Parse(results[i].Nam.ToString()));
            }

            cartesianChart2.Series.Add(new ColumnSeries
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

            cartesianChart2.Series.Add(new ColumnSeries
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

            cartesianChart2.Series.Add(new ColumnSeries
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

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Báo cáo tổng Nhân viên theo Phòng ban",
                Labels = lstLabel,
                Separator = new LiveCharts.Wpf.Separator { Step = 1 },
                FontSize = 12,
                ShowLabels = true,
                Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("IndianRed"),
            });

            cartesianChart2.LegendLocation = LegendLocation.Bottom;
        }

        private void UCTotalStaff_Load(object sender, EventArgs e)
        {
            LoadTotalStaff();
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
                    panel1.Controls.Add(grid);
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
