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
        private List<Model.EF.StaffVolatility_Result> lstData = new List<Model.EF.StaffVolatility_Result>();
        GridControl grid = new GridControl();
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
