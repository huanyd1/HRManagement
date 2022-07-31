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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }


        }
    }
}
