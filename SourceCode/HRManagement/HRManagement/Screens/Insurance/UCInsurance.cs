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
    public partial class UCInsurance : UserControl
    {
        public UCInsurance()
        {
            InitializeComponent();        
        }

        private void LoadAllInsurance()
        {
            InsuranceDAO dao = new InsuranceDAO();
            gInsurance.DataSource = dao.GetAllInfoInsurance();
        }

        private void LoadInsuranceType()
        {
            InsuranceTypeDAO dao = new InsuranceTypeDAO();
            cbInsuranceType.DataSource = dao.GetAll();
            cbInsuranceType.DisplayMember = "TypeName";
            cbInsuranceType.ValueMember = "IDInsuranceType";
        }

        private void UCInsurance_Load(object sender, EventArgs e)
        {
            LoadAllInsurance();
            LoadInsuranceType();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idInsurance = txtIDInsurance.Text.ToString();
            string insuranceName = txtInsuranceName.Text.ToString();
            string idType = cbInsuranceType.SelectedValue.ToString();

            InsuranceDAO dao = new InsuranceDAO();
            gInsurance.DataSource = dao.GetInsuranceByFilter(idInsurance, insuranceName, idType);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (gvInsurance.RowCount > 0)
            {
                string idInsurance = gvInsurance.GetFocusedRowCellValue("IDInsurance").ToString();

                ChangeInsurance infoInsurance = new ChangeInsurance();
                infoInsurance.IsAdd = false;
                infoInsurance.IdInsurance = idInsurance;
                infoInsurance.IsInfo = true;
                infoInsurance.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeInsurance addInsurance = new ChangeInsurance();
            addInsurance.IsAdd = true;
            addInsurance.Show();

            if (addInsurance.IsSave)
            {
                LoadAllInsurance();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(gvInsurance.RowCount > 0)
            {
                string idInsurance = gvInsurance.GetFocusedRowCellValue("IDInsurance").ToString();

                ChangeInsurance editInsurance = new ChangeInsurance();
                editInsurance.IsAdd = false;
                editInsurance.IdInsurance = idInsurance;
                editInsurance.Show();

                if (editInsurance.IsSave)
                {
                    LoadAllInsurance();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gvInsurance.RowCount > 0)
            {
                string insuranceName = gvInsurance.GetFocusedRowCellValue("InsuranceName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteVariable("Bảo hiểm", insuranceName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string idInsurance = gvInsurance.GetFocusedRowCellValue("IDInsurance").ToString();

                    InsuranceDAO dao = new InsuranceDAO();
                    if (dao.Delete(idInsurance))
                    {
                        Model.NotificationCommon.DeleteSuccess("Bảo hiểm");
                        LoadAllInsurance();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Bảo hiểm");
                    }
                }
            }
        }
    }
}
