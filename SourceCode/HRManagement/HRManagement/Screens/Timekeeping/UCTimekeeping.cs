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
    public partial class UCTimekeeping : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTimekeeping()
        {
            InitializeComponent();
        }

        private void LoadAllTimekeeping()
        {
            TimekeepingDAO dao = new TimekeepingDAO();
            gTimekeeping.DataSource = dao.GetAllInfoTimekeeping("GTGT", 7);
        }

        private void UCTimekeeping_Load(object sender, EventArgs e)
        {
            LoadAllTimekeeping();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormInfoTimekeeping info = new FormInfoTimekeeping();
            info.Show();
        }
    }
}
