using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
            if (!string.IsNullOrEmpty(cbMonth.Text.ToString()))
            {
                int month = int.Parse(cbMonth.Text.Replace("Tháng ", ""));

                TimekeepingDAO dao = new TimekeepingDAO();
                var data = dao.GetTimeByIDStaffType();

                List<Model.EF.Timekeeping> lstExplanation = new List<Model.EF.Timekeeping>();

                foreach (var item in data)
                {
                    var currentMonth = int.Parse(DateTime.Parse(item.Checkin.ToString()).ToString("MM")).ToString();
                    if (currentMonth == month.ToString())
                    {
                        lstExplanation.Add(item);
                    }
                }
                gExplanation.DataSource = lstExplanation;
            }
        }

        private void LoadAllMonth()
        {
            cbMonth.Items.Add("Tháng 1");
            cbMonth.Items.Add("Tháng 2");
            cbMonth.Items.Add("Tháng 3");
            cbMonth.Items.Add("Tháng 4");
            cbMonth.Items.Add("Tháng 5");
            cbMonth.Items.Add("Tháng 6");
            cbMonth.Items.Add("Tháng 7");
            cbMonth.Items.Add("Tháng 8");
            cbMonth.Items.Add("Tháng 9");
            cbMonth.Items.Add("Tháng 10");
            cbMonth.Items.Add("Tháng 11");
            cbMonth.Items.Add("Tháng 12");

            cbMonth.SelectedText = "Tháng " + DateTime.Now.Month.ToString();
        }

        private void UCExplanation_Load(object sender, EventArgs e)
        {
            LoadAllMonth();
            LoadAllInfoExplanation();

            if (InfoStaffCommon.IsAdmin)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnAgree.Visible = true;
                btnRefuse.Visible = true;
            }
            else
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnAgree.Visible = false;
                btnRefuse.Visible = false;
            }

            if (!InfoStaffCommon.IsAdmin)
            {
                gvExplanation.Columns["IDStaff"].Visible = false;
            }

            gvExplanation.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Status")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : ((string)evt.CellValue == "0" ? Color.Yellow : Color.IndianRed);
                }
            };
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvExplanation.RowCount > 0)
            {
                string status = gvExplanation.GetFocusedRowCellValue("Status").ToString();

                if (status == "0")
                {
                    DialogResult dlg = MessageBox.Show(Model.MessageBoxCommon.DeleteExplanation(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        int idTime = int.Parse(gvExplanation.GetFocusedRowCellValue("IDTime").ToString());
                        string idStaff = gvExplanation.GetFocusedRowCellValue("IDStaff").ToString();

                        TimekeepingDAO dao = new TimekeepingDAO();

                        if (dao.DeleteExplanation(idTime, idStaff))
                        {
                            Model.NotificationCommon.DeleteSuccess("Giải trình");
                            LoadAllInfoExplanation();
                        }
                        else
                        {
                            Model.NotificationCommon.DeleteFaild("Giải trình");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa Giải trình đã duyệt");
                }
            }
        }

        private void IsAgreeExplanation(bool isAgree)
        {
            string idStaff = gvExplanation.GetFocusedRowCellValue("IDStaff").ToString();
            int idTime = int.Parse(gvExplanation.GetFocusedRowCellValue("IDTime").ToString());

            string selectedDate = DateTime.Parse(gvExplanation.GetFocusedRowCellValue("Checkin").ToString()).ToShortDateString();
            int year = int.Parse(selectedDate.Split('/')[2]);
            int month = int.Parse(selectedDate.Split('/')[0]);
            int day = int.Parse(selectedDate.Split('/')[1]);
            var checkin = new DateTime(year, month, day, 7, 45, 0);
            var checkout = new DateTime(year, month, day, 17, 45, 0);

            string type = gvExplanation.GetFocusedRowCellValue("Type").ToString();
            string description = gvExplanation.GetFocusedRowCellValue("Description").ToString();
            string status = isAgree == true ? "1" : "2";

            Model.EF.Timekeeping time = new Model.EF.Timekeeping();
            time.IDTime = idTime;
            time.IDStaff = idStaff;
            time.Checkin = checkin;
            time.Checkout = checkout;
            time.Type = type;
            time.Description = description;
            time.Status = status;

            TimekeepingDAO dao = new TimekeepingDAO();

            if (dao.AgreeExplanation(time))
            {
                Model.NotificationCommon.AddSuccess("Duyệt", "Giải trình");
            }
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            if(gvExplanation.RowCount > 0)
            {
                string status = gvExplanation.GetFocusedRowCellValue("Status").ToString();
                if(status != "0")
                {
                    MessageBox.Show("Không thể thay đổi Giải trình đã Duyệt/Từ chối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IsAgreeExplanation(true);
                }
            }
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            string status = gvExplanation.GetFocusedRowCellValue("Status").ToString();
            if (status != "0")
            {
                MessageBox.Show("Không thể thay đổi Giải trình đã Duyệt/Từ chối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IsAgreeExplanation(false);
            }
        }

        private void gvExplanation_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Chờ phê duyệt"; break;
                    case "1": e.DisplayText = "Đã phê duyệt"; break;
                    case "2": e.DisplayText = "Đã từ chối"; break;
                }
            }
        }

        private void gvExplanation_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {

            if(gvExplanation.RowCount > 0)
            {
                string status = gvExplanation.GetFocusedRowCellValue("Status").ToString();

                if(status == "0")
                {
                    btnAgree.Enabled = true;
                    btnRefuse.Enabled = true;
                }
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllInfoExplanation();
        }
    }
}
