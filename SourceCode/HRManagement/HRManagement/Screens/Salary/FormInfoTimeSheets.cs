using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.Salary
{
    public partial class FormInfoTimeSheets : DevExpress.XtraEditors.XtraForm
    {
        private string _idStaff;
        private int _month;
        private string _idDepartment;
        private int _dayInMonth = 0;
        private bool _isEdit = false;

        private int anCa = 800000;
        private int xangXe = 200000;
        private int quyCD = 50000;
        private int luongCB = 5300000;

        public FormInfoTimeSheets()
        {
            InitializeComponent();
        }

        public string IdStaff
        {
            set { _idStaff = value; }
        }
        public int Month
        {
            set { _month = value; }
        }
        public string IdDepartment
        {
            set { _idDepartment = value; }
        }

        public bool IsEdit
        {
            set { _isEdit = value; }
        }

        private void LoadInfoTimeSheets()
        {
            if (_isEdit)
            {
                txtBonus.ReadOnly = false;
                btnSave.Visible = true;
            }

            SalaryDAO dao = new SalaryDAO();
            StaffDAO staff = new StaffDAO();
            List<Model.EF.GetTimeSheetsByMonthAndIDStaff_Result> info = dao.GetTimeSheetsByMonthAndIDStaff(_idDepartment, _month, _idStaff);

            var coefficient = info[0].Coefficient == null ? 1 : info[0].Coefficient;
            var bonus = info[0].Bonus == null ? 0 : info[0].Bonus;

            int insuranceAmount = 0;
            foreach(var item in info)
            {
                insuranceAmount += int.Parse(item.Amount.ToString());
            }

            txtIDStaff.Text = _idStaff;
            txtStaffName.Text = staff.GetStaffNameByID(_idStaff);

            txtThuNhapHDCT.Text = info[0].SalaryAmount.ToString(); 
            txtTNHDTV.Text = ((info[0].SalaryAmount / 100) * 80).ToString();
            txtLuongCB.Text = luongCB.ToString();
            txtNgayCong.Text = info[0].TotalTime.ToString();
            txtBonus.Text = info[0].Bonus == null ? "0" : info[0].Bonus.ToString();
            txtAnCa.Text = anCa.ToString();
            txtDienThoai.Text = "0";
            txtXangXe.Text = xangXe.ToString();
            txtPhuCapKhac.Text = info[0].Allowance.ToString();

            txtCacLoaiBH.Text = insuranceAmount.ToString();
            txtQuyCD.Text = quyCD.ToString();
            txtThueTNCN.Text = info[0].Tax.ToString();
            txtThucLinh.Text = (((((info[0].SalaryAmount / _dayInMonth) * info[0].TotalTime) + anCa + xangXe + info[0].Allowance) - (insuranceAmount + quyCD + info[0].Tax) * coefficient) + bonus).ToString();
        }

        private void EnableAllText()
        {
            txtIDStaff.ReadOnly = true;
            txtStaffName.ReadOnly = true;

            txtThuNhapHDCT.ReadOnly = true;
            txtTNHDTV.ReadOnly = true;
            txtLuongCB.ReadOnly = true;
            txtNgayCong.ReadOnly = true;
            txtBonus.ReadOnly = true;
            txtAnCa.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtXangXe.ReadOnly = true;
            txtPhuCapKhac.ReadOnly = true;

            txtCacLoaiBH.ReadOnly = true;
            txtQuyCD.ReadOnly = true;
            txtThueTNCN.ReadOnly = true;
            txtThucLinh.ReadOnly = true;
        }

        private void FormInfoTimeSheets_Load(object sender, EventArgs e)
        {
            this.Text = Model.ActionCommon.InfoAction("Bảng lương");
            var countDay = DateTime.DaysInMonth(DateTime.Now.Year, _month);
            string dayInMonth = countDay.ToString();
            var endOfMonth = Convert.ToDateTime(string.Format(_month + "/" + dayInMonth + "/" + DateTime.Now.Year.ToString()));
            var startOfMonth = Convert.ToDateTime(string.Format(_month + "/" + "01" + "/" + DateTime.Now.Year.ToString()));
            _dayInMonth = countWeekDays(startOfMonth, endOfMonth);

            EnableAllText();
            LoadInfoTimeSheets();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
            txt.Text = String.Format(culture, "{0:N0}", value);
            txt.Select(txt.Text.Length, 0);
        }

        public static int countWeekDays(DateTime d0, DateTime d1)
        {
            int ndays = 1 + Convert.ToInt32((d1 - d0).TotalDays);
            int nsaturdays = (ndays + Convert.ToInt32(d0.DayOfWeek)) / 7;
            return ndays - 2 * nsaturdays
                   - (d0.DayOfWeek == DayOfWeek.Sunday ? 1 : 0)
                   + (d1.DayOfWeek == DayOfWeek.Saturday ? 1 : 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int bonus = int.Parse(txtBonus.Text.ToString());
            TimekeepingDAO dao = new TimekeepingDAO();
            bool result = dao.AddBonus(_idStaff, _month, bonus);
            if (result)
            {
                MessageBox.Show("Thêm mới thưởng lương thành công");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}