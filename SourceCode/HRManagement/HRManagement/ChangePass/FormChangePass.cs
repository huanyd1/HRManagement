using DevExpress.XtraEditors;
using Model;
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

namespace HRManagement.ChangePass
{
    public partial class FormChangePass : DevExpress.XtraEditors.XtraForm
    {
        private readonly string oldPass = "Mật khẩu cũ";
        private readonly string newPass = "Mật khẩu mới";
        public FormChangePass()
        {
            InitializeComponent();
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtOldPass.Text == string.Empty)
            {
                errorOldPass.SetError(txtOldPass, Model.CheckVariableCommon.NullVariable(oldPass));
                flag = false;
            }
            else
            {
                errorOldPass.SetError(txtOldPass, null);
            }

            if (txtNewPass.Text == string.Empty)
            {
                errorNewPass.SetError(txtNewPass, Model.CheckVariableCommon.NullVariable(newPass));
                flag = false;
            }
            else
            {
                errorNewPass.SetError(txtNewPass, null);
            }

            return flag;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            if(txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Nhập lại Mật khẩu mới phải trùng mới Mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idStaff = InfoStaffCommon.IDStaff;
            string oldPass = txtOldPass.Text.ToString();
            string newPass = txtNewPass.Text.ToString();

            AccountDAO dao = new AccountDAO();
            var success = dao.ChangePassword(idStaff, oldPass, newPass);

            if (success)
            {
                NotificationCommon.Success("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                NotificationCommon.Error("Đổi mật khẩu thất bại");
            }
        }
    }
}