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

namespace HRManagement.Screens.StaffInsurance
{
    public partial class FormChangeStaffInsurance : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private string _idStaff;

        public FormChangeStaffInsurance()
        {
            InitializeComponent();
        }

        public string IdStaff
        {
            set { _idStaff = value; }
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        private void LoadInfoStaff()
        {
            StaffDAO dao = new StaffDAO();

            txtIDStaff.Text = _idStaff;
            txtStaffName.Text = dao.GetStaffNameByID(_idStaff);
        }

        private void LoadAllInsuranceType()
        {
            InsuranceTypeDAO dao = new InsuranceTypeDAO();
            cbInsuranceType.DataSource = dao.GetAll();
            cbInsuranceType.DisplayMember = "TypeName";
            cbInsuranceType.ValueMember = "IDInsuranceType";
        }

        private void LoadAllInsurance()
        {
            string idType = cbInsuranceType.SelectedValue.ToString();

            InsuranceDAO dao = new InsuranceDAO();
            cbInsurance.Properties.DataSource = dao.GetInsuranceByIDType(idType);
            cbInsurance.Properties.DisplayMember = "InsuranceName";
            cbInsurance.Properties.ValueMember = "IDInsurance";
        }

        private void FormChangeStaffInsurance_Load(object sender, EventArgs e)
        {
            this.Text = ActionCommon.AddAction("Nhân viên - Bảo hiểm");
            LoadInfoStaff();
            LoadAllInsuranceType();
        }

        private void cbInsuranceType_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadAllInsurance();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffInsuranceDAO dao = new StaffInsuranceDAO();

            List<string> idInsurance = dao.GetAllInsuranceByIDStaff("VP01924");

            List<string> idInsuranceSlected = new List<string>();

            foreach (var item in cbInsurance.Properties.Items.GetCheckedValues())
            {
                idInsuranceSlected.Add(item.ToString());
            }

            var result = idInsuranceSlected.Except(idInsurance).ToList();

            if (dao.Add(result, _idStaff))
            {
                _isSave = true;
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Thêm mới", "Khóa học cho Nhân viên");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm mới", "Khóa học cho Nhân viên");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}