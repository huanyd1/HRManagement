using DevExpress.XtraEditors;
using Model.DAO;
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
    public partial class UCLogin : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly string username = "Tài khoản";
        private readonly string password = "Mật khẩu";

        public UCLogin()
        {
            InitializeComponent();
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtUsername.Text == string.Empty)
            {
                errorUsername.SetError(txtUsername, Model.CheckVariableCommon.NullVariable(username));
                flag = false;
            }
            else
            {
                errorUsername.SetError(txtUsername, null);
            }


            if (txtPassword.Text == string.Empty)
            {
                errorPassword.SetError(txtPassword, Model.CheckVariableCommon.NullVariable(password));
                flag = false;
            }
            else
            {
                errorPassword.SetError(txtPassword, null);
            }

            return flag;
        }

        private void GetAllInfoStaff(string idStaff, string type)
        {
            StaffDAO dao = new StaffDAO();
            var info = dao.GetAllInfoByIDStaff(idStaff);

            InfoStaffCommon.IDStaff = idStaff;
            InfoStaffCommon.StaffName = info.StaffName;
            InfoStaffCommon.Role = type;
            InfoStaffCommon.IsAdmin = type == "0" ? true : false;
            InfoStaffCommon.Position = info.PositionName;
            InfoStaffCommon.Avatar = info.Image;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();

            AccountDAO dao = new AccountDAO();
            var type = dao.GetInfoTypeLogin(username, password);
            string idStaff = dao.GetIDStaffByLogin(username, password);

            if(type == null)
            {
                MessageBox.Show(Model.MessageBoxCommon.AccountError(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
            else if(type == "0")
            {
                var form = ((this.Parent) as Panel).Parent as Form;

                FormMain main = new FormMain();
                main.FormClosed += (sen, evt) =>
                {
                    form.Close();
                };
                main.Show();
                form.Hide();
            }
            else
            {
                var form = ((this.Parent) as Panel).Parent as Form;

                GetAllInfoStaff(idStaff, type);
                FormStaffInfo staff = new FormStaffInfo();
                staff.FormClosed += (sen, evt) =>
                {
                    form.Close();
                };
                staff.Show();
                form.Hide();
            }
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            Form form = ((sender as Label).Parent as UserControl).Parent as Form;
            form.Controls.Clear();
            form.Controls.Add(new UCForgotPassword());
        }
    }
}
