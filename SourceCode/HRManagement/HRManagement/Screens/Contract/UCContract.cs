using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Contract
{
    public partial class UCContract : DevExpress.XtraEditors.XtraUserControl
    {
        public UCContract()
        {
            InitializeComponent();
        }

        private void LoadContractType()
        {
            ContractTypeDAO dao = new ContractTypeDAO();

            cbContractType.DataSource = dao.GetAll();
            cbContractType.DisplayMember = "TypeName";
            cbContractType.ValueMember = "IDType";
        }

        private void LoadAllContract()
        {
            ContractDAO dao = new ContractDAO();
            gContract.DataSource = dao.GetAllInfoContract();
        }

        private void UCContract_Load(object sender, EventArgs e)
        {
            LoadContractType();
            LoadAllContract();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idStaff = txtIDStaff.Text.ToString();
            string staffName = txtStaffName.Text.ToString();
            string idType = cbContractType.SelectedValue.ToString();

            ContractDAO dao = new ContractDAO();
            gContract.DataSource = dao.GetContractByFilter(idStaff, staffName, idType);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvContract.RowCount > 0)
            {
                string idStaff = gvContract.GetFocusedRowCellValue("IDStaff").ToString();

                ChangeContract infoContract = new ChangeContract();
                infoContract.IsAdd = false;
                infoContract.IdStaff = idStaff;
                infoContract.IsInfo = true;
                infoContract.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeContract addContract = new ChangeContract();
            addContract.IsAdd = true;
            addContract.Show();

            if (addContract.IsSave)
            {
                LoadAllContract();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(gvContract.RowCount > 0)
            {
                string idStaff = gvContract.GetFocusedRowCellValue("IDStaff").ToString();

                ChangeContract editContract = new ChangeContract();
                editContract.IsAdd = false;
                editContract.IdStaff = idStaff;
                editContract.Show();

                if (editContract.IsSave)
                {
                    LoadAllContract();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gvContract.RowCount > 0)
            {
                string contractName = gvContract.GetFocusedRowCellValue("ContractName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteVariable("Hợp đồng", contractName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string idContract = gvContract.GetFocusedRowCellValue("IDContract").ToString();

                    ContractDAO dao = new ContractDAO();
                    if (dao.Delete(idContract))
                    {
                        Model.NotificationCommon.DeleteSuccess("Hợp đồng");
                        LoadAllContract();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Hợp đồng");
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gContract.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
