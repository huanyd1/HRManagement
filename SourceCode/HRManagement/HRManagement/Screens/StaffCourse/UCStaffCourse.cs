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
    public partial class UCStaffCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaffCourse()
        {
            InitializeComponent();
        }

        private void LoadAllStaffCourse()
        {
            StaffDAO dao = new StaffDAO();
            gStaffCourse.DataSource = dao.AllInfoStaffCourse();
        }

        private void UCStaffCourse_Load(object sender, EventArgs e)
        {
            LoadAllStaffCourse();
        }
    }
}
