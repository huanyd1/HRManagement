using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Report
{
    public partial class UCReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UCReport()
        {
            InitializeComponent();
        }

        private void LoadAllReport()
        {
            cbReport.Items.Clear();
            cbReport.Items.Add("Báo cáo thu nhập Nhân viên");
            cbReport.Items.Add("Báo cáo biến động Nhân sự");
            cbReport.Items.Add("Báo cáo tổng Nhân sự");

            cbReport.SelectedText = "Báo cáo tổng Nhân sự";
        }

        private void LoadReport(string reportName)
        {
            pnReport.Controls.Clear();

            if (reportName == "Báo cáo thu nhập Nhân viên")
            {
                pnReport.Controls.Add(new Screens.Report.UCEarningsReport());
            }
            else if(reportName == "Báo cáo biến động Nhân sự") 
            {
                pnReport.Controls.Add(new Screens.Report.UCStaffVolatility());
            }
            else if(reportName == "Báo cáo tổng Nhân sự")
            {
                pnReport.Controls.Add(new Screens.Report.UCTotalStaff());
            }
            else
            {
                MessageBox.Show(Model.MessageBoxCommon.IsNotExistReport(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UCReport_Load(object sender, EventArgs e)
        {
            LoadAllReport();
        }

        private void cbReport_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = cbReport.SelectedItem.ToString();

            if (!String.IsNullOrEmpty(name))
            {
                LoadReport(name);
            }
        }
    }
}
