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
    public partial class FormInfoStaffInsurance : DevExpress.XtraEditors.XtraForm
    {
        private string _idStaff;
        public FormInfoStaffInsurance()
        {
            InitializeComponent();
        }

        public string IdStaff
        {
            set { _idStaff = value; }
        }

        private void LoadInfoStaffCourse()
        {
            StaffDAO staff = new StaffDAO();
            StaffInsuranceDAO dao = new StaffInsuranceDAO();

            txtIDStaff.ReadOnly = true;
            txtStaffName.ReadOnly = true;

            txtIDStaff.Text = _idStaff;
            txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
            gStaffInsurance.DataSource = dao.AllInfoStaffInsuranceByIDStaff(_idStaff);
        }

        private void FormInfoStaffInsurance_Load(object sender, EventArgs e)
        {
            this.Text = ActionCommon.InfoAction("Nhân viên - Bảo hiểm");
            LoadInfoStaffCourse();
            gvStaffInsurance.OptionsView.AllowCellMerge = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}