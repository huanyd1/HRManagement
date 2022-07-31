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

namespace HRManagement.Screens.Explanation
{
    public partial class UCExplanation : DevExpress.XtraEditors.XtraUserControl
    {
        public UCExplanation()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadAllInfoExplanation()
        {
            TimekeepingDAO dao = new TimekeepingDAO();
            gExplanation.DataSource = dao.GetTimeByIDStaffType("VP01924");
        }

        private void UCExplanation_Load(object sender, EventArgs e)
        {
            LoadAllInfoExplanation();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChangeExplanation addExplanation = new FormChangeExplanation();
            addExplanation.ShowDialog();

            if (addExplanation.IsSave)
            {
                LoadAllInfoExplanation();
            }
        }
    }
}
