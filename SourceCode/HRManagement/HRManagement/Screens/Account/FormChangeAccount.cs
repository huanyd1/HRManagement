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

namespace HRManagement.Screens.Account
{
    public partial class FormChangeAccount : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isInfo = false;
        private string _idStaff;

        private readonly string email = "Email";

        public FormChangeAccount()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        public bool IsInfo
        {
            get { return _isInfo; }
            set { _isInfo = value; }
        }
        public string IdStaff
        {
            set { _idStaff = value; }
        }

        private void FormChangeAccount_Load(object sender, EventArgs e)
        {

            this.Text = Model.ActionCommon.EditAction("Tài khoản");
            txtIDStaff.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            btnSave.Text = "Cập nhật";

            AccountDAO dao = new AccountDAO();
            StaffDAO staff = new StaffDAO();
            Model.EF.Account account = dao.GetSingleByID(_idStaff);

            txtIDStaff.Text = account.IDStaff;
            txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
            txtEmail.Text = account.Username;

            //Nếu info thì disable tất cả
            if (_isInfo)
            {
                txtIDStaff.ReadOnly = true;
                txtStaffName.ReadOnly = true;
                txtEmail.ReadOnly = true;

                btnSave.Visible = false;
                this.Text = Model.ActionCommon.InfoAction("Hợp đồng");
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtEmail.Text == string.Empty)
            {
                errorEmail.SetError(txtEmail, Model.CheckVariableCommon.NullVariable(email));
                flag = false;
            }
            else
            {
                errorEmail.SetError(txtEmail, null);
            }

            return flag;
        }

        public Model.EF.Account GetInfoAccount()
        {
            AccountDAO dao = new AccountDAO();
            Model.EF.Account account = new Model.EF.Account();
            account.IDStaff = txtIDStaff.Text;
            account.Username = txtEmail.Text;
            account.Password = dao.GetPasswordByIDStaff(_idStaff);

            return account;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            AccountDAO dao = new AccountDAO();

            Model.EF.Account account = GetInfoAccount();

            if (dao.IsExitAccount(txtEmail.Text))
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExistVariable(email), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (dao.Edit(account))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(account))
                {
                    _isSave = true;
                }
            }


            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Sửa thông tin", "Tài khoản");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Sửa thông tin", "Tài khoản");
            }
        }
    }
}