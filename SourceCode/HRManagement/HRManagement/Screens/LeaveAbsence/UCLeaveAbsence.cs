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
            LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
            gLeaveAbsence.DataSource = dao.GetListLeaveAbsenceByID("VP01924");
        }

        private void LoadRemainStaff()
        {
            LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
            lbRemain.Text = dao.GetRemainByIDStaff("VP01924").ToString();
        }

        private void UCLeaveAbsence_Load(object sender, EventArgs e)
        {
            if (InfoStaffCommon.IsAdmin)
            {
                lbRemain.Visible = false;
                label2.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnAgree.Visible = true;
                btnRefuse.Visible = true;
            }
            else
            {
                btnAgree.Visible = false;
                btnRefuse.Visible = false;

                gvLeaveAbsence.Columns["IDStaff"].Visible = false;
            }

            LoadAllLeaveAbsenceStaff();
            LoadRemainStaff();

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
    }
}
