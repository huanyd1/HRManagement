using DevExpress.Utils;
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

namespace HRManagement.Screens.Staff
{
    public partial class FormChangeStaff : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idStaff;
        private bool _isCorrectFormat = false;

        private readonly int numberStringID = 5;

        private readonly string idStaff = "Mã nhân viên";
        private readonly string staffName = "Tên nhân viên";
        private readonly string place = "Địa chỉ";
        private readonly string email = "Địa chỉ Email";
        private readonly string cccd = "Số CCCD";
        private readonly string phonenumber = "Số điện thoại";
        private readonly string numberContract = "Số hợp đồng";
        private readonly string contractName = "Tên hợp đồng";
        private readonly string salaryNumber = "Lương";
        private readonly string allowance = "Phụ cấp";
        private readonly string tax = "Thuế TN";
        private readonly string coefficient = "Hệ số lương";
        private string filename = "";

        public FormChangeStaff()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }
        public bool IsAdd
        {
            get { return _isAdd; }
            set { _isAdd = value; }
        }
        public bool IsInfo
        {
            get { return _isInfo; }
            set { _isInfo = value; }
        }
        public string IdStaff
        {
            get { return _idStaff; }
            set { _idStaff = value; }
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void LoadAllPosition()
        {
            PositionDAO dao = new PositionDAO();
            cbPosition.DataSource = dao.GetAll();
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "IDPosition";
        }

        private void LoadAllContractType()
        {
            ContractTypeDAO dao = new ContractTypeDAO();
            cbContractType.DataSource = dao.GetAll();
            cbContractType.DisplayMember = "TypeName";
            cbContractType.ValueMember = "IDType";
        }

        private void LoadAllSex()
        {
            cbSex.Items.Add("Nam");
            cbSex.Items.Add("Nữ");
        }

        private void LoadAllAcademicLevel()
        {
            AcademicDAO dao = new AcademicDAO();

            cbAcademic.DataSource = dao.GetAll();
            cbAcademic.DisplayMember = "AcademicName";
            cbAcademic.ValueMember = "IDAcademic";
        }

        private void LoadAllSpecialize()
        {
            SpecializeDAO dao = new SpecializeDAO();

            cbSpecialize.DataSource = dao.GetAll();
            cbSpecialize.DisplayMember = "SpecializeName";
            cbSpecialize.ValueMember = "IDSpecialize";
        }

        private void LoadAllNation()
        {
            NationDAO dao = new NationDAO();    
            cbNation.DataSource = dao.GetAll();
            cbNation.DisplayMember = "NationName";
            cbNation.ValueMember = "IDNation";
        }

        private void LoadAllInfoStaff()
        {
            StaffDAO dao = new StaffDAO();
            Model.EF.GetAllInfoByIDStaff_Result staff = dao.GetAllInfoByIDStaff(_idStaff);

            //Thông tin Cơ bản
            txtIDStaff.Text = staff.IDStaff;
            txtStaffName.Text = staff.StaffName;
            cbDepartment.Text = staff.DepartmentName;
            cbPosition.SelectedValue = staff.IDPosition;
            dtimeBirthday.Text = staff.Birthday.ToString();
            txtPlace.Text = staff.Place;
            cbAcademic.SelectedValue = staff.IDAcademic;
            cbSpecialize.SelectedValue = staff.IDSpecialize;

            //Thông tin Chi tiết
            txtEmail.Text = staff.Email;
            txtCCCD.Text = staff.CCCD;
            dtimeDateRange.Text = staff.DateRange.ToString();
            txtIssueBy.Text = staff.IssueBy.ToString();
            cbSex.SelectedText = staff.Sex == "1" ? "Nam" : "Nữ";
            txtPhonenumber.Text = staff.Numberphone;

            //Thông tin Hợp đồng
            txtNumberContract.Text = staff.NumberContract;
            txtContractName.Text = staff.ContractName;
            dtimeStartDate.Text = staff.StartDate.ToString();
            dtimeEndDate.Text = staff.EndDate.ToString();
            cbContractType.SelectedValue = staff.IDType;

            //Thông tin Lương
            txtSalaryAmount.Text = staff.SalaryAmount.ToString();
            txtAllowance.Text = staff.Allowance.ToString();
            txtCoefficient.Text = staff.Coefficient.Value.ToString();
            txtTax.Text = staff.Tax.ToString();

            //Avatar
            try
            {
                picbAvatar.Image = Image.FromFile(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Resource\\Upload\\" + staff.Image);

            }
            catch(Exception ex) { picbAvatar.Image = null;}
        }

        private void FormChangeStaff_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            txtIDStaff.Focus();

            dtimeBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeDateRange.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtimeEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            LoadAllDepartment();
            LoadAllPosition();
            LoadAllSex();
            LoadAllContractType();
            LoadAllAcademicLevel();
            LoadAllSpecialize();
            LoadAllNation();

            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Nhân viên");
                txtIDStaff.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                LoadAllInfoStaff();

                txtNumberContract.ReadOnly = true;
                txtContractName.ReadOnly = true;
                dtimeStartDate.Enabled = false;
                dtimeEndDate.Enabled = false;
                cbContractType.Enabled = false;

                txtSalaryAmount.ReadOnly = true;
                txtAllowance.ReadOnly = true;
                txtTax.ReadOnly = true;

                if (_isInfo)
                {
                    txtIDStaff.ReadOnly = true;
                    txtStaffName.ReadOnly = true;
                    cbDepartment.Enabled = false;
                    cbPosition.Enabled = false;
                    dtimeBirthday.Enabled = false;
                    txtPlace.ReadOnly = true;

                    txtEmail.ReadOnly = true;
                    txtCCCD.ReadOnly = true;
                    cbSex.Enabled = false;
                    txtPhonenumber.ReadOnly = true;

                    cbNation.Enabled = false;
                    cbSpecialize.Enabled = false;
                    cbAcademic.Enabled = false;
                    dtimeDateRange.Enabled = false;
                    txtIssueBy.ReadOnly = true;
                    txtCoefficient.ReadOnly = true;

                    btnSave.Visible = false;
                    btnChangeAvatar.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Nhân viên");
                }

            }
            else
            {
                ContractDAO dao = new ContractDAO();
                var contract = dao.GetSingleByID(IdStaff);

                string numberContractStaff = contract.NumberContract.Replace("CT/", "").Replace("TV/", "").Replace("TTS/", "");
                int numberZeroContract = numberStringID - int.Parse(numberContractStaff);
                string stringZeroContract = "";
                for (int i = 0; i < numberZeroContract; i++)
                {
                    stringZeroContract = stringZeroContract + "0";
                }
                txtNumberContract.Text = stringZeroContract + (int.Parse(numberContractStaff) + 1).ToString();

                int numberZero = numberStringID - IdStaff.Replace("VP", "").Length;
                string stringZero = "";

                for(int i = 0; i < numberZero; i++)
                {
                    stringZero = stringZero + "0";
                }

                IdStaff = "VP" + stringZero + (int.Parse(IdStaff.Replace("VP", "") + 1).ToString());              
                txtIDStaff.Text = IdStaff.ToString();
                this.Text = Model.ActionCommon.AddAction("Nhân viên");
                btnSave.Text = "Thêm mới";
                txtIDStaff.ReadOnly = true;
                txtNumberContract.ReadOnly = true;
                txtContractName.ReadOnly = true;

                cbSex.SelectedText = "Nam";
                dtimeBirthday.Text = DateTime.Now.ToString();
                dtimeDateRange.Text = DateTime.Now.ToString();
                dtimeStartDate.Text = DateTime.Now.ToString();
                DateTime dt = DateTime.Now;
                DateTime newDt = new DateTime(DateTime.Now.Year + 1, dt.Month, dt.Day);
                dtimeEndDate.Text = newDt.ToString();
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            #region CheckError

            if (txtIDStaff.Text == string.Empty)
            {
                errorIDStaff.SetError(txtIDStaff, Model.CheckVariableCommon.NullVariable(idStaff));
                flag = false;
            }
            else
            {
                errorIDStaff.SetError(txtIDStaff, null);
            }

            if (txtStaffName.Text == string.Empty)
            {
                errorStaffName.SetError(txtStaffName, Model.CheckVariableCommon.NullVariable(staffName));
                flag = false;
            }
            else
            {
                errorStaffName.SetError(txtStaffName, null);
            }

            if (txtPlace.Text == string.Empty)
            {
                errorPlace.SetError(txtPlace, Model.CheckVariableCommon.NullVariable(place));
                flag = false;
            }
            else
            {
                errorPlace.SetError(txtPlace, null);
            }

            if (txtEmail.Text == string.Empty)
            {
                errorEmail.SetError(txtEmail, Model.CheckVariableCommon.NullVariable(email));
                flag = false;
            }
            else
            {
                errorEmail.SetError(txtEmail, null);
            }

            if (txtCCCD.Text == string.Empty)
            {
                errorCCCD.SetError(txtCCCD, Model.CheckVariableCommon.NullVariable(cccd));
                flag = false;
            }
            else
            {
                errorCCCD.SetError(txtCCCD, null);
            }

            if (txtPhonenumber.Text == string.Empty)
            {
                errorPhonenumber.SetError(txtPhonenumber, Model.CheckVariableCommon.NullVariable(phonenumber));
                flag = false;
            }
            else
            {
                errorPhonenumber.SetError(txtPhonenumber, null);
            }

            if (txtNumberContract.Text == string.Empty)
            {
                errorNumberContract.SetError(txtNumberContract, Model.CheckVariableCommon.NullVariable(numberContract));
                flag = false;
            }
            else
            {
                errorNumberContract.SetError(txtNumberContract, null);
            }

            if (txtContractName.Text == string.Empty)
            {
                errorContractName.SetError(txtContractName, Model.CheckVariableCommon.NullVariable(contractName));
                flag = false;
            }
            else
            {
                errorContractName.SetError(txtContractName, null);
            }

            if (txtSalaryAmount.Text == string.Empty)
            {
                errorSalary.SetError(txtSalaryAmount, Model.CheckVariableCommon.NullVariable(salaryNumber));
                flag = false;
            }
            else
            {
                errorContractName.SetError(txtSalaryAmount, null);
            }

            if (txtAllowance.Text == string.Empty)
            {
                errorAllowance.SetError(txtAllowance, Model.CheckVariableCommon.NullVariable(allowance));
                flag = false;
            }
            else
            {
                errorAllowance.SetError(txtAllowance, null);
            }

            if (txtTax.Text == string.Empty)
            {
                errorTax.SetError(txtTax, Model.CheckVariableCommon.NullVariable(tax));
                flag = false;
            }
            else
            {
                errorTax.SetError(txtTax, null);
            }

            #endregion

            return flag;
        }

        public Model.EF.Staff GetInfoStaff()
        {
            Model.EF.Staff staff = new Model.EF.Staff();
            staff.IDStaff = txtIDStaff.Text;
            staff.StaffName = txtStaffName.Text;
            staff.IDDepartment = cbDepartment.SelectedValue.ToString();
            staff.IDPosition = cbPosition.SelectedValue.ToString();
            staff.Birthday = DateTime.Parse(dtimeBirthday.Text.ToString());
            staff.Place = txtPlace.Text;

            staff.Email = txtEmail.Text + lbEmail.Text;
            staff.CCCD = txtCCCD.Text;
            staff.DateRange = DateTime.Parse(dtimeDateRange.Text.ToString());
            staff.IssueBy = txtIssueBy.Text;

            staff.IDNation = int.Parse(cbNation.SelectedValue.ToString());
            staff.IDAcademic = int.Parse(cbAcademic.SelectedValue.ToString());
            staff.IDSpecialize = int.Parse(cbSpecialize.SelectedValue.ToString());

            staff.Sex = cbSex.Text == "Nam" ? "1" : "0";
            staff.Numberphone = txtPhonenumber.Text;

            staff.Image = filename == "" ? "" : filename;

            staff.IDStaff = txtIDStaff.Text;
             
            staff.StartDate = DateTime.Parse(dtimeStartDate.Text.ToString());
            staff.EndDate = DateTime.Parse(dtimeEndDate.Text.ToString());

            staff.Status = "1";

            return staff;
        }

        public Model.EF.Contract GetInfoContract()
        {
            Model.EF.Contract contract = new Model.EF.Contract();
            contract.IDStaff = txtIDStaff.Text;
            contract.NumberContract = lbNumberContract.Text + txtNumberContract.Text;
            contract.ContractName = txtContractName.Text;
            contract.IDType = cbContractType.SelectedValue.ToString();

            return contract;
        }

        public Model.EF.Salary GetInfoSalary()
        {
            Model.EF.Salary salary = new Model.EF.Salary();
            salary.IDStaff = txtIDStaff.Text;
            salary.SalaryAmount = int.Parse(txtSalaryAmount.Text);
            salary.Allowance = int.Parse(txtAllowance.Text);
            salary.Tax = int.Parse(txtTax.Text);

            try
            {
                salary.Coefficient = double.Parse(txtCoefficient.Text.ToString());
                errorCoefficient.SetError(txtCoefficient, null);
                _isCorrectFormat = true;
            }
            catch (Exception ex)
            {
                errorCoefficient.SetError(txtCoefficient, Model.CheckVariableCommon.NullVariable(coefficient));
                _isCorrectFormat = false;
            }

            return salary;
        }

        public Model.EF.Account GetInfoAccount()
        {
            Model.EF.Account account = new Model.EF.Account();
            account.IDStaff = txtIDStaff.Text;
            account.Username = txtEmail.Text;
            account.Password = Model.ResetPassword.RandomString(6);
            account.Type = "4";

            return account;
        }

        private void SendEmailAddStaff(string email, string subject, string username, string password)
        {
            var file = string.Format("{0}\\{1}", Environment.CurrentDirectory, "../../Template/" + "AddStaff.html");
            string contentEmail = System.IO.File.ReadAllText(file);


            contentEmail = contentEmail.Replace("{username}", username);
            contentEmail = contentEmail.Replace("{password}", password);


            string emailBody = contentEmail;

            EmailHelper.SendEmail(Model.AppSettings.EmailHost, Model.AppSettings.EmailPort, Model.AppSettings.FromEmail, Model.AppSettings.PasswordEmail,
                email, subject, emailBody);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable() && !_isCorrectFormat)
            {
                return;
            }

            StaffDAO dao = new StaffDAO();

            Model.EF.Staff staff = GetInfoStaff();
            Model.EF.Contract contract = GetInfoContract();
            Model.EF.Salary salary = GetInfoSalary();
            Model.EF.Account account = GetInfoAccount();

            if (_isAdd)
            {
                if (dao.IsExitStaff(txtCCCD.Text))
                {
                    DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExistVariable(cccd), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (dao.Add(staff, contract, salary, account))
                        {
                            SendEmailAddStaff(account.Username, "Thông tin tài khoản " + account.Username,account.Username, account.Password);
                            _isSave = true;
                        }
                    }
                }
                else
                {
                    if (dao.Add(staff, contract, salary, account))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(staff))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Nhân viên");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Nhân viên");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtIDStaff.Text != string.Empty || txtStaffName.Text != string.Empty) && _isInfo == false)
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.ExitForm(), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
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
                        System.IO.File.Copy(openFile.FileName, path + "\\Resource\\Upload\\" + filename);
                        picbAvatar.Image = Image.FromFile(path + "\\Resource\\Upload\\" + filename);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbContractType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbContractType.SelectedValue.ToString() != "")
            {
                string value = cbContractType.Text.ToString();

                if (value == "Chính thức")
                {
                    lbNumberContract.Text = "CT/";
                    txtContractName.Text = "Hợp đồng chính thức";
                }
                else if(value == "Thử việc")
                {
                    lbNumberContract.Text = "TV/";
                    txtContractName.Text = "Hợp đồng thử việc";
                }
                else if(value == "Thực tập sinh")
                {
                    lbNumberContract.Text = "TTS/";
                    txtContractName.Text = "Hợp đồng thực tập";
                }
            }
        }
    }
}