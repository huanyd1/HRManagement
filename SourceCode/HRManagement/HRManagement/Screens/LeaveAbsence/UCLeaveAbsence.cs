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
            LoadAllLeaveAbsenceStaff();
            LoadRemainStaff();
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
    }
}
