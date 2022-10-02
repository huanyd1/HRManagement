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
    public partial class ChangeContractType : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;

        private readonly string idContractType = "Mã loại hợp đồng";
        private readonly string contractTypeName = "Tên loại hợp đồng";
        public ChangeContractType()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        private void ChangeContractType_Load(object sender, EventArgs e)
        {
            this.Text = Model.ActionCommon.AddAction("Loại hợp đồng");
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtIDContractType.Text == string.Empty)
            {
                errorIDContractType.SetError(txtIDContractType, Model.CheckVariableCommon.NullVariable(idContractType));
                flag = false;
            }
            else
            {
                errorIDContractType.SetError(txtIDContractType, null);
            }

            if (txtTypeName.Text == string.Empty)
            {
                errorTypeName.SetError(txtTypeName, Model.CheckVariableCommon.NullVariable(contractTypeName));
                flag = false;
            }
            else
            {
                errorTypeName.SetError(txtTypeName, null);
            }

            return flag;
        }

        public Model.EF.ContractType GetInfoContractType()
        {
            Model.EF.ContractType type = new Model.EF.ContractType();
            type.IDType = txtIDContractType.Text;
            type.TypeName = txtTypeName.Text;

            return type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            ContractTypeDAO dao = new ContractTypeDAO();

            Model.EF.ContractType type = GetInfoContractType();

            if (dao.IsExitContractType(txtTypeName.Text))
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExistVariable(contractTypeName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                Model.NotificationCommon.AddSuccess("Thêm mới", "Loại hợp đồng");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm mới", "Loại hợp đồng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtIDContractType.Text != string.Empty || txtTypeName.Text != string.Empty)
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