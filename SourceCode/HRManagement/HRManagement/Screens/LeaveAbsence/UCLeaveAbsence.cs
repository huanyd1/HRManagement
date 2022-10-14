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

namespace HRManagement.Screens.LeaveAbsence
{
    public partial class UCLeaveAbsence : DevExpress.XtraEditors.XtraUserControl
    {
        public UCLeaveAbsence()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        
        private void LoadAllLeaveAbsenceStaff()
        {
            //LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
            //gLeaveAbsence.DataSource = dao.GetAll();

            if (!string.IsNullOrEmpty(cbMonth.Text.ToString()))
            {
                int month = int.Parse(cbMonth.Text.Replace("Tháng ", ""));

                LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
                var data = dao.GetAll();

                List<Model.EF.LeaveAbsence> lstLeaveAbsences = new List<Model.EF.LeaveAbsence>();

                foreach (var item in data)
                {
                    var currentMonth = int.Parse(DateTime.Parse(item.FromDate.ToString()).ToString("MM")).ToString();
                    if (currentMonth == month.ToString())
                    {
                        lstLeaveAbsences.Add(item);
                    }
                }
                gLeaveAbsence.DataSource = lstLeaveAbsences;
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

        //private void LoadRemainStaff()
        //{
        //    LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
        //    lbRemain.Text = dao.GetRemainByIDStaff("VP01924").ToString();
        //}

        private void UCLeaveAbsence_Load(object sender, EventArgs e)
        {
            if (InfoStaffCommon.AdminCreate)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnAgree.Visible = false; 
                btnRefuse.Visible = false;
            }
            else if(InfoStaffCommon.AdminApprove)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnAgree.Visible = true;
                btnRefuse.Visible = true;

                //gvLeaveAbsence.Columns["IDStaff"].Visible = false;
            }
            else if (InfoStaffCommon.IsAdmin)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnAgree.Visible = true;
                btnRefuse.Visible = true;
            }
            else
            {
                //ignore
            }

            LoadAllLeaveAbsenceStaff();
            LoadAllMonth();
            //LoadRemainStaff();

            gvLeaveAbsence.RowCellStyle += (sen, evt) =>
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
            FormChangeLeaveAbsence addLeaveAbsence = new FormChangeLeaveAbsence();
            addLeaveAbsence.Show();

            if (addLeaveAbsence.IsSave)
            {
                LoadAllLeaveAbsenceStaff();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvLeaveAbsence.RowCount > 0)
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteLeaveAbsence(), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int idLeaveAbsence = int.Parse(gvLeaveAbsence.GetFocusedRowCellValue("IDLeaveAbsence").ToString());

                    LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
                    if (dao.Delete(idLeaveAbsence))
                    {
                        Model.NotificationCommon.DeleteSuccess("Đơn xin");
                        LoadAllLeaveAbsenceStaff();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Đơn xin");
                    }
                }
            }
        }

        private void IsAgreeLeaveAbsence(bool isAgree)
        {
            int idIDLeaveAbsence = int.Parse(gvLeaveAbsence.GetFocusedRowCellValue("IDLeaveAbsence").ToString());
            string idStaff = gvLeaveAbsence.GetFocusedRowCellValue("IDStaff").ToString();
            DateTime fromDate = DateTime.Parse(gvLeaveAbsence.GetFocusedRowCellValue("FromDate").ToString());
            DateTime toDate = DateTime.Parse(gvLeaveAbsence.GetFocusedRowCellValue("ToDate").ToString());
            int totalDay = int.Parse(gvLeaveAbsence.GetFocusedRowCellValue("TotalDay").ToString());
            string descript = gvLeaveAbsence.GetFocusedRowCellValue("Descript").ToString();

            Model.EF.LeaveAbsence leave = new Model.EF.LeaveAbsence();
            leave.IDLeaveAbsence = idIDLeaveAbsence;
            leave.IDStaff = idStaff;
            leave.FromDate = fromDate;
            leave.ToDate = toDate;
            leave.TotalDay = totalDay;
            leave.Descript = descript;
            leave.Status = isAgree == true ? "1" : "2";

            LeaveAbsenceDAO dao = new LeaveAbsenceDAO();

            if (dao.Edit(leave))
            {
                Model.NotificationCommon.AddSuccess("Duyệt", "Nghỉ phép");
            }
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            if (gvLeaveAbsence.RowCount > 0)
            {
                string status = gvLeaveAbsence.GetFocusedRowCellValue("Status").ToString();
                if (status != "0")
                {
                    MessageBox.Show("Không thể thay đổi Nghỉ phép đã Duyệt/Từ chối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IsAgreeLeaveAbsence(true);
                }
            }
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            if (gvLeaveAbsence.RowCount > 0)
            {
                string status = gvLeaveAbsence.GetFocusedRowCellValue("Status").ToString();
                if (status != "0")
                {
                    MessageBox.Show("Không thể thay đổi Nghỉ phép đã Duyệt/Từ chối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IsAgreeLeaveAbsence(false);
                }
            }
        }

        private void gvLeaveAbsence_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllLeaveAbsenceStaff();
        }
    }
}
