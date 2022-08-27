using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Account
{
    public partial class UCAccount : DevExpress.XtraEditors.XtraUserControl
    {
        public UCAccount()
        {
            InitializeComponent();
        }

        private void LoadAllInfoAccount()
        {
            AccountDAO dao = new AccountDAO();
            gAccount.DataSource = dao.GetAllInfoAccounts();
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            LoadAllInfoAccount();
        }

        //private void SendEmail(string subject, string password, string templateFile)
        //{
        //    var file = Path.Combine(Directory.GetCurrentDirectory(), "Template", templateFile);
        //    string contentEmail = System.IO.File.ReadAllText(file);

        //    contentEmail = contentEmail.Replace("{username}", model.UserModel.UserName);
        //    contentEmail = contentEmail.Replace("{password}", model.UserModel.Password);
        //    contentEmail = contentEmail.Replace("{role}", StringHelper.GetDictionaryValue(VbanApiConstant.Buyer.dctBuyerType, model.Role ?? 0));
        //    contentEmail = contentEmail.Replace("{link}", "");


        //    string emailBody = contentEmail;

        //    EmailHelper.SendEmail(_appSettings.EmailHost, _appSettings.EmailPort, _appSettings.FromEmail, _appSettings.PasswordEmail,
        //        model.UserModel.Email, subject, emailBody);
        //}

        private void SendEmailForgotPass(string email, string subject, string content)
        {
            var file = string.Format("{0}\\{1}",Environment.CurrentDirectory, "../../Template/" + "ResetPassword.html");
            string contentEmail = System.IO.File.ReadAllText(file);

            while (contentEmail.Contains("{}"))
            {
                contentEmail = contentEmail.Replace("{}", content);
            }

            string emailBody = contentEmail;

            EmailHelper.SendEmail(Model.AppSettings.EmailHost, Model.AppSettings.EmailPort, Model.AppSettings.FromEmail, Model.AppSettings.PasswordEmail,
                email, subject, emailBody);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(gvAccount.RowCount > 0)
            {
                string idStaff = gvAccount.GetFocusedRowCellValue("IDStaff").ToString();
                string username = gvAccount.GetFocusedRowCellValue("Username").ToString();

                AccountDAO dao = new AccountDAO();
                Model.EF.Account account = new Model.EF.Account();
                account.IDStaff = idStaff;
                account.Username = username;
                account.Password = Model.ResetPassword.RandomString(6);
                if (dao.Edit(account))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }

                string content = string.Format("Tài khoản:<strong>{0}</strong> <br/> Mật khẩu mới:<strong>{1}</strong>",
                username, account.Password);
                SendEmailForgotPass(username, "Thông tin tài khoản " + username, content);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(gvAccount.RowCount > 0)
            {
                string idStaff = gvAccount.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeAccount editAccount = new FormChangeAccount();
                editAccount.IdStaff = idStaff;
                editAccount.Show();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gAccount.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
