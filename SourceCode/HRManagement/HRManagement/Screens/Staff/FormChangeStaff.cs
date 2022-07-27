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

namespace HRManagement.Screens.Staff
{
    public partial class FormChangeStaff : DevExpress.XtraEditors.XtraForm
    {
        public FormChangeStaff()
        {
            InitializeComponent();
        }

        private void FormChangeStaff_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            //this.AutoScrollPosition = new Point(0, 0);
            //this.Focus();
            //txtIDStaff.Focus();
            this.VerticalScroll.Value = 0;
        }
    }
}