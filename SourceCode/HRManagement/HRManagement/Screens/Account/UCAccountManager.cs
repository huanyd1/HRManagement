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
    public partial class UCAccountManager : DevExpress.XtraEditors.XtraUserControl
    {
        public UCAccountManager()
        {
            InitializeComponent();
        }

        private void LoadAllInfoAccount()
        {
            AccountDAO dao = new AccountDAO();
            gAccount.DataSource = dao.GetInfoAccountsManager();
        }

        private void UCAccountManager_Load(object sender, EventArgs e)
        {
            LoadAllInfoAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChangeManager manager = new FormChangeManager();
            manager.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormChangeManager manager = new FormChangeManager();
            manager.IsAdd = false;
            manager.ShowDialog();
        }
    }
}
