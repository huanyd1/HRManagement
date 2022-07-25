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

namespace HRManagement.Screens.Insurance
{
    public partial class ChangeInsuranceType : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;

        private readonly string idInsuranceType = "Mã loại bảo hiểm";
        private readonly string insuranceTypeName = "Tên loại bảo hiểm";

        public ChangeInsuranceType()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        private void ChangeInsuranceType_Load(object sender, EventArgs e)
        {
            this.Text = Model.ActionCommon.AddAction("Loại bảo hiểm");
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtIDInsuranceType.Text == string.Empty)
            {
                errorIDInsuranceType.SetError(txtIDInsuranceType, Model.CheckVariableCommon.NullVariable(idInsuranceType));
                flag = false;
            }
            else
            {
                errorIDInsuranceType.SetError(txtIDInsuranceType, null);
            }

            if (txtTypeName.Text == string.Empty)
            {
                errorTypeName.SetError(txtTypeName, Model.CheckVariableCommon.NullVariable(insuranceTypeName));
                flag = false;
            }
            else
            {
                errorTypeName.SetError(txtTypeName, null);
            }

            return flag;
        }

        public Model.EF.InsuranceType GetInfoInsuranceType()
        {
            Model.EF.InsuranceType type = new Model.EF.InsuranceType();
            type.IDInsuranceType = txtIDInsuranceType.Text;
            type.TypeName = txtTypeName.Text;
            
            return type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            InsuranceTypeDAO dao = new InsuranceTypeDAO();

            Model.EF.InsuranceType type = GetInfoInsuranceType();

            if (dao.IsExitInsuranceType(txtTypeName.Text))
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExitVariable(insuranceTypeName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (dao.Add(type))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Add(type))
                {
                    _isSave = true;
                }
            }
            

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Thêm mới", "Bảo hiểm");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm mới", "Bảo hiểm");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtIDInsuranceType.Text != string.Empty || txtTypeName.Text != string.Empty)
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