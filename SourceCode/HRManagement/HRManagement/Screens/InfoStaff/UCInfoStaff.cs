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

namespace HRManagement.Screens.InfoStaff
{
    public partial class UCInfoStaff : DevExpress.XtraEditors.XtraUserControl
    {
        private bool _isEdit = false;
        public UCInfoStaff()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void LoadAllPosition()
        {
            PositionDAO dao = new PositionDAO();
            cbPosition.DataSource = dao.GetAll();
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "IDPosition";
        }

        private void LoadAllSex()
        {
            cbSex.Items.Add("Nam");
            cbSex.Items.Add("Nữ");
        }

        private void LoadAllAcademicLevel()
        {
            AcademicDAO dao = new AcademicDAO();

            cbAcademic.DataSource = dao.GetAll();
            cbAcademic.DisplayMember = "AcademicName";
            cbAcademic.ValueMember = "IDAcademic";
        }

        private void LoadAllSpecialize()
        {
            SpecializeDAO dao = new SpecializeDAO();

            cbSpecialize.DataSource = dao.GetAll();
            cbSpecialize.DisplayMember = "SpecializeName";
            cbSpecialize.ValueMember = "IDSpecialize";
        }

        private void LoadAllNation()
        {
            NationDAO dao = new NationDAO();
            cbNation.DataSource = dao.GetAll();
            cbNation.DisplayMember = "NationName";
            cbNation.ValueMember = "IDNation";
        }

        private void LoadInfoStaff()
        {
            if (InfoStaffCommon.IDStaff != "")
            {
                StaffDAO dao = new StaffDAO();
                Model.EF.GetAllInfoByIDStaff_Result staff = dao.GetAllInfoByIDStaff(InfoStaffCommon.IDStaff);

                txtIDStaff.Text = staff.IDStaff;
                txtStaffName.Text = staff.StaffName;
                cbDepartment.Text = staff.DepartmentName;
                cbPosition.SelectedValue = staff.IDPosition;
                dtimeBirthday.Text = staff.Birthday.ToString();
                txtPlace.Text = staff.Place;
                cbAcademic.SelectedValue = staff.IDAcademic;
                cbSpecialize.SelectedValue = staff.IDSpecialize;

                //Thông tin Chi tiết
                txtEmail.Text = staff.Email;
                txtCCCD.Text = staff.CCCD;
                dtimeDateRange.Text = staff.DateRange.ToString();
                txtIssueBy.Text = staff.IssueBy.ToString();
                cbSex.SelectedText = staff.Sex == "1" ? "Nam" : "Nữ";
                txtPhonenumber.Text = staff.Numberphone;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, Vui lòng thử lại!");
            }
        }

        private void ReadOnlyForm()
        {
            txtIDStaff.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            cbDepartment.Enabled = false;
            cbPosition.Enabled = false;
            dtimeBirthday.Enabled = false;
            txtPlace.ReadOnly = true;
            cbAcademic.Enabled = false;
            cbSpecialize.Enabled = false;
            cbNation.Enabled = false;

            //Thông tin Chi tiết
            txtEmail.ReadOnly = true;
            txtCCCD.ReadOnly = true;
            dtimeDateRange.Enabled = false;
            txtIssueBy.ReadOnly = true;
            cbSex.Enabled = false;
            txtPhonenumber.ReadOnly = true;
        }

        private void EnableForm()
        {
            ///txtIDStaff.ReadOnly = false;
            //txtStaffName.ReadOnly = false;
            //cbDepartment.Enabled = true;
            //cbPosition.Enabled = true;
            dtimeBirthday.Enabled = true;
            txtPlace.ReadOnly = false;
            //cbAcademic.Enabled = true;
            //cbSpecialize.Enabled = true;
            cbNation.Enabled = true;

            //Thông tin Chi tiết
            txtEmail.ReadOnly = false;
            txtCCCD.ReadOnly = false;
            dtimeDateRange.Enabled = true;
            txtIssueBy.ReadOnly = false;
            cbSex.Enabled = true;
            txtPhonenumber.ReadOnly = false;
        }

        private void UCInfoStaff_Load(object sender, EventArgs e)
        {
            ReadOnlyForm();
            dtimeBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeDateRange.Properties.Mask.UseMaskAsDisplayFormat = true;

            LoadAllDepartment();
            LoadAllPosition();
            LoadAllSex();
            LoadAllAcademicLevel();
            LoadAllSpecialize();
            LoadAllNation();

            LoadInfoStaff();
        }

        public Model.EF.Staff GetInfoStaff()
        {
            Model.EF.Staff staff = new Model.EF.Staff();

            staff.IDStaff = txtIDStaff.Text;
            staff.StaffName = txtStaffName.Text;
            staff.IDDepartment = cbDepartment.SelectedValue.ToString();
            staff.IDPosition = cbPosition.SelectedValue.ToString();
            staff.Birthday = DateTime.Parse(dtimeBirthday.Text.ToString());
            staff.Place = txtPlace.Text;

            staff.Email = txtEmail.Text;
            staff.CCCD = txtCCCD.Text;
            staff.DateRange = DateTime.Parse(dtimeDateRange.Text.ToString());
            staff.IssueBy = txtIssueBy.Text;

            staff.IDNation = int.Parse(cbNation.SelectedValue.ToString());
            staff.IDAcademic = int.Parse(cbAcademic.SelectedValue.ToString());
            staff.IDSpecialize = int.Parse(cbSpecialize.SelectedValue.ToString());

            staff.Sex = cbSex.Text == "Nam" ? "1" : "0";
            staff.Numberphone = txtPhonenumber.Text;

            staff.IDStaff = txtIDStaff.Text;

            return staff;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                StaffDAO dao = new StaffDAO();
                Model.EF.Staff staff = GetInfoStaff();
                if (dao.Edit(staff))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
            }

            _isEdit = !_isEdit;
            if (_isEdit)
            {
                LoadInfoStaff();
                EnableForm();
                btnSave.Text = "Lưu";
            }
            else
            {
                ReadOnlyForm();
                btnSave.Text = "Cập nhật";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var parent = ((sender as SimpleButton).Parent as UserControl).Parent as Panel;
            if(parent != null)
            {
                parent.Controls.Clear();
            }
        }
    }
}
