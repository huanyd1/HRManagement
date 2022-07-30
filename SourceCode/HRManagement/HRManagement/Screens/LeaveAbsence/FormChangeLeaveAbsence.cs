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

namespace HRManagement.Screens.LeaveAbsence
{
    public partial class FormChangeLeaveAbsence : DevExpress.XtraEditors.XtraForm
    {
        public FormChangeLeaveAbsence()
        {
            InitializeComponent();
            dtimeFrom.MinDate = DateTime.Now;
            dtimeTo.MinDate = DateTime.Now;
        }

        private void dtimeTo_ValueChanged(object sender, EventArgs e)
        {
            var a = (dtimeTo.Value - dtimeFrom.Value).TotalDays + 1;
            txtTotalDay.Text = a.ToString();
        }
    }
}