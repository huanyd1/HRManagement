using DevExpress.XtraEditors;
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
            tabNavigationPage2.PageText = "Các khóa học đang tham gia";
        }
    }
}
