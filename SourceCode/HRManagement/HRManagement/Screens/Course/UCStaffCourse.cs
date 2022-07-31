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

namespace HRManagement.Screens.Course
{
    public partial class UCStaffCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffCourse()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tabNavigationPage1.PageText = "Các khóa học đang mở";
            tabNavigationPage2.PageText = "Các khóa học đã hoàn thành";
        }

        private void LoadAllCourse()
        {
            CourseDAO dao = new CourseDAO();
            gCourse.DataSource = dao.GetAll();
        }

        private void LoadAllCourseComplete()
        {
            StaffCourseDAO dao = new StaffCourseDAO();
            gStaffCourse.DataSource = dao.AllCourseCompleteByIDStaff("VP01924");
        }

        private void UCStaffCourse_Load(object sender, EventArgs e)
        {
            LoadAllCourse();
            LoadAllCourseComplete();
            
        }
    }
}
