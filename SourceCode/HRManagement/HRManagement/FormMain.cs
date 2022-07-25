using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRManagement
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();

            panelSelect.Controls.Add(new Login.UCLogin());
        }

        private void AddToScreen(Control control)
        {
            panelSelect.Controls.Clear();
            panelSelect.Controls.Add(control);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Department.UCDepartment());
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Insurance.UCInsurance());
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Contract.UCContract());
        }
    }
}
