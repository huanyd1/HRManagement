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
using Model.EF;

namespace HRManagement.Screens.Department
{
    public partial class ChangeDepartment : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idDepartment;

        private readonly string idDepartment = "Mã phòng ban";
        private readonly string departmentName = "Tên phòng ban";

        public ChangeDepartment()
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
        public string IdDepartment
        {
            set { _idDepartment = value; }
        }

        private void LoadStatusDepartment()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Hoạt động");
            cbStatus.Items.Add("Ngừng hoạt động");

            cbStatus.SelectedText = "Hoạt động";
        }

        private void ChangeDepartment_Load(object sender, EventArgs e)
        {
            LoadStatusDepartment();

            if (!_isAdd)
            {          
                this.Text = Model.ActionCommon.EditAction("Phòng ban");
                txtIDDepartment.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                DepartmentDAO dao = new DepartmentDAO();
                Model.EF.Department department = dao.GetSingleByID(_idDepartment);

                txtIDDepartment.Text = department.IDDepartment.ToString();
                txtDepartmentName.Text = department.DepartmentName.ToString();
                cbStatus.Text = department.Status.ToString() == "1" ? "Hoạt động" : "Ngừng hoạt động";

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    txtIDDepartment.ReadOnly = true;
                    txtDepartmentName.ReadOnly = true;
                    cbStatus.Enabled = false;

                    btnSave.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Phòng ban");
                }
            }
            else
            {
                this.Text = Model.ActionCommon.AddAction("Phòng ban");
                btnSave.Text = "Thêm mới";
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtIDDepartment.Text == string.Empty)
            {
                errorIDDepartment.SetError(txtIDDepartment, Model.CheckVariableCommon.NullVariable(idDepartment));
                flag = false;
            }
            else
            {
                errorIDDepartment.SetError(txtIDDepartment, null);
            }

            if (txtDepartmentName.Text == string.Empty)
            {
                errorDepartmentName.SetError(txtDepartmentName, Model.CheckVariableCommon.NullVariable(departmentName));
                flag = false;
            }
            else
            {
                errorDepartmentName.SetError(txtDepartmentName, null);
            }

            return flag;
        }

        public Model.EF.Department GetInfoDepartment()
        {
            Model.EF.Department department = new Model.EF.Department();
            department.IDDepartment = txtIDDepartment.Text;
            department.DepartmentName = txtDepartmentName.Text;
            department.Status = cbStatus.Text == "Hoạt động" ? "1" : "0";

            return department;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            DepartmentDAO dao = new DepartmentDAO();

            Model.EF.Department department = GetInfoDepartment();

            if (_isAdd)
            {
                if (dao.IsExitDepartment(txtDepartmentName.Text))
                {
                    DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExistVariable(departmentName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        if (dao.Add(department))
                        {
                            _isSave = true;
                        }
                    }
                }
                else
                {
                    if (dao.Add(department))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(department))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Phòng ban");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Phòng ban");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if((txtDepartmentName.Text != string.Empty || txtIDDepartment.Text != string.Empty) && _isInfo == false)
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.ExitForm(), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if( dialog == DialogResult.Yes)
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