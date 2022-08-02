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

namespace HRManagement
{
    public partial class FormStaffInfo : DevExpress.XtraEditors.XtraForm
    {
        public FormStaffInfo()
        {
            InitializeComponent();
        }

        private void FormStaffInfo_Load(object sender, EventArgs e)
        {
            lbStaffName.Text = InfoStaffCommon.StaffName;
            lbPosition.Text = InfoStaffCommon.Position;

            string enviroment = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            pboxAvatar.Image = Image.FromFile(enviroment + "\\Resource\\Upload\\" + InfoStaffCommon.Avatar);
        }

        private void AddToScreen(Control control)
        {
            panelSelect.Controls.Clear();
            panelSelect.Controls.Add(control);
            panelSelect.Dock = DockStyle.Fill;
        }

        private void btnLeaveAbsence_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.LeaveAbsence.UCLeaveAbsence());
        }

        private void panelSelect_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnTimeSheets_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Timekeeping.UCStaffTimekeeping());
        }

        private void btnStaffCourse_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Course.UCStaffCourse());
        }

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Explanation.UCExplanation());
        }

        private void FormStaffInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn thực sự muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}