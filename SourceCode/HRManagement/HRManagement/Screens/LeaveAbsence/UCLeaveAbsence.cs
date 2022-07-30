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
    public partial class UCLeaveAbsence : DevExpress.XtraEditors.XtraUserControl
    {
        public UCLeaveAbsence()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChangeLeaveAbsence addLeaveAbsence = new FormChangeLeaveAbsence();
            addLeaveAbsence.Show();
        }
    }
}
