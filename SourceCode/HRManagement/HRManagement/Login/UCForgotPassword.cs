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

namespace HRManagement.Login
{
    public partial class UCForgotPassword : DevExpress.XtraEditors.XtraUserControl
    {
        public UCForgotPassword()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Form form = ((sender as Label).Parent as UserControl).Parent as Form;
            form.Controls.Clear();
            form.Controls.Add(new UCLogin());
        }
    }
}
