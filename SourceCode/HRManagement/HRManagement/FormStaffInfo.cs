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

namespace HRManagement
{
    public partial class FormStaffInfo : DevExpress.XtraEditors.XtraForm
    {
        private string filename = "";
        public FormStaffInfo()
        {
            InitializeComponent();
        }

        private void LoadButtonCheckTime()
        {
            int now = DateTime.Now.Hour;

            if (now > 8)
            {
                btnCheckin.Enabled = false;
            }

            if(now < 18)
            {
                btnCheckout.Enabled = false;
            }
        }

        private void FormStaffInfo_Load(object sender, EventArgs e)
        {
            lbStaffName.Text = InfoStaffCommon.StaffName;
            lbPosition.Text = InfoStaffCommon.Position;

            string enviroment = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            try
            {
                pboxAvatar.Image = Image.FromFile(enviroment + "\\Resource\\Upload\\" + InfoStaffCommon.Avatar);
            }
            catch(Exception)
            {

            }

            LoadButtonCheckTime();
        }

        private void AddToScreen(Control control)
        {
            panelSelect.Controls.Clear();
            panelSelect.Controls.Add(control);
            panelSelect.Dock = DockStyle.Fill;
        }

        private void btnLeaveAbsence_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.LeaveAbsence.UCLeaveAbsence());
        }

        private void panelSelect_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnTimeSheets_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Timekeeping.UCStaffTimekeeping());
        }

        private void btnStaffCourse_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Course.UCStaffCourse());
        }

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            AddToScreen(new Screens.Explanation.UCExplanation());
        }

        private void FormStaffInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn thực sự muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            string ext = "png";
            string filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.tif; ...";

            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.CheckFileExists)
                    {
                        filename = System.IO.Path.GetFileName(openFile.FileName);
                        //string path = System.IO.Path.GetFullPath(open.FileName);
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        try
                        {
                            System.IO.File.Copy(openFile.FileName, path + "\\Resource\\Upload\\" + filename);
                        }
                        catch { }

                        pboxAvatar.Image = Image.FromFile(path + "\\Resource\\Upload\\" + filename);

                        StaffDAO dao = new StaffDAO();
                        dao.ChangeAvatar("VP01924", filename);
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Model.EF.Timekeeping GetInfoCheckin()
        {
            Model.EF.Timekeeping checkin = new Model.EF.Timekeeping();
            checkin.IDStaff = InfoStaffCommon.IDStaff;
            checkin.Checkin = DateTime.Now;
            checkin.Checkout = null;
            checkin.Type = "0";
            checkin.Description = "";
            checkin.Status = "1";

            return checkin;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();

            string idStaff = InfoStaffCommon.IDStaff;

            var exist = dao.IsExistTimekeeping(idStaff, DateTime.Now);

            if (exist == null)
            {
                Model.EF.Timekeeping checkin = GetInfoCheckin();

                var success = dao.Add(checkin);
                if (success)
                {
                    NotificationCommon.AddSuccess("Chấm công vào", "");
                }
                else
                {
                    NotificationCommon.AddFaild("Chấm công vào", "");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã thực hiện chấm vào cho hôm nay rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Model.EF.Timekeeping GetInfoCheckout(Model.EF.IsExistCheckTime_Result info)
        {
            Model.EF.Timekeeping checkout = new Model.EF.Timekeeping();

            checkout.IDTime = info.IDTime;
            checkout.IDStaff = info.IDStaff;
            checkout.Checkin = DateTime.Parse(info.Checkin.ToString());
            checkout.Checkout = DateTime.Now;
            checkout.Type = info.Type;
            checkout.Description = info.Description;

            return checkout;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            TimekeepingDAO dao = new TimekeepingDAO();

            string idStaff = InfoStaffCommon.IDStaff;

            var exist = dao.IsExistTimekeeping(idStaff, DateTime.Now);

            if(exist != null)
            {
                if(exist.Checkout == null)
                {
                    Model.EF.Timekeeping checkout = GetInfoCheckout(exist);

                    var success = dao.AddCheckout(checkout);
                    if (success)
                    {
                        NotificationCommon.AddSuccess("Chấm công về", "");
                    }
                    else
                    {
                        NotificationCommon.AddFaild("Chấm công về", "");
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại dữ liệu chấm công về", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn đã thực hiện chấm về cho hôm nay rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}