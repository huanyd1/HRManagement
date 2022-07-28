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

namespace HRManagement.Screens.StaffCourse
{
    public partial class FormChangeStaffCourse : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private string _idStaff;

        public FormChangeStaffCourse()
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

        private void LoadAllCourse()
        {
            CourseDAO dao = new CourseDAO();
            cbCourse.Properties.DataSource = dao.GetAll();
            cbCourse.Properties.DisplayMember = "CourseName";
            cbCourse.Properties.ValueMember = "IDCourse";
        }

        private void FormChangeStaffCourse_Load(object sender, EventArgs e)
        {
            LoadInfoStaff();
            LoadAllCourse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffCourseDAO dao = new StaffCourseDAO();

            List<string> idCourses = dao.GetAllCourseByIDStaff("VP01924");

            List<string> idCourseSelected = new List<string>();

            foreach (var item in cbCourse.Properties.Items.GetCheckedValues())
            {
                idCourseSelected.Add(item.ToString());
            }

            var result = idCourseSelected.Except(idCourses).ToList();

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
    }
}