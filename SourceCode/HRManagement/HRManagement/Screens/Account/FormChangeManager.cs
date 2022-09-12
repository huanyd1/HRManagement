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
            const int Buyer_Create = 1;
            const int Buyer_View = 2;
            const int Buyer_Approve = 3;

            Role[] role = new Role[] {
                new Role(Buyer_Create, "Admin Tạo"),
                new Role(Buyer_View, "Admin Xem"),
                new Role(Buyer_Approve, "Admin Duyệt"),
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
                txtStaffName.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                //ContractDAO dao = new ContractDAO();
                //StaffDAO staff = new StaffDAO();
                //Model.EF.Contract contract = dao.GetSingleByID(_idStaff);

                //txtIDStaff.Text = contract.IDStaff;
                //txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
                //txtNumberContract.Text = contract.NumberContract.ToString();
                //txtContractName.Text = contract.ContractName.ToString();
                //cbContractType.SelectedValue = contract.IDType.ToString();

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    //txtContractName.ReadOnly = true;
                    //txtNumberContract.ReadOnly = true;
                    //cbContractType.Enabled = false;

                    //btnSave.Visible = false;
                    //this.Text = Model.ActionCommon.InfoAction("Hợp đồng");
                }
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
    }
}