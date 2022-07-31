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
    public partial class FormChangeExplanation : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;

        public FormChangeExplanation()
        {
            InitializeComponent();
            dtimeDate.MaxDate = DateTime.Now;
        }

        public bool IsSave
        {
            get { return _isSave; }
        }

        public Model.EF.Timekeeping GetInfoExplanation()
        {
            Model.EF.Timekeeping explanation = new Model.EF.Timekeeping();
            explanation.IDStaff = "VP01924";
            explanation.Checkin = dtimeDate.Value;
            explanation.Type = "1";
            explanation.Description = txtDescription.Text;
            explanation.Status = "0";

            return explanation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();

            Model.EF.Timekeeping time = GetInfoExplanation();

            var timeKeeping = dao.IsExistTimekeeping("VP01924", dtimeDate.Value);

            if (timeKeeping != null)
            {
                 MessageBox.Show(Model.MessageBoxCommon.IsExistTime(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else
            {
                if (dao.Add(time))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess("Thêm mới" , "Giải trình");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild("Thêm mới", "Giải trình");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}