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

namespace HRManagement.Screens.Contract
{
    public partial class UCContract : DevExpress.XtraEditors.XtraUserControl
    {
        public UCContract()
        {
            InitializeComponent();
        }

        private void LoadAllContract()
        {
            ContractDAO dao = new ContractDAO();
            gContract.DataSource = dao.GetAllInfoContract();
        }

        private void UCContract_Load(object sender, EventArgs e)
        {
            LoadAllContract();
        }
    }
}
