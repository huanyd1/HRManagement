using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Insurance
{
    public partial class ChangeInsurance : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idInsurance;

        private readonly string idInsurance = "Mã bảo hiểm";
        private readonly string insuranceName = "Tên bảo hiểm";
        private readonly string amount = "Số tiền";

        public ChangeInsurance()
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
        public string IdInsurance
        {
            set { _idInsurance = value; }
        }

        private void LoadInsuranceType()
        {
            InsuranceTypeDAO dao = new InsuranceTypeDAO();
            cbInsuranceType.DataSource = dao.GetAll();
            cbInsuranceType.DisplayMember = "TypeName";
            cbInsuranceType.ValueMember = "IDInsuranceType";
        }

        private void ChangeInsurance_Load(object sender, EventArgs e)
        {
            LoadInsuranceType();

            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Bảo hiểm");
                txtIDInsurance.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                InsuranceDAO dao = new InsuranceDAO();
                Model.EF.Insurance insurance = dao.GetSingleByID(_idInsurance);

                txtIDInsurance.Text = insurance.IDInsurance.ToString();
                txtInsuranceName.Text = insurance.InsuranceName.ToString();
                cbInsuranceType.SelectedValue = insurance.IDInsuranceType.ToString();
                txtAmount.Text = insurance.Amount.ToString();

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    btnAddType.Enabled = false;

                    txtIDInsurance.ReadOnly = true;
                    txtInsuranceName.ReadOnly = true;
                    cbInsuranceType.Enabled = false;
                    txtAmount.ReadOnly = true;

                    btnSave.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Bảo hiểm");
                }
            }
            else
            {
                this.Text = Model.ActionCommon.AddAction("Bảo hiểm");
                btnSave.Text = "Thêm mới";
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtIDInsurance.Text == string.Empty)
            {
                errorIDDepartment.SetError(txtIDInsurance, Model.CheckVariableCommon.NullVariable(idInsurance));
                flag = false;
            }
            else
            {
                errorIDDepartment.SetError(txtIDInsurance, null);
            }

            if (txtInsuranceName.Text == string.Empty)
            {
                errorDepartmentName.SetError(txtInsuranceName, Model.CheckVariableCommon.NullVariable(insuranceName));
                flag = false;
            }
            else
            {
                errorDepartmentName.SetError(txtInsuranceName, null);
            }

            if (txtAmount.Text == string.Empty)
            {
                errorAmount.SetError(txtAmount, Model.CheckVariableCommon.NullVariable(amount));
                flag = false;
            }
            else
            {
                errorAmount.SetError(txtAmount, null);
            }

            return flag;
        }

        public Model.EF.Insurance GetInfoInsurance()
        {
            Model.EF.Insurance insurance = new Model.EF.Insurance();
            insurance.IDInsurance = txtIDInsurance.Text;
            insurance.InsuranceName = txtInsuranceName.Text;
            insurance.IDInsuranceType = cbInsuranceType.SelectedValue.ToString();
            insurance.Amount = int.Parse(txtAmount.Text.Replace(",", ""));

            return insurance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            InsuranceDAO dao = new InsuranceDAO();

            Model.EF.Insurance insurance = GetInfoInsurance();

            if (_isAdd)
            {
                if (dao.IsExitInsurance(txtInsuranceName.Text))
                {
                    DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExistVariable(insuranceName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (dao.Add(insurance))
                        {
                            _isSave = true;
                        }
                    }
                }
                else
                {
                    if (dao.Add(insurance))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(insurance))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Bảo hiểm");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Bảo hiểm");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtIDInsurance.Text != string.Empty || txtInsuranceName.Text != string.Empty || txtAmount.Text != string.Empty) && _isInfo == false)
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtAmount.Text, System.Globalization.NumberStyles.AllowThousands);
            txtAmount.Text = String.Format(culture, "{0:N0}", value);
            txtAmount.Select(txtAmount.Text.Length, 0);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            ChangeInsuranceType type = new ChangeInsuranceType();
            type.Show();

            if (type.IsSave)
            {
                LoadInsuranceType();
            }
        }
    }
}