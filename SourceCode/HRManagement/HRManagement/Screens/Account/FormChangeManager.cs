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

namespace HRManagement.Screens.Account
{
    public partial class FormChangeManager : DevExpress.XtraEditors.XtraForm
    {
        private string idAdmin = "";
        private string email = "Email";
        private string staffName = "Tên nhân viên";
        private string username = "Tên đăng nhập";

        private bool _isAdd;
        private bool _isSave = false;
        private bool _isInfo = false;
        private string _idStaff;

        public FormChangeManager()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        public bool IsAdd
        {
            get { return _isAdd; }
            set { _isAdd = value; }
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

        class Role
        {
            public int idRole { get; set; }
            public string nameRole { get; set; }

            public Role(int idRole, string nameRole )
            {
                this.idRole = idRole;
                this.nameRole = nameRole;
            }
        }

        private void LoadRole()
        {
            const int Admin_Create = 1;
            const int Admin_View = 2;
            const int Admin_Approve = 3;

            Role[] role = new Role[] {
                new Role(Admin_Create, "Admin Tạo"),
                new Role(Admin_View, "Admin Xem"),
                new Role(Admin_Approve, "Admin Duyệt"),
            };

            cbRole.DataSource = role;
            cbRole.DisplayMember = "nameRole";
            cbRole.ValueMember = "idRole";
        }

        private void FormChangeManager_Load(object sender, EventArgs e)
        {
            LoadRole();
            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Tài khoản");
                cbRole.Enabled = false;
                btnSave.Text = "Cập nhật";

                AccountDAO dao = new AccountDAO();
                StaffDAO staffDAO = new StaffDAO();
                Model.EF.Account account = dao.GetSingleByID(_idStaff);
                Model.EF.Staff staff = staffDAO.GetSingleByID(_idStaff);

                txtStaffName.Text = staffDAO.GetStaffNameByID(_idStaff);
                txtEmail.Text = staff.Email;
                txtUsername.Text = account.Username;

                cbRole.SelectedValue = int.Parse(account.Type);
                cbRole.Enabled = false;

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    txtStaffName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtUsername.ReadOnly = true;

                    btnSave.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Tài khoản");
                }
            }
            //else { }
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

            if (txtStaffName.Text == string.Empty)
            {
                errorStaffName.SetError(txtStaffName, Model.CheckVariableCommon.NullVariable(staffName));
                flag = false;
            }
            else
            {
                errorStaffName.SetError(txtStaffName, null);
            }

            if (txtUsername.Text == string.Empty)
            {
                errorUsername.SetError(txtUsername, Model.CheckVariableCommon.NullVariable(username));
                flag = false;
            }
            else
            {
                errorUsername.SetError(txtUsername, null);
            }

            return flag;
        }

        private Model.EF.Staff GetInfoNewAdmin()
        {
            Model.EF.Staff staff = new Model.EF.Staff();
            staff.IDStaff = Guid.NewGuid().ToString();
            idAdmin = staff.IDStaff;
            staff.StaffName = txtStaffName.Text.ToString();
            staff.Email = txtEmail.Text.ToString();
            staff.Status = "1";

            return staff;
        }

        private Model.EF.Staff GetInfoAdmin()
        {
            Model.EF.Staff staff = new Model.EF.Staff();
            staff.IDStaff = _idStaff;
            idAdmin = _idStaff;
            staff.StaffName = txtStaffName.Text.ToString();
            staff.Email = txtEmail.Text.ToString();

            return staff;
        }

        private Model.EF.Account GetInfoAccount(string idStaff)
        {
            Model.EF.Account account = new Model.EF.Account();
            account.IDStaff = _idStaff;
            account.Username = txtUsername.Text.ToString();

            return account;
        }

        private Model.EF.Account GetInfoNewAccount(string idStaff)
        {
            Model.EF.Account account = new Model.EF.Account();
            account.IDStaff = idStaff;
            account.Username = txtUsername.Text.ToString();
            account.Password = ResetPassword.RandomString(6);
            account.Type = cbRole.SelectedValue.ToString();

            return account;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            StaffDAO dao = new StaffDAO();
            AccountDAO account = new AccountDAO();

            if (_isAdd)
            {
                Model.EF.Staff staff = GetInfoNewAdmin();

                var success = dao.AddAdmin(staff);

                if (success)
                {
                    Model.EF.Account admin = GetInfoNewAccount(idAdmin);

                    var result = account.Add(admin);

                    if (result)
                    {
                        NotificationCommon.Success("Thêm tài khoản thành công");
                        this.Close();
                    }
                    else
                    {
                        NotificationCommon.Error("Thêm tài khoản thất bại");
                    }
                }
                else
                {
                    NotificationCommon.Error("Thêm tài khoản thất bại");
                }
            }
            else
            {
                Model.EF.Staff staff = GetInfoAdmin();

                var success = dao.EditAdmin(staff);

                if (success)
                {
                    Model.EF.Account admin = GetInfoAccount(idAdmin);

                    var result = account.Edit(admin);

                    if (result)
                    {
                        NotificationCommon.Success("Chỉnh sửa tài khoản thành công");
                        this.Close();
                    }
                    else
                    {
                        NotificationCommon.Error("Chỉnh sửa tài khoản thất bại");
                    }
                }
                else
                {
                    NotificationCommon.Error("Chỉnh sửa tài khoản thất bại");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}