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

namespace HRManagement.Screens.Explanation
{
    public partial class FormChangeExplanation : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private string _idStaff;

        public FormChangeExplanation()
        {
            InitializeComponent();
            this.Text = ActionCommon.AddAction("Giải trình");

            dtimeDate.MaxDate = DateTime.Now;
        }
        public string IdStaff
        {
            set { _idStaff = value; }
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        private void LoadAllStaff()
        {
            StaffDAO dao = new StaffDAO();
            cbStaffName.DataSource = dao.GetAll();
            cbStaffName.DisplayMember = "StaffName";
            cbStaffName.ValueMember = "IDStaff";
        }

        private void FormChangeExplanation_Load(object sender, EventArgs e)
        {
            LoadAllStaff();

            if (_idStaff != null)
            {
                cbStaffName.Enabled = false;
                cbStaffName.SelectedValue = _idStaff;
            }
            else
            {
                cbStaffName.Enabled = true;
            }
        }

        public Model.EF.Timekeeping GetInfoExplanation()
        {
            Model.EF.Timekeeping explanation = new Model.EF.Timekeeping();
            explanation.IDStaff = txtIDStaff.Text.ToString();
            explanation.Checkin = dtimeDate.Value;
            explanation.Type = "1";
            explanation.Description = txtDescription.Text;
            explanation.Status = "0";

            return explanation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();

            Model.EF.Timekeeping time = GetInfoExplanation();

            var timeKeeping = dao.IsExistTimekeeping(txtIDStaff.Text.ToString(), dtimeDate.Value);

            if (timeKeeping != null)
            {
                 MessageBox.Show(Model.MessageBoxCommon.IsExistTime(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else
            {
                if (dao.Add(time))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Thêm mới" , "Giải trình");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm mới", "Giải trình");
            }
        }

        private void cbStaffName_SelectedValueChanged(object sender, EventArgs e)
        {
            txtIDStaff.Text = cbStaffName.SelectedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}