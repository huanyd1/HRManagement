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

            Decentralization();
        }

        private void Decentralization()
        {
            if (InfoStaffCommon.AdminView)
            {
                //1
                //a5@BHC
                btnAccount.Visible = true;
                btnReport.Visible = true;

                btnDepartment.Visible = false; 
                btnAccountManager.Visible = false;
                btnContract.Visible = false;
                btnCourse.Visible = false;
                btnExplanation.Visible = false;
                btnInsurance.Visible = false;
                btnLeaveAbsence.Visible = false;
                btnSalary.Visible = false;
                btnStaffCourse.Visible = false;
                btnTimekeeping.Visible = false;
                btnStaff.Visible = false;
            }
            else if (InfoStaffCommon.AdminCreate)
            {

                btnAccount.Visible = true;
                btnReport.Visible = true;
                btnAccountManager.Visible = true;
                btnSalary.Visible = true;
                btnTimekeeping.Visible = true;

                btnDepartment.Visible = true;
                btnInsurance.Visible = true;
                btnContract.Visible = false;
                btnCourse.Visible = false;
                btnExplanation.Visible = false;
                btnLeaveAbsence.Visible = false;
                btnStaffCourse.Visible = false;
                btnStaff.Visible = false;
            }
            else if (InfoStaffCommon.AdminApprove)
            {
                btnSalary.Visible = true;
                btnTimeSheets.Visible = true;
                btnTimekeeping.Visible = true;
                btnExplanation.Visible = true;
                btnLeaveAbsence.Visible = true;

                btnAccount.Visible = false;
                btnReport.Visible = false;
                btnAccountManager.Visible = false;
                btnDepartment.Visible = false;
                btnInsurance.Visible = false;
                btnContract.Visible = false;
                btnCourse.Visible = false;
                btnStaffCourse.Visible = false;
                btnStaff.Visible = false;
            }
            else
            {

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

        private void btnReport_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Report.UCReport());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.BackUp.UCBackUp());
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
