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

namespace HRManagement.Screens.Account
{
    public partial class UCAccount : DevExpress.XtraEditors.XtraUserControl
    {
        public UCAccount()
        {
            InitializeComponent();
        }

        private void LoadAllInfoAccount()
        {
            AccountDAO dao = new AccountDAO();
            gAccount.DataSource = dao.GetAllInfoAccounts();
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            LoadAllInfoAccount();
        }
    }
}
