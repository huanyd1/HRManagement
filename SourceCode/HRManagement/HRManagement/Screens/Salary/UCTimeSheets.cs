using DevExpress.XtraEditors;
using Model;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Salary
{
    public partial class UCTimeSheets : DevExpress.XtraEditors.XtraUserControl
    {
        int _dayInMonth = 0;

        public UCTimeSheets()
        {
            InitializeComponent();
        }

        private void LoadCbDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void LoadCbMonth()
        {
            for(int i = 0; i <= 12; i++)
            {
                string month = "Tháng " + i;
                cbMonth.Items.Add(month);
            }

            var _month = DateTime.Now.Month;

            cbMonth.SelectedItem = "Tháng " + _month;
        }

        private void LoadAllInfoTimeSheets()
        {
            if(cbDepartment.SelectedItem != null)
            {
                string idDepartment = cbDepartment.SelectedValue.ToString();

                SalaryDAO dao = new SalaryDAO();
                gTimeSheets.DataSource = dao.GetTimeSheetsByMonth(idDepartment, int.Parse(cbMonth.SelectedItem.ToString().Replace("Tháng ","")));
            }
        }

        private void UCTimeSheets_Load(object sender, EventArgs e)
        {
            LoadCbDepartment();
            LoadCbMonth();
            LoadAllInfoTimeSheets();
            gvTimeSheets.OptionsView.AllowCellMerge = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedItem != null)
            {
                string idDepartment = cbDepartment.SelectedValue.ToString();

                SalaryDAO dao = new SalaryDAO();
                gTimeSheets.DataSource = dao.GetTimeSheetsByMonth(idDepartment, int.Parse(cbMonth.SelectedItem.ToString().Replace("Tháng ", "")));
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvTimeSheets.RowCount > 0)
            {
                string idStaff = gvTimeSheets.GetFocusedRowCellValue("IDStaff").ToString();
                string idDepartment = gvTimeSheets.GetFocusedRowCellValue("IDDepartment").ToString();
                int month = int.Parse(cbMonth.SelectedItem.ToString().Replace("Tháng ", ""));

                FormInfoTimeSheets infoTimeSheets = new FormInfoTimeSheets();
                infoTimeSheets.IdStaff = idStaff;
                infoTimeSheets.IdDepartment = idDepartment;
                infoTimeSheets.Month = month;
                infoTimeSheets.Show();
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if(gvTimeSheets.RowCount > 0)
            {
                string idDepartment = cbDepartment.SelectedValue.ToString();
                int month = int.Parse(cbMonth.SelectedItem.ToString().Replace("Tháng ", ""));

                SalaryDAO dao = new SalaryDAO();
                List<string> lstIDStaff = dao.lstIDStaff(idDepartment, month);
                lstIDStaff = lstIDStaff.Distinct().ToList();

                var countDay = DateTime.DaysInMonth(DateTime.Now.Year, month);
                string dayInMonth = countDay.ToString();
                var endOfMonth = Convert.ToDateTime(string.Format(month + "/" + dayInMonth + "/" + DateTime.Now.Year));
                var startOfMonth = Convert.ToDateTime(string.Format(month + "/" + "01" + "/" + DateTime.Now.Year));
                _dayInMonth = countWeekDays(startOfMonth, endOfMonth);

                foreach (var item in lstIDStaff)
                {
                    if(LoadInfoTimeSheets(idDepartment, month, item))
                    {
                        MessageBox.Show(MessageBoxCommon.SendMailSuccess(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MessageBoxCommon.SendMainError(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool LoadInfoTimeSheets(string idDepartment, int month, string idStaff)
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

                string _staffName = "";
                string _thuNhapHDCT = "";
                string _thuNhapHDTV = "";
                string _luongCB = "5300000";
                string _ngayCong = "";
                string _anCa = "800000";
                string _dienThoai = "0";
                string _xangXe = "200000";
                string _phuCapKhac = "";

                string _cacLoaiBH = "";
                string _quyCD = "50000";
                string _thueTNCN = "";
                string _thucLinh = "";


                SalaryDAO dao = new SalaryDAO();
                StaffDAO staff = new StaffDAO();
                List<Model.EF.GetTimeSheetsByMonthAndIDStaff_Result> info = dao.GetTimeSheetsByMonthAndIDStaff(idDepartment, month, idStaff);

                int insuranceAmount = 0;
                string email = "";
                foreach (var item in info)
                {
                    insuranceAmount += int.Parse(item.Amount.ToString());
                    email = item.Username;
                }

                _staffName = staff.GetStaffNameByID(idStaff);
                _thucLinh = ((((info[0].SalaryAmount / _dayInMonth) * info[0].TotalTime) + int.Parse(_anCa) + int.Parse(_xangXe) + info[0].Allowance) - (insuranceAmount + int.Parse(_quyCD) + info[0].Tax)).ToString();
                _thuNhapHDCT = double.Parse(info[0].SalaryAmount.ToString()).ToString("#,###", cul.NumberFormat);
                _thuNhapHDTV = double.Parse(((info[0].SalaryAmount / 100) * 80).ToString()).ToString("#,###", cul.NumberFormat);
                _luongCB = double.Parse(_luongCB.ToString()).ToString("#,###", cul.NumberFormat);
                _ngayCong = info[0].TotalTime.ToString();
                _anCa = double.Parse(_anCa.ToString()).ToString("#,###", cul.NumberFormat);
                _dienThoai = double.Parse(_dienThoai.ToString()).ToString("#,###", cul.NumberFormat);
                _xangXe = double.Parse(_xangXe.ToString()).ToString("#,###", cul.NumberFormat);
                _phuCapKhac = double.Parse(info[0].Allowance.ToString()).ToString("#,###", cul.NumberFormat);

                _cacLoaiBH = double.Parse(insuranceAmount.ToString()).ToString("#,###", cul.NumberFormat);
                _quyCD = double.Parse(_quyCD.ToString()).ToString("#,###", cul.NumberFormat);
                _thueTNCN = double.Parse(info[0].Tax.ToString()).ToString("#,###", cul.NumberFormat);
                _thucLinh = double.Parse(_thucLinh).ToString("#,###", cul.NumberFormat);
                var file = string.Format("{0}\\{1}", Environment.CurrentDirectory, "../../Template/" + "Salary.html");
                string contentEmail = System.IO.File.ReadAllText(file);

                contentEmail = contentEmail.Replace("{tháng}", month.ToString());
                contentEmail = contentEmail.Replace("{Mã nhân viên}", idStaff);
                contentEmail = contentEmail.Replace("{Tên nhân viên}", _staffName);
                contentEmail = contentEmail.Replace("{HĐLD chính thức}", _thuNhapHDCT);
                contentEmail = contentEmail.Replace("{HĐLD thử việc}", _thuNhapHDTV);
                contentEmail = contentEmail.Replace("{Lương cơ bản}", _luongCB);
                contentEmail = contentEmail.Replace("{Ngày công}", _ngayCong);
                contentEmail = contentEmail.Replace("{Ăn ca}", _anCa);
                contentEmail = contentEmail.Replace("{Điện thoại}", _dienThoai);
                contentEmail = contentEmail.Replace("{Xăng xe}", _xangXe);
                contentEmail = contentEmail.Replace("{Khác}", _phuCapKhac);
                contentEmail = contentEmail.Replace("{Các loại bảo hiểm}", _cacLoaiBH);
                contentEmail = contentEmail.Replace("{Quỹ công đoàn}", _quyCD);
                contentEmail = contentEmail.Replace("{Thuế TNCN}", _thueTNCN);
                contentEmail = contentEmail.Replace("{Thực lĩnh}", _thucLinh);

                string emailBody = contentEmail;

                EmailHelper.SendEmail(Model.AppSettings.EmailHost, Model.AppSettings.EmailPort, Model.AppSettings.FromEmail, Model.AppSettings.PasswordEmail,
                    email, "Chi tiết thu nhập tháng " + month, emailBody);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static int countWeekDays(DateTime d0, DateTime d1)
        {
            int ndays = 1 + Convert.ToInt32((d1 - d0).TotalDays);
            int nsaturdays = (ndays + Convert.ToInt32(d0.DayOfWeek)) / 7;
            return ndays - 2 * nsaturdays
                   - (d0.DayOfWeek == DayOfWeek.Sunday ? 1 : 0)
                   + (d1.DayOfWeek == DayOfWeek.Saturday ? 1 : 0);
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
                    gTimeSheets.ExportToXlsx(path);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTimeSheets.RowCount > 0)
            {
                string idStaff = gvTimeSheets.GetFocusedRowCellValue("IDStaff").ToString();
                string idDepartment = gvTimeSheets.GetFocusedRowCellValue("IDDepartment").ToString();
                int month = int.Parse(cbMonth.SelectedItem.ToString().Replace("Tháng ", ""));

                FormInfoTimeSheets infoTimeSheets = new FormInfoTimeSheets();
                infoTimeSheets.IsEdit = true;
                infoTimeSheets.IdStaff = idStaff;
                infoTimeSheets.IdDepartment = idDepartment;
                infoTimeSheets.Month = month;
                infoTimeSheets.Show();
            }
        }
    }
}
