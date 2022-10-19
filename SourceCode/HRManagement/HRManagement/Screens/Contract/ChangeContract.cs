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

namespace HRManagement.Screens.Contract
{
    public partial class ChangeContract : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idStaff;

        private readonly string numberContract = "Số hợp đồng";
        private readonly string contractName = "Tên hợp đồng";

        public ChangeContract()
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

        private void LoadContractType()
        {
            ContractTypeDAO dao = new ContractTypeDAO();

            cbContractType.DataSource = dao.GetAll();
            cbContractType.ValueMember = "IDType";
            cbContractType.DisplayMember = "TypeName";
        }

        private void ChangeContract_Load(object sender, EventArgs e)
        {
            dtimeStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            LoadContractType();

            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Hợp đồng");
                txtIDStaff.ReadOnly = true;
                txtStaffName.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                ContractDAO dao = new ContractDAO();
                StaffDAO staff = new StaffDAO();
                Model.EF.GetAllInfoContract_Result contract = dao.GetAllInfoContract(_idStaff);

                txtIDStaff.Text = contract.IDStaff;
                txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
                txtNumberContract.Text = contract.NumberContract.ToString();
                txtContractName.Text = contract.ContractName.ToString();
                cbContractType.SelectedValue = contract.IDType.ToString();

                dtimeStartDate.Text = contract.StartDate.ToString();
                dtimeEndDate.Text = contract.EndDate.ToString();

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    txtContractName.ReadOnly = true;
                    txtNumberContract.ReadOnly = true;
                    cbContractType.Enabled = false;

                    btnSave.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Hợp đồng");
                }
            }
            else
            {
                this.Text = Model.ActionCommon.AddAction("Hợp đồng");
                btnSave.Text = "Thêm mới";
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtNumberContract.Text == string.Empty)
            {
                errorNumberContract.SetError(txtNumberContract, Model.CheckVariableCommon.NullVariable(numberContract));
                flag = false;
            }
            else
            {
                errorNumberContract.SetError(txtIDStaff, null);
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

            return flag;
        }

        public Model.EF.Contract GetInfoContract()
        {
            Model.EF.Contract contract = new Model.EF.Contract();
            contract.IDStaff = txtIDStaff.Text;
            contract.ContractName = txtContractName.Text;
            contract.NumberContract = txtNumberContract.Text;
            contract.IDType = cbContractType.SelectedValue.ToString();

            return contract;
        }

        public Model.EF.Staff GetInfoStaff()
        {
            Model.EF.Staff staff = new Model.EF.Staff();
            staff.StartDate = DateTime.Parse(dtimeStartDate.Text.ToString());
            staff.EndDate = DateTime.Parse(dtimeEndDate.Text.ToString());

            return staff;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            ContractDAO dao = new ContractDAO();

            Model.EF.Contract contract = GetInfoContract();
            Model.EF.Staff staff = GetInfoStaff();

            if (_isAdd)
            {
                if (dao.Add(contract))
                {
                    _isSave = true;
                }               
            }
            else
            {
                if (dao.Edit(contract, staff))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Hợp đồng");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Hợp đồng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtIDStaff.Text != string.Empty || txtNumberContract.Text != string.Empty) && _isInfo == false)
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

        private void btnAddType_Click(object sender, EventArgs e)
        {
            ChangeContractType type = new ChangeContractType();
            type.Show();
        }
    }
}