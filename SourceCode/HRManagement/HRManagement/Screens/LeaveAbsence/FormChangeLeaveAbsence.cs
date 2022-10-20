using DevExpress.XtraEditors;
using Model;
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
    public partial class FormChangeLeaveAbsence : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;

        public FormChangeLeaveAbsence()
        {
            InitializeComponent();
            this.Text = ActionCommon.AddAction("Nghỉ phép");

            dtimeFrom.MinDate = DateTime.Now;
            dtimeTo.MinDate = DateTime.Now;
            txtTotalDay.ReadOnly = true;
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        private void dtimeTo_ValueChanged(object sender, EventArgs e)
        {
            var day = ((int)(dtimeTo.Value - dtimeFrom.Value).TotalDays) + 1;
            txtTotalDay.Text = day.ToString();
        }

        public Model.EF.LeaveAbsence GetInfoLeaveAbsence()
        {
            Model.EF.LeaveAbsence leave = new Model.EF.LeaveAbsence();
            leave.IDStaff = "VP01924";
            leave.FromDate = dtimeFrom.Value;
            leave.ToDate = dtimeTo.Value;
            leave.TotalDay = int.Parse(txtTotalDay.Text);
            leave.Descript = txtDescript.Text;
            leave.Status = "0";

            return leave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LeaveAbsenceDAO dao = new LeaveAbsenceDAO();
            Model.EF.LeaveAbsence leaveAbsence = GetInfoLeaveAbsence();

            if (dao.Add(leaveAbsence))
            {
                _isSave = true;
            }


            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Thêm thông tin", "Nghỉ phép");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm thông tin", "Nghỉ phép");
            }
        }
    }
}