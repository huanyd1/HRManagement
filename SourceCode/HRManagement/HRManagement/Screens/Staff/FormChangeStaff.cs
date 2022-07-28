using DevExpress.Utils;
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

namespace HRManagement.Screens.Staff
{
    public partial class FormChangeStaff : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idStaff;

        private readonly string idStaff = "Mã nhân viên";
        private readonly string staffName = "Tên nhân viên";
        private readonly string place = "Địa chỉ";
        private readonly string email = "Địa chỉ Email";
        private readonly string cccd = "Số CCCD";
        private readonly string phonenumber = "Số điện thoại";
        private readonly string numberContract = "Số hợp đồng";
        private readonly string contractName = "Tên hợp đồng";
        private readonly string salaryNumber = "Lương";
        private readonly string allowance = "Phụ cấp";
        private readonly string tax = "Thuế TN";

        public FormChangeStaff()
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

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void LoadAllPosition()
        {
            PositionDAO dao = new PositionDAO();
            cbPosition.DataSource = dao.GetAll();
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "IDPosition";
        }

        private void LoadAllContractType()
        {
            ContractTypeDAO dao = new ContractTypeDAO();
            cbContractType.DataSource = dao.GetAll();
            cbContractType.DisplayMember = "TypeName";
            cbContractType.ValueMember = "IDType";
        }

        private void LoadAllSex()
        {
            cbSex.Items.Add("Nam");
            cbSex.Items.Add("Nữ");
        }

        private void LoadAllInfoStaff()
        {
            StaffDAO dao = new StaffDAO();
            Model.EF.GetAllInfoByIDStaff_Result staff = dao.GetAllInfoByIDStaff(_idStaff);

            //Thông tin Cơ bản
            txtIDStaff.Text = staff.IDStaff;
            txtStaffName.Text = staff.StaffName;
            cbDepartment.Text = staff.DepartmentName;
            cbPosition.SelectedValue = staff.IDPosition;
            dtimeBirthday.Text = staff.Birthday.ToString();
            txtPlace.Text = staff.Place;

            //Thông tin Chi tiết
            txtEmail.Text = staff.Email;
            txtCCCD.Text = staff.CCCD;
            cbSex.SelectedText = staff.Sex == "1" ? "Nam" : "Nữ";
            txtPhonenumber.Text = staff.Numberphone;

            //Thông tin Hợp đồng
            txtNumberContract.Text = staff.NumberContract;
            txtContractName.Text = staff.ContractName;
            dtimeStartDate.Text = staff.StartDate.ToString();
            dtimeEndDate.Text = staff.EndDate.ToString();
            cbContractType.SelectedValue = staff.IDType;

            //Thông tin Lương
            txtSalaryAmount.Text = staff.SalaryAmount.ToString();
            txtAllowance.Text = staff.Allowance.ToString();
            txtTax.Text = staff.Tax.ToString();
        }

        private void FormChangeStaff_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            txtIDStaff.Focus();

            dtimeBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            LoadAllDepartment();
            LoadAllPosition();
            LoadAllSex();
            LoadAllContractType();

            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Nhân viên");
                txtIDStaff.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                LoadAllInfoStaff();

                txtNumberContract.ReadOnly = true;
                txtContractName.ReadOnly = true;
                dtimeStartDate.Enabled = false;
                dtimeEndDate.Enabled = false;
                cbContractType.Enabled = false;

                txtSalaryAmount.ReadOnly = true;
                txtAllowance.ReadOnly = true;
                txtTax.ReadOnly = true;

                if (_isInfo)
                {
                    txtIDStaff.ReadOnly = true;
                    txtStaffName.ReadOnly = true;
                    cbDepartment.Enabled = false;
                    cbPosition.Enabled = false;
                    dtimeBirthday.Enabled = false;
                    txtPlace.ReadOnly = true;

                    txtEmail.ReadOnly = true;
                    txtCCCD.ReadOnly = true;
                    cbSex.Enabled = false;
                    txtPhonenumber.ReadOnly = true;

                    btnSave.Visible = false;
                    btnChangeAvatar.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Nhân viên");
                }

            }
            else
            {
                this.Text = Model.ActionCommon.AddAction("Nhân viên");
                btnSave.Text = "Thêm mới";

                cbSex.SelectedText = "Nam";
                dtimeBirthday.Text = DateTime.Now.ToString();
                dtimeStartDate.Text = DateTime.Now.ToString();
                dtimeEndDate.Text = DateTime.Now.ToString();
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            #region CheckError

            if (txtIDStaff.Text == string.Empty)
            {
                errorIDStaff.SetError(txtIDStaff, Model.CheckVariableCommon.NullVariable(idStaff));
                flag = false;
            }
            else
            {
                errorIDStaff.SetError(txtIDStaff, null);
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

            if (txtPlace.Text == string.Empty)
            {
                errorPlace.SetError(txtPlace, Model.CheckVariableCommon.NullVariable(place));
                flag = false;
            }
            else
            {
                errorPlace.SetError(txtPlace, null);
            }

            if (txtEmail.Text == string.Empty)
            {
                errorEmail.SetError(txtEmail, Model.CheckVariableCommon.NullVariable(email));
                flag = false;
            }
            else
            {
                errorEmail.SetError(txtEmail, null);
            }

            if (txtCCCD.Text == string.Empty)
            {
                errorCCCD.SetError(txtCCCD, Model.CheckVariableCommon.NullVariable(cccd));
                flag = false;
            }
            else
            {
                errorCCCD.SetError(txtCCCD, null);
            }

            if (txtPhonenumber.Text == string.Empty)
            {
                errorPhonenumber.SetError(txtPhonenumber, Model.CheckVariableCommon.NullVariable(phonenumber));
                flag = false;
            }
            else
            {
                errorPhonenumber.SetError(txtPhonenumber, null);
            }

            if (txtNumberContract.Text == string.Empty)
            {
                errorNumberContract.SetError(txtNumberContract, Model.CheckVariableCommon.NullVariable(numberContract));
                flag = false;
            }
            else
            {
                errorNumberContract.SetError(txtNumberContract, null);
            }

            if (txtContractName.Text == string.Empty)
            {
                errorContractName.SetError(txtContractName, Model.CheckVariableCommon.NullVariable(contractName));
                flag = false;
            }
            else
            {
                errorContractName.SetError(txtContractName, null);
            }

            if (txtSalaryAmount.Text == string.Empty)
            {
                errorSalary.SetError(txtSalaryAmount, Model.CheckVariableCommon.NullVariable(salaryNumber));
                flag = false;
            }
            else
            {
                errorContractName.SetError(txtSalaryAmount, null);
            }

            if (txtAllowance.Text == string.Empty)
            {
                errorAllowance.SetError(txtAllowance, Model.CheckVariableCommon.NullVariable(allowance));
                flag = false;
            }
            else
            {
                errorAllowance.SetError(txtAllowance, null);
            }

            if (txtTax.Text == string.Empty)
            {
                errorTax.SetError(txtTax, Model.CheckVariableCommon.NullVariable(tax));
                flag = false;
            }
            else
            {
                errorTax.SetError(txtTax, null);
            }

            #endregion

            return flag;
        }

        public Model.EF.Staff GetInfoStaff()
        {
            Model.EF.Staff staff = new Model.EF.Staff();
            staff.IDStaff = txtIDStaff.Text;
            staff.StaffName = txtStaffName.Text;
            staff.IDDepartment = cbDepartment.SelectedValue.ToString();
            staff.IDPosition = cbPosition.SelectedValue.ToString();
            staff.Birthday = DateTime.Parse(dtimeBirthday.Text.ToString());
            staff.Place = txtPlace.Text;

            staff.Email = txtEmail.Text;
            staff.CCCD = txtCCCD.Text;
            staff.Sex = cbSex.Text == "Nam" ? "1" : "0";
            staff.Numberphone = txtPhonenumber.Text;

            staff.IDStaff = txtIDStaff.Text;
             
            staff.StartDate = DateTime.Parse(dtimeStartDate.Text.ToString());
            staff.EndDate = DateTime.Parse(dtimeEndDate.Text.ToString());

            staff.Status = "1";

            return staff;
        }

        public Model.EF.Contract GetInfoContract()
        {
            Model.EF.Contract contract = new Model.EF.Contract();
            contract.IDStaff = txtIDStaff.Text;
            contract.NumberContract = txtNumberContract.Text;
            contract.ContractName = txtContractName.Text;
            contract.IDType = cbContractType.SelectedValue.ToString();

            return contract;
        }

        public Model.EF.Salary GetInfoSalary()
        {
            Model.EF.Salary salary = new Model.EF.Salary();
            salary.IDStaff = txtIDStaff.Text;
            salary.SalaryAmount = int.Parse(txtSalaryAmount.Text);
            salary.Allowance = int.Parse(txtAllowance.Text);
            salary.Tax = int.Parse(txtTax.Text);

            return salary;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            StaffDAO dao = new StaffDAO();

            Model.EF.Staff staff = GetInfoStaff();
            Model.EF.Contract contract = GetInfoContract();
            Model.EF.Salary salary = GetInfoSalary();

            if (_isAdd)
            {
                if (dao.IsExitStaff(txtCCCD.Text))
                {
                    DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExitVariable(cccd), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (dao.Add(staff, contract, salary))
                        {
                            _isSave = true;
                        }
                    }
                }
                else
                {
                    if (dao.Add(staff, contract, salary))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(staff))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Nhân viên");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Nhân viên");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtIDStaff.Text != string.Empty || txtStaffName.Text != string.Empty) && _isInfo == false)
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.ExitForm(), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}