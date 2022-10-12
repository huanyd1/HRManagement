using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

            gvAccount.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Status")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChangeManager manager = new FormChangeManager();
            manager.IsAdd = true;
            manager.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvAccount.RowCount > 0)
            {
                string idManager = gvAccount.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeManager manager = new FormChangeManager();
                manager.IsAdd = false;
                manager.IsInfo = true;
                manager.IdStaff = idManager;
                manager.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvAccount.RowCount > 0)
            {
                string idManager = gvAccount.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeManager manager = new FormChangeManager();
                manager.IsAdd = false;
                manager.IdStaff = idManager;
                manager.ShowDialog();
            }
        }

        private void gvAccount_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Type" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Type").ToString();
                switch (currencyType)
                {
                    case "1": e.DisplayText = "Admin tạo"; break;
                    case "2": e.DisplayText = "Admin xem"; break;
                    case "3": e.DisplayText = "Admin duyệt"; break;
                }
            }
            else if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Không hoạt động"; break;
                    case "1": e.DisplayText = "Hoạt động"; break;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = save.FileName;
                    gAccount.ExportToXlsx(path);
                    Process.Start(path);
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }
    }
}
