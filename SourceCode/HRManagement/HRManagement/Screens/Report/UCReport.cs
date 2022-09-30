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

        private void UCReport_Load(object sender, EventArgs e)
        {
            pnReport.Controls.Add(new Screens.Report.UCStaffVolatility());
        }
    }
}
