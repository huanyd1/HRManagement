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

namespace HRManagement.Screens.Timekeeping
{
    public partial class FormChangeTimekeeping : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private string _idStaff;
        private string _idDepartment;
        private bool _isAddNotID;

        private readonly string reason = "Lý do";

        public FormChangeTimekeeping()
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

        public string IdStaff
        {
            set { _idStaff = value; }
        }
        public string IdDepartment
        {
            set { _idDepartment = value; }
        }

        public bool IsAddNotID
        {
            get { return _isAddNotID; }
            set { _isAddNotID = value; }
        }

        private void LoadInfoStaff()
        {
            StaffDAO staff = new StaffDAO();
            DepartmentDAO department = new DepartmentDAO();

            cbStaff.Text = staff.GetStaffNameByID(_idStaff);
            cbDepartment.Text = department.GetDepartmentNameByIDStaff(_idStaff);
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void FormChangeTimekeeping_Load(object sender, EventArgs e)
        {
            LoadAllDepartment();

            if (_isAdd)
            {
                this.Text = Model.ActionCommon.AddAction("Chấm công");
                cbDepartment.SelectedValue = _idDepartment;
                cbStaff.SelectedValue = _idStaff;

                cbDepartment.Enabled = false;
                cbStaff.Enabled = false;
            }
            else
            {
                if (_isAddNotID)
                {
                    this.Text = Model.ActionCommon.AddAction("Chấm công");
                }
                else
                {
                    this.Text = Model.ActionCommon.DeleteAction("Chấm công");

                    cbDepartment.Enabled = false;
                    cbStaff.Enabled = false;
                }
            }

            LoadInfoStaff();
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtReason.Text == string.Empty)
            {
                errorReason.SetError(txtReason, Model.CheckVariableCommon.NullVariable(reason));
                flag = false;
            }
            else
            {
                errorReason.SetError(txtReason, null);
            }

            return flag;
        }

        public Model.EF.Timekeeping GetInfoTimekeeping()
        {
            Model.EF.Timekeeping time = new Model.EF.Timekeeping();

            if (_isAdd)
            {
                time.IDStaff = _idStaff;
                string selectedDate = dtDate.Value.ToShortDateString();
                int year = int.Parse(selectedDate.Split('/')[2]);
                int month = int.Parse(selectedDate.Split('/')[0]);
                int day = int.Parse(selectedDate.Split('/')[1]);
                time.Checkin = new DateTime(year, month, day, 7, 45, 0);
                time.Checkout = new DateTime(year, month, day, 17, 45, 0);
                time.Description = txtReason.Text;
            }
            else
            {
                if (_isAddNotID)
                {
                    time.IDStaff = cbStaff.SelectedValue.ToString();
                    string selectedDate = dtDate.Value.ToShortDateString();
                    int year = int.Parse(selectedDate.Split('/')[2]);
                    int month = int.Parse(selectedDate.Split('/')[0]);
                    int day = int.Parse(selectedDate.Split('/')[1]);
                    time.Checkin = new DateTime(year, month, day, 7, 45, 0);
                    time.Checkout = new DateTime(year, month, day, 17, 45, 0);
                    time.Description = txtReason.Text;
                }
                else
                {
                    time.IDStaff = _idStaff;
                    string selectedDate = dtDate.Value.ToShortDateString();
                    int year = int.Parse(selectedDate.Split('/')[2]);
                    int month = int.Parse(selectedDate.Split('/')[0]);
                    int day = int.Parse(selectedDate.Split('/')[1]);
                    time.Checkin = new DateTime(year, month, day, 12, 00, 0);
                    time.Checkout = new DateTime(year, month, day, 12, 00, 0);
                    time.Description = txtReason.Text;
                }            
            }

            return time;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            TimekeepingDAO dao = new TimekeepingDAO();

            Model.EF.Timekeeping time = GetInfoTimekeeping();

            if (_isAddNotID)
            {
                _idStaff = cbStaff.SelectedValue.ToString();
            }

            var timeKeeping = dao.IsExistTimekeeping(_idStaff, dtDate.Value);

            if (timeKeeping != null)
            {
                if (_isAdd || _isAddNotID)
                {
                    MessageBox.Show(Model.MessageBoxCommon.IsExistTime(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    time.IDTime = timeKeeping.IDTime;

                    if (dao.Edit(time))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (_isAdd || _isAddNotID)
                {
                    if (dao.Add(time))
                    {
                        _isSave = true;
                    }
                }
                else
                {
                    MessageBox.Show(Model.MessageBoxCommon.IsNotExistTime(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Xóa thông tin", "Chấm công");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Xóa thông tin", "Chấm công");
            }
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbDepartment.SelectedValue != null)
            {
                if(cbStaff.DataSource != null)
                {
                    cbStaff.DataSource = null;
                } 

                string idDepartment = cbDepartment.SelectedValue.ToString();

                StaffDAO dao = new StaffDAO();
                cbStaff.DataSource = dao.GetStaffByIDDepartment(idDepartment);
                cbStaff.DisplayMember = "StaffName";
                cbStaff.ValueMember = "IDStaff";
            }
        }
    }
}