using DevExpress.XtraBars;
using HRManagement.ChangePass;
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
        }

        private void ResetInfoStaff()
        {
            InfoStaffCommon.IDStaff = "";
            InfoStaffCommon.StaffName = "";
            InfoStaffCommon.Role = "";
            InfoStaffCommon.IsAdmin = false;
        }

        private void AddToScreen(Control control)
        {
            panelSelect.Controls.Clear();
            panelSelect.Controls.Add(control);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnOption.Caption = "Xin chào, " + InfoStaffCommon.StaffName;

            if (!InfoStaffCommon.IsAdmin)
            {
                btnDepartment.Visible = false;
            }
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

        private void btnSalary_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Salary.UCSalary());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Course.UCCourse());
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Timekeeping.UCTimekeeping());
        }

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Explanation.UCExplanation());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Staff.UCStaff());
        }

        private void btnStaffCourse_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.StaffCourse.UCStaffCourse());
        }

        private void btnStaffInsurance_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.StaffInsurance.UCStaffInsurance());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Account.UCAccount());
        }

        private void btnTimeSheets_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Salary.UCTimeSheets());
        }
        private void btnLeaveAbsence_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.LeaveAbsence.UCLeaveAbsence());
        }

        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Account.UCAccountManager());
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormChangePass changePass = new FormChangePass();
            changePass.Show();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            ResetInfoStaff();

            FormLogin login = new FormLogin();
            
            login.Show();
            this.Hide();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn thực sự muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //Application.Exit();
                
            }
        }
    }
}
