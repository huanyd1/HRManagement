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

namespace HRManagement.Screens.Salary
{
    public partial class ChangeSalary : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isInfo = false;
        private string _idStaff;

        private readonly string amount = "Lương";
        private readonly string allowance = "Phụ cấp";
        private readonly string tax = "Thuế";

        public ChangeSalary()
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

        private void ChangeSalary_Load(object sender, EventArgs e)
        {
            this.Text = Model.ActionCommon.EditAction("Tiền lương");
            txtIDStaff.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            btnSave.Text = "Cập nhật";

            SalaryDAO dao = new SalaryDAO();
            Model.EF.Salary salary = dao.GetSingleByID(_idStaff);

            StaffDAO Sdao = new StaffDAO();

            txtIDStaff.Text = salary.IDStaff.ToString();
            txtAmount.Text = salary.SalaryAmount.ToString();
            txtStaffName.Text = Sdao.GetStaffNameByID(_idStaff);
            txtAllowance.Text = salary.Allowance.ToString();
            txtTax.Text = salary.Tax.ToString();
            txtCoefficient.Text = salary.Coefficient.ToString();

            //Nếu info thì disable tất cả
            if (_isInfo)
            {
                txtAmount.ReadOnly = true;
                txtAllowance.ReadOnly = true;
                txtTax.ReadOnly = true;
                txtCoefficient.ReadOnly = true;

                btnSave.Visible = false;
                this.Text = Model.ActionCommon.InfoAction("Tiền lương");
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
            txt.Text = String.Format(culture, "{0:N0}", value);
            txt.Select(txt.Text.Length, 0);          
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtAmount.Text == string.Empty)
            {
                errorAmount.SetError(txtAmount, Model.CheckVariableCommon.NullVariable(amount));
                flag = false;
            }
            else
            {
                errorAmount.SetError(txtAmount, null);
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

            return flag;
        }

        public Model.EF.Salary GetInfoSalary()
        {
            Model.EF.Salary salary = new Model.EF.Salary();
            salary.IDStaff = txtIDStaff.Text;
            salary.SalaryAmount = int.Parse(txtAmount.Text.Replace(",", ""));
            salary.Allowance = int.Parse(txtAllowance.Text.Replace(",", ""));
            salary.Tax = int.Parse(txtTax.Text.Replace(",", ""));
            salary.Coefficient = double.Parse(txtCoefficient.Text.ToString());

            return salary;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            SalaryDAO dao = new SalaryDAO();
            Model.EF.Salary salary = GetInfoSalary();

            if (dao.Edit(salary))
            {
                _isSave = true;
            }


            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Sửa thông tin", "Lương");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Sửa thông tin", "Lương");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}