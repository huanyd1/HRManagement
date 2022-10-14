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
    public partial class UCForgotPassword : DevExpress.XtraEditors.XtraUserControl
    {
        public UCForgotPassword()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Panel panel = ((sender as Label).Parent as UserControl).Parent as Panel;
            panel.Controls.Clear();
            panel.Controls.Add(new UCLogin());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToString();
            string cccd = txtCCCD.Text.ToString();

            AccountDAO dao = new AccountDAO();
            var account = dao.GetAccountByInfo(email, cccd);

            if(account != null)
            {
                AccountDAO accountDAO = new AccountDAO();
                Model.EF.Account Account = new Model.EF.Account();
                account.IDStaff = account.IDStaff;
                account.Username = account.Username;
                account.Password = Model.ResetPassword.RandomString(6);
                if (dao.Edit(account))
                {
                    MessageBox.Show("Gửi thông tin mật khẩu thành công");
                }

                string content = string.Format("Tài khoản:<strong>{0}</strong> <br/> Mật khẩu mới:<strong>{1}</strong>",
                account.Username, account.Password);
                SendEmailForgotPass(account.Username, "Thông tin tài khoản " + account.Username, content);
            }
        }

        private void SendEmailForgotPass(string email, string subject, string content)
        {
            var file = string.Format("{0}\\{1}", Environment.CurrentDirectory, "../../Template/" + "ResetPassword.html");
            string contentEmail = System.IO.File.ReadAllText(file);

            while (contentEmail.Contains("{}"))
            {
                contentEmail = contentEmail.Replace("{}", content);
            }

            string emailBody = contentEmail;

            EmailHelper.SendEmail(Model.AppSettings.EmailHost, Model.AppSettings.EmailPort, Model.AppSettings.FromEmail, Model.AppSettings.PasswordEmail,
                email, subject, emailBody);
        }
    }
}
