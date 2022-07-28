using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections;
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
    public partial class FormInfoStaffCourse : DevExpress.XtraEditors.XtraForm
    {
        private string _idStaff;

        public FormInfoStaffCourse()
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
            StaffCourseDAO dao = new StaffCourseDAO();

            txtIDStaff.Text = _idStaff;
            txtStaffName.Text = staff.GetStaffNameByID(_idStaff);
            gStaffCourse.DataSource = dao.AllInfoStaffCourseByIDStaff(_idStaff);
        }

        private void FormChangeStaffCourse_Load(object sender, EventArgs e)
        {
            LoadInfoStaffCourse();
        }
    }
}