using Model.DAO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.ImportData
{
    public class ImportStaff
    {
        public bool ImportDataStaff(string fileName, out List<string> lstError)
        {
            lstError = new List<string>();
            List<int> lstRowError = new List<int>();
            List<Model.EF.Staff> lstStaff = new List<Model.EF.Staff>();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (var package = new ExcelPackage(fileName))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                if (worksheet.Dimension != null)
                {
                    var rowCount = worksheet.Dimension.Rows;

                    // validate header
                    for (int row = 1; row <= 1; row++)
                    {
                        string rowNoheader = worksheet.Cells[row, 1].Value != null ? worksheet.Cells[row, 1].Value.ToString().Trim() : string.Empty; // stt
                        string idStaff = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                        string staffName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string departmentName = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string position = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string birthday = worksheet.Cells[row, 6].Value != null ? worksheet.Cells[row, 6].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string address = worksheet.Cells[row, 7].Value != null ? worksheet.Cells[row, 7].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string nationName = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string academicName = worksheet.Cells[row, 9].Value != null ? worksheet.Cells[row, 9].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string specializeName = worksheet.Cells[row, 10].Value != null ? worksheet.Cells[row, 10].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string email = worksheet.Cells[row, 11].Value != null ? worksheet.Cells[row, 11].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string cccd = worksheet.Cells[row, 12].Value != null ? worksheet.Cells[row, 12].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string dateIssue = worksheet.Cells[row, 13].Value != null ? worksheet.Cells[row, 13].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string issueBy = worksheet.Cells[row, 14].Value != null ? worksheet.Cells[row, 14].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string sex = worksheet.Cells[row, 15].Value != null ? worksheet.Cells[row, 15].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string numberPhone = worksheet.Cells[row, 16].Value != null ? worksheet.Cells[row, 16].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string typeContractName = worksheet.Cells[row, 17].Value != null ? worksheet.Cells[row, 17].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string contractNumber = worksheet.Cells[row, 18].Value != null ? worksheet.Cells[row, 18].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string contractName = worksheet.Cells[row, 19].Value != null ? worksheet.Cells[row, 19].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string startDate = worksheet.Cells[row, 20].Value != null ? worksheet.Cells[row, 20].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string endDate = worksheet.Cells[row, 21].Value != null ? worksheet.Cells[row, 21].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string salary = worksheet.Cells[row, 22].Value != null ? worksheet.Cells[row, 22].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string allowance = worksheet.Cells[row, 23].Value != null ? worksheet.Cells[row, 23].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string tax = worksheet.Cells[row, 24].Value != null ? worksheet.Cells[row, 24].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string coefficient = worksheet.Cells[row, 25].Value != null ? worksheet.Cells[row, 25].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string username = worksheet.Cells[row, 26].Value != null ? worksheet.Cells[row, 26].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                        string errorHeader = ValidateHeader(rowNoheader, idStaff, staffName, departmentName, position, birthday, address, nationName, academicName, 
                            specializeName, email, cccd, dateIssue, issueBy, sex, numberPhone, typeContractName, contractNumber, contractName, startDate, endDate, 
                            salary, allowance, tax, coefficient, username);
                        if (!string.IsNullOrEmpty(errorHeader))
                        {
                            string dataError = RemoveLastCharacter(errorHeader);
                            if (!string.IsNullOrEmpty(dataError))
                            {
                                foreach (var itmError in dataError.Split(','))
                                {
                                    lstError.Add(string.Format("Dòng: {0}, Cột {1} - Lỗi {2}", row, itmError, ValidHeaderResidence.dctImportData[int.Parse(itmError)]));
                                }
                                lstRowError.Add(row);
                            }
                        }
                    }

                    int rowCountBody = 1;
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string rowNoheaders = worksheet.Cells[row, 1].Value != null ? worksheet.Cells[row, 1].Value.ToString().Trim() : string.Empty; // stt
                        string idStaffs = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                        string staffNames = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string departmentNames = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string positions = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string birthdays = worksheet.Cells[row, 6].Value != null ? worksheet.Cells[row, 6].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string addresses = worksheet.Cells[row, 7].Value != null ? worksheet.Cells[row, 7].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string nationNames = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string academicNames = worksheet.Cells[row, 9].Value != null ? worksheet.Cells[row, 9].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string specializeNames = worksheet.Cells[row, 10].Value != null ? worksheet.Cells[row, 10].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string emails = worksheet.Cells[row, 11].Value != null ? worksheet.Cells[row, 11].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string cccds = worksheet.Cells[row, 12].Value != null ? worksheet.Cells[row, 12].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string dateIssues = worksheet.Cells[row, 13].Value != null ? worksheet.Cells[row, 13].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string issueByes = worksheet.Cells[row, 14].Value != null ? worksheet.Cells[row, 14].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string sexs = worksheet.Cells[row, 15].Value != null ? worksheet.Cells[row, 15].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string numberPhones = worksheet.Cells[row, 16].Value != null ? worksheet.Cells[row, 16].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string typeContractNames = worksheet.Cells[row, 17].Value != null ? worksheet.Cells[row, 17].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string contractNumbers = worksheet.Cells[row, 18].Value != null ? worksheet.Cells[row, 18].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string contractNames = worksheet.Cells[row, 19].Value != null ? worksheet.Cells[row, 19].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string startDates = worksheet.Cells[row, 20].Value != null ? worksheet.Cells[row, 20].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string endDates = worksheet.Cells[row, 21].Value != null ? worksheet.Cells[row, 21].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string salarys = worksheet.Cells[row, 22].Value != null ? worksheet.Cells[row, 22].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string allowances = worksheet.Cells[row, 23].Value != null ? worksheet.Cells[row, 23].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string taxs = worksheet.Cells[row, 24].Value != null ? worksheet.Cells[row, 24].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string coefficients = worksheet.Cells[row, 25].Value != null ? worksheet.Cells[row, 25].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string usernames = worksheet.Cells[row, 26].Value != null ? worksheet.Cells[row, 26].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                        bool errorDataBeforeCheck = ValidateBeforeFileEmpty(rowNoheaders, idStaffs, staffNames, departmentNames, positions,
                                                                            birthdays, addresses, nationNames, academicNames, specializeNames,
                                                                            emails, cccds, dateIssues, issueByes, sexs, numberPhones, typeContractNames,
                                                                            contractNumbers, contractNames, startDates, endDates, salarys, allowances, taxs, coefficients, usernames);

                        if (errorDataBeforeCheck)
                        {
                            string idStaff = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                            string staffName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string departmentName = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string position = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string birthday = worksheet.Cells[row, 6].Value != null ? worksheet.Cells[row, 6].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string address = worksheet.Cells[row, 7].Value != null ? worksheet.Cells[row, 7].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string nationName = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string academicName = worksheet.Cells[row, 9].Value != null ? worksheet.Cells[row, 9].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string specializeName = worksheet.Cells[row, 10].Value != null ? worksheet.Cells[row, 10].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string email = worksheet.Cells[row, 11].Value != null ? worksheet.Cells[row, 11].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string cccd = worksheet.Cells[row, 12].Value != null ? worksheet.Cells[row, 12].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string dateIssue = worksheet.Cells[row, 13].Value != null ? worksheet.Cells[row, 13].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string issueBy = worksheet.Cells[row, 14].Value != null ? worksheet.Cells[row, 14].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string sex = worksheet.Cells[row, 15].Value != null ? worksheet.Cells[row, 15].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string numberPhone = worksheet.Cells[row, 16].Value != null ? worksheet.Cells[row, 16].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string typeContractName = worksheet.Cells[row, 17].Value != null ? worksheet.Cells[row, 17].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string contractNumber = worksheet.Cells[row, 18].Value != null ? worksheet.Cells[row, 18].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string contractName = worksheet.Cells[row, 19].Value != null ? worksheet.Cells[row, 19].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string startDate = worksheet.Cells[row, 20].Value != null ? worksheet.Cells[row, 20].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string endDate = worksheet.Cells[row, 21].Value != null ? worksheet.Cells[row, 21].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string salaryAmount = worksheet.Cells[row, 22].Value != null ? worksheet.Cells[row, 22].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string allowance = worksheet.Cells[row, 23].Value != null ? worksheet.Cells[row, 23].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string tax = worksheet.Cells[row, 24].Value != null ? worksheet.Cells[row, 24].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string coefficient = worksheet.Cells[row, 25].Value != null ? worksheet.Cells[row, 25].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string username = worksheet.Cells[row, 26].Value != null ? worksheet.Cells[row, 26].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                            bool errorDataEmpty = ValidateFileEmpty(idStaff, staffName, departmentName, position, birthday, address, nationName, academicName,
                                specializeName, email, cccd, dateIssue, issueBy, sex, numberPhone, typeContractName, contractNumber, contractName, startDate, 
                                endDate, salaryAmount, allowance, tax, coefficient, username);

                            if (!errorDataEmpty)
                            {
                                string errorData = ValidateImportData(idStaff, staffName, departmentName, position, birthday, address, nationName, academicName,
                                specializeName, email, cccd, dateIssue, issueBy, sex, numberPhone, typeContractName, contractNumber, contractName, startDate,
                                endDate, salaryAmount, allowance, tax, coefficient, username);
                                if (!string.IsNullOrEmpty(errorData))
                                {
                                    string dataError = RemoveLastCharacter(errorData);
                                    if (!string.IsNullOrEmpty(dataError))
                                    {
                                        foreach (var itmError in dataError.Split(','))
                                        {
                                            lstError.Add(string.Format("Dòng: {0}, Cột {1} - Lỗi {2}", row, itmError, ImportEmptyResidence.dctImportData[int.Parse(itmError)]));
                                        }
                                        lstRowError.Add(row);
                                    }
                                }
                            }
                            else
                            {
                                StaffDAO staffDAO = new StaffDAO();
                                var isExist = staffDAO.IsExitStaff(idStaff);

                                DepartmentDAO departmentDAO = new DepartmentDAO();
                                string idDepartment = departmentDAO.GetDepartmentIDByName(departmentName);

                                PositionDAO positionDAO = new PositionDAO();
                                string idPosition = positionDAO.GetPositionIDByName(position);

                                NationDAO nationDAO = new NationDAO();
                                int idNation = nationDAO.GetIDNationByName(nationName);

                                AcademicDAO academicDAO = new AcademicDAO();
                                int idAcademic = academicDAO.GetIDAcademicByName(academicName);

                                SpecializeDAO specializeDAO = new SpecializeDAO();
                                int idSpecialize = specializeDAO.GetIDSpecializeByName(specializeName);

                                ContractTypeDAO contractTypeDAO = new ContractTypeDAO();
                                string idType = contractTypeDAO.GetIDContractTypeByName(typeContractName);

                                if (!isExist && string.IsNullOrEmpty(idDepartment) && string.IsNullOrEmpty(idPosition)
                                    && string.IsNullOrEmpty(idNation.ToString()) && string.IsNullOrEmpty(idAcademic.ToString())
                                    && string.IsNullOrEmpty(idSpecialize.ToString()))
                                {
                                    Model.EF.Staff staff = new Model.EF.Staff();
                                    staff.IDStaff = idStaff;
                                    staff.StaffName = staffName;
                                    staff.Sex = sex == "Nam" ? "1" : "0";
                                    staff.Birthday = DateTime.Parse(birthday.ToString());
                                    staff.Place = address;
                                    staff.CCCD = cccd;
                                    staff.DateRange = DateTime.Parse(dateIssue.ToString());
                                    staff.IssueBy = issueBy;
                                    staff.IDNation = idNation;
                                    staff.IDAcademic = idAcademic;
                                    staff.IDSpecialize = idSpecialize;
                                    staff.Numberphone = numberPhone;
                                    staff.Email = email;
                                    staff.IDDepartment = idDepartment;
                                    staff.IDPosition = position;
                                    staff.StartDate = DateTime.Parse(startDate);
                                    staff.EndDate = DateTime.Parse(endDate);
                                    staff.Status = "1";

                                    Model.EF.Contract contract = new Model.EF.Contract();
                                    contract.IDStaff = idStaff;
                                    contract.NumberContract = contractNumber;
                                    contract.ContractName = contractName;
                                    contract.IDType = idType;

                                    Model.EF.Salary salary = new Model.EF.Salary();
                                    salary.IDStaff = idStaff;
                                    salary.SalaryAmount = int.Parse(salaryAmount);
                                    salary.Allowance = int.Parse(allowance);
                                    salary.Tax = int.Parse(tax);
                                    salary.Coefficient = int.Parse(coefficient);

                                    Model.EF.Account account = new Model.EF.Account();
                                    account.IDStaff = idStaff;
                                    account.Username = username;
                                    account.Password = Model.ResetPassword.RandomString(6);
                                    account.Type = "4";

                                    StaffDAO staffDao = new StaffDAO();
                                    staffDao.Add(staff, contract, salary, account);
                                }
                            }
                        }
                        else
                        {
                            rowCountBody++;
                        }
                    }                                 

                    if (rowCountBody == rowCount)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private string ValidateHeader(string stt, string idStaff, string staffName, string departmentName, string position, string birthday, string address, string nationName, string academicName,
                           string specializeName, string email, string cccd, string dateIssue, string issueBy, string sex, string numberPhone, string typeContractName, string contractNumber, 
                           string contractName, string startDate, string endDate, string salary, string allowance, string tax, string coefficient, string username)
        {
            string result = string.Empty;

            if (!stt.Equals("STT"))
            {
                result += "1,";
            }
            if (!idStaff.Equals("Mã nhân viên*"))
            {
                result += "2,";
            }
            if (!staffName.Equals("Tên nhân viên*"))
            {
                result += "3,";
            }
            if (!departmentName.Equals("Phòng ban*"))
            {
                result += "4,";
            }
            if (!position.Equals("Vị trí*"))
            {
                result += "5,";
            }
            if (!birthday.Equals("Ngày sinh"))
            {
                result += "6,";
            }
            if (!address.Equals("Địa chỉ"))
            {
                result += "7,";
            }
            if (!nationName.Equals("Dân tộc*"))
            {
                result += "8,";
            }
            if (!academicName.Equals("Học vấn*"))
            {
                result += "9,";
            }
            if (!specializeName.Equals("Chuyên môn*"))
            {
                result += "10,";
            }
            if (!email.Equals("Email*"))
            {
                result += "11,";
            }
            if (!cccd.Equals("Số CCCD"))
            {
                result += "12,";
            }
            if (!dateIssue.Equals("Ngày cấp"))
            {
                result += "13,";
            }
            if (!issueBy.Equals("Nơi cấp"))
            {
                result += "14,";
            }
            if (!sex.Equals("Giới tính"))
            {
                result += "15,";
            }
            if (!numberPhone.Equals("Số ĐT"))
            {
                result += "16,";
            }
            if (!typeContractName.Equals("Loại HĐ"))
            {
                result += "17,";
            }
            if (!contractNumber.Equals("Số HĐ"))
            {
                result += "18,";
            }
            if (!contractName.Equals("Tên HĐ"))
            {
                result += "19,";
            }
            if (!startDate.Equals("Ngày BĐ"))
            {
                result += "20,";
            }
            if (!endDate.Equals("Ngày HH"))
            {
                result += "21,";
            }
            if (!salary.Equals("Lương"))
            {
                result += "22,";
            }
            if (!allowance.Equals("Phụ cấp"))
            {
                result += "23,";
            }
            if (!tax.Equals("Thuế TN"))
            {
                result += "24,";
            }
            if (!coefficient.Equals("HS Lương"))
            {
                result += "25,";
            }
            if (!username.Equals("Tài khoản*"))
            {
                result += "26,";
            }

            return result;
        }

        private bool ValidateBeforeFileEmpty(string stt, string idStaff, string staffName, string departmentName, string position, string birthday, string address, string nationName, string academicName,
                           string specializeName, string email, string cccd, string dateIssue, string issueBy, string sex, string numberPhone, string typeContractName, string contractNumber,
                           string contractName, string startDate, string endDate, string salary, string allowance, string tax, string coefficient, string username)
        {
            bool result = true;
            if (string.IsNullOrEmpty(stt) && string.IsNullOrEmpty(idStaff) && string.IsNullOrEmpty(staffName) && string.IsNullOrEmpty(departmentName) && string.IsNullOrEmpty(position)
                && string.IsNullOrEmpty(birthday) && string.IsNullOrEmpty(address) && string.IsNullOrEmpty(nationName) && string.IsNullOrEmpty(academicName) && string.IsNullOrEmpty(specializeName)
                && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(cccd) && string.IsNullOrEmpty(dateIssue) && string.IsNullOrEmpty(issueBy) && string.IsNullOrEmpty(sex)
                && string.IsNullOrEmpty(numberPhone) && string.IsNullOrEmpty(typeContractName) && string.IsNullOrEmpty(contractNumber) && string.IsNullOrEmpty(contractName) && string.IsNullOrEmpty(startDate)
                && string.IsNullOrEmpty(endDate) && string.IsNullOrEmpty(salary) && string.IsNullOrEmpty(allowance) && string.IsNullOrEmpty(tax) && string.IsNullOrEmpty(coefficient) && string.IsNullOrEmpty(username))
            {
                result = false;
            }

            return result;
        }

        private string ValidateImportData(string idStaff, string staffName, string departmentName, string position, string birthday, string address, string nationName, string academicName,
                           string specializeName, string email, string cccd, string dateIssue, string issueBy, string sex, string numberPhone, string typeContractName, string contractNumber,
                           string contractName, string startDate, string endDate, string salary, string allowance, string tax, string coefficient, string username)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(idStaff))
            {
                result += "2,";
            }
            if (string.IsNullOrEmpty(staffName))
            {
                result += "3,";
            }
            if (string.IsNullOrEmpty(departmentName))
            {
                result += "4,";
            }
            if (string.IsNullOrEmpty(position))
            {
                result += "5,";
            }
            if (string.IsNullOrEmpty(birthday))
            {
                result += "6,";
            }
            if (string.IsNullOrEmpty(address))
            {
                result += "7,";
            }
            if (string.IsNullOrEmpty(nationName))
            {
                result += "8,";
            }
            if (string.IsNullOrEmpty(academicName))
            {
                result += "9,";
            }
            if (string.IsNullOrEmpty(specializeName))
            {
                result += "10,";
            }
            if (string.IsNullOrEmpty(email))
            {
                result += "11,";
            }
            if (string.IsNullOrEmpty(cccd))
            {
                result += "12,";
            }
            if (string.IsNullOrEmpty(dateIssue))
            {
                result += "13,";
            }
            if (string.IsNullOrEmpty(issueBy))
            {
                result += "14,";
            }
            if (string.IsNullOrEmpty(sex))
            {
                result += "15,";
            }
            if (string.IsNullOrEmpty(numberPhone))
            {
                result += "16,";
            }
            if (string.IsNullOrEmpty(typeContractName))
            {
                result += "17,";
            }
            if (string.IsNullOrEmpty(contractNumber))
            {
                result += "18,";
            }
            if (string.IsNullOrEmpty(contractName))
            {
                result += "19,";
            }
            if (string.IsNullOrEmpty(startDate))
            {
                result += "20,";
            }
            if (string.IsNullOrEmpty(endDate))
            {
                result += "21,";
            }
            if (string.IsNullOrEmpty(salary))
            {
                result += "22,";
            }
            if (string.IsNullOrEmpty(allowance))
            {
                result += "23,";
            }
            if (string.IsNullOrEmpty(tax))
            {
                result += "24,";
            }
            if (string.IsNullOrEmpty(coefficient))
            {
                result += "25,";
            }
            if (string.IsNullOrEmpty(username))
            {
                result += "26,";
            }

            return result;
        }

        private bool ValidateFileEmpty(string idStaff, string staffName, string departmentName, string position, string birthday, string address, string nationName, string academicName,
                           string specializeName, string email, string cccd, string dateIssue, string issueBy, string sex, string numberPhone, string typeContractName, string contractNumber,
                           string contractName, string startDate, string endDate, string salary, string allowance, string tax, string coefficient, string username)
        {
            bool result = true;
            if (string.IsNullOrEmpty(idStaff) || string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(staffName)
                || string.IsNullOrEmpty(nationName) || string.IsNullOrEmpty(academicName) || string.IsNullOrEmpty(specializeName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cccd)
                || string.IsNullOrEmpty(dateIssue) || string.IsNullOrEmpty(issueBy) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(numberPhone) || string.IsNullOrEmpty(typeContractName)
                || string.IsNullOrEmpty(contractNumber) || string.IsNullOrEmpty(contractName) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate) || string.IsNullOrEmpty(salary)
                || string.IsNullOrEmpty(allowance) || string.IsNullOrEmpty(tax) || string.IsNullOrEmpty(coefficient) || string.IsNullOrEmpty(username))
            {
                result = false;
            }
            return result;
        }

        public static string RemoveLastCharacter(string value)
        {
            return !string.IsNullOrEmpty(value) ? value.Substring(0, value.Length - 1) : string.Empty;
        }

        public class ValidHeaderResidence
        {
            public const string Stt = "Sai định dạng tiêu dề Stt";
            public const string idStaff = "Sai định dạng tiêu đề mã nhân viên";
            public const string staffName = "Sai định dạng tiêu đề tên nhân viên";
            public const string departmentName = "Sai định dạng tiêu đề tên phòng ban";
            public const string position = "Sai định dạng tiêu đề vị trí";
            public const string birthday = "Sai định dạng tiêu đề ngày sinh";
            public const string address = "Sai định dạng tiêu đề địa chỉ";
            public const string nationName = "Sai định dạng tiêu đề dân tộc";
            public const string academicName = "Sai định dạng tiêu đề học vấn";
            public const string specializeName = "Sai định dạng tiêu đề trình độ chuyên môn";
            public const string email = "Sai định dạng tiêu đề email";
            public const string cccd = "Sai định dạng tiêu đề số cccd";
            public const string dateIssue = "Sai định dạng tiêu đề ngày cấp";
            public const string issueBy = "Sai định dạng tiêu đề nơi cấp";
            public const string sex = "Sai định dạng tiêu đề giới tính";
            public const string numberPhone = "Sai định dạng tiêu đề số đt";
            public const string typeContractName = "Sai định dạng tiêu đề loại hợp đồng";
            public const string contractNumber = "Sai định dạng tiêu đề số hợp đồng";
            public const string contractName = "Sai định dạng tiêu đề tên hợp đồng";
            public const string startDate = "Sai định dạng tiêu đề ngày bắt đầu";
            public const string endDate = "Sai định dạng tiêu đề ngày hết hạn";
            public const string salary = "Sai định dạng tiêu đề lương";
            public const string allowance = "Sai định dạng tiêu đề phụ cấp";
            public const string tax = "Sai định dạng tiêu đề thuế thu nhập";
            public const string coefficient = "Sai định dạng tiêu đề hệ số lương";
            public const string username = "Sai định dạng tiêu đề tài khoản";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 1, Stt },
                { 2, idStaff },
                { 3, staffName },
                { 4, departmentName },
                { 5, position },
                { 6, birthday },
                { 7, address },
                { 8, nationName },
                { 9, academicName },
                { 10, specializeName },
                { 11, email },
                { 12, cccd },
                { 13, dateIssue },
                { 14, issueBy },
                { 15, sex },
                { 16, numberPhone },
                { 17, typeContractName },
                { 18, contractNumber },
                { 19, contractName },
                { 20, startDate },
                { 21, endDate },
                { 22, salary },
                { 23, allowance },
                { 24, tax },
                { 25, coefficient },
                { 26, username },
            };
        }

        public class ImportEmptyResidence
        {
            public const string idCourse = "Mã phòng ban bắt buộc không được để trống";
            public const string courseName = "Tên phòng ban bắt buộc không được để trống";
            public const string idStaff = "Mã nhân viên bắt buộc không được để trống";
            public const string staffName = "Tên nhân viên bắt buộc không được để trống";
            public const string departmentName = "Tên phòng ban bắt buộc không được để trống";
            public const string position = "Vị trí bắt buộc không được để trống";
            public const string birthday = "Ngày sinh bắt buộc không được để trống";
            public const string address = "Địa chỉ bắt buộc không được để trống";
            public const string nationName = "Dân tộc bắt buộc không được để trống";
            public const string academicName = "Học vấn bắt buộc không được để trống";
            public const string specializeName = "Trình độ chuyên môn bắt buộc không được để trống";
            public const string email = "Email bắt buộc không được để trống";
            public const string cccd = "Số cccd bắt buộc không được để trống";
            public const string dateIssue = "Ngày cấp bắt buộc không được để trống";
            public const string issueBy = "Nơi cấp bắt buộc không được để trống";
            public const string sex = "Giới tính bắt buộc không được để trống";
            public const string numberPhone = "Số đt bắt buộc không được để trống";
            public const string typeContractName = "Loại hợp đồng bắt buộc không được để trống";
            public const string contractNumber = "Số hợp đồng bắt buộc không được để trống";
            public const string contractName = "Tên hợp đồng bắt buộc không được để trống";
            public const string startDate = "Ngày bắt đầu bắt buộc không được để trống";
            public const string endDate = "Ngày hết hạn bắt buộc không được để trống";
            public const string salary = "Lương bắt buộc không được để trống";
            public const string allowance = "Phụ cấp bắt buộc không được để trống";
            public const string tax = "Thuế thu nhập bắt buộc không được để trống";
            public const string coefficient = "Hệ số lương bắt buộc không được để trống";
            public const string username = "Tài khoản bắt buộc không được để trống";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 2, idStaff },
                { 3, staffName },
                { 4, departmentName },
                { 5, position },
                { 6, birthday },
                { 7, address },
                { 8, nationName },
                { 9, academicName },
                { 10, specializeName },
                { 11, email },
                { 12, cccd },
                { 13, dateIssue },
                { 14, issueBy },
                { 15, sex },
                { 16, numberPhone },
                { 17, typeContractName },
                { 18, contractNumber },
                { 19, contractName },
                { 20, startDate },
                { 21, endDate },
                { 22, salary },
                { 23, allowance },
                { 24, tax },
                { 25, coefficient },
                { 26, username },
            };
        }
    }
}
