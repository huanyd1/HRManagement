using Model.DAO;
using Model.EF;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.ImportData
{
    public class ImportInsurance
    {
        public bool ImportDataInsurance(string fileName, out List<string> lstError)
        {
            lstError = new List<string>();
            List<int> lstRowError = new List<int>();
            List<Model.EF.Insurance> lstInsurance = new List<Model.EF.Insurance>();

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
                        string idInsurance = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma bao hiem
                        string insuranceName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten bao hiem
                        string insuranceType = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // loai bao hiem
                        string amount = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // so tien

                        string errorHeader = ValidateHeader(rowNoheader, idInsurance, insuranceName, insuranceType, amount);
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
                        string idInsurances = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma bao hiem
                        string insuranceNames = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten bao hiem
                        string insuranceTypes = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // loai bao hiem
                        string amounts = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // so tien

                        bool errorDataBeforeCheck = ValidateBeforeFileEmpty(rowNoheaders, idInsurances, insuranceNames, insuranceTypes, amounts);

                        if (errorDataBeforeCheck)
                        {
                            string idInsurance = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma phong ban
                            string insuranceName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten phong ban
                            string insuranceType = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten phong ban
                            string amount = worksheet.Cells[row, 5].Value != null ? worksheet.Cells[row, 5].Value.ToString().Trim() : string.Empty; // ten phong ban
                            bool errorDataEmpty = ValidateFileEmpty(idInsurance, insuranceName, insuranceType, amount);

                            if (!errorDataEmpty)
                            {
                                string errorData = ValidateImportData(idInsurance, insuranceName, insuranceType, amount);
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
                                Model.DAO.InsuranceTypeDAO daoType = new InsuranceTypeDAO();
                                string idType = daoType.GetIDByNameType(insuranceType);
                                if (!string.IsNullOrEmpty(idType))
                                {
                                    Model.EF.Insurance insurance = new Model.EF.Insurance();
                                    insurance.IDInsurance = idInsurance;
                                    insurance.InsuranceName = insuranceName;
                                    insurance.IDInsuranceType = idType;
                                    insurance.Amount = int.Parse(amount.ToString().Replace(",", ""));

                                    lstInsurance.Add(insurance);
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

                    InsuranceDAO dao = new InsuranceDAO();
                    if (dao.AddListInsurance(lstInsurance))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private string ValidateHeader(string stt, string idInsurance, string insuranceName, string insuranceType, string amount)
        {
            string result = string.Empty;

            if (!stt.Equals("STT"))
            {
                result += "1,";
            }
            if (!idInsurance.Equals("Mã bảo hiểm*"))
            {
                result += "2,";
            }
            if (!insuranceName.Equals("Tên bảo hiểm*"))
            {
                result += "3,";
            }
            if (!insuranceType.Equals("Loại bảo hiểm*"))
            {
                result += "4,";
            }
            if (!amount.Equals("Số tiền*"))
            {
                result += "5,";
            }

            return result;
        }

        private bool ValidateBeforeFileEmpty(string stt, string idInsurance, string insuranceName, string insuranceType, string amount)
        {
            bool result = true;
            if (string.IsNullOrEmpty(stt) && string.IsNullOrEmpty(idInsurance) && string.IsNullOrEmpty(insuranceName) 
                && string.IsNullOrEmpty(insuranceType) && string.IsNullOrEmpty(amount))
            {
                result = false;
            }

            return result;
        }

        private string ValidateImportData(string idInsurance, string insuranceName, string insuranceType, string amount)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(idInsurance))
            {
                result += "2,";
            }
            if (string.IsNullOrEmpty(insuranceName))
            {
                result += "3,";
            }
            if (string.IsNullOrEmpty(insuranceType))
            {
                result += "4,";
            }
            if (string.IsNullOrEmpty(amount))
            {
                result += "5,";
            }

            return result;
        }

        private bool ValidateFileEmpty(string idInsurance, string insuranceName, string insuranceType, string amount)
        {
            bool result = true;
            if (string.IsNullOrEmpty(idInsurance) || string.IsNullOrEmpty(insuranceName) || string.IsNullOrEmpty(insuranceType) || string.IsNullOrEmpty(amount))
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
            public const string idDepartment = " Sai định dạng tiêu đề mã phòng ban";
            public const string departmentName = " Sai định dạng tiêu đề tên phòng ban";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 1, Stt },
                { 2, idDepartment },
                { 3, departmentName },
            };
        }

        public class ImportEmptyResidence
        {
            public const string idDepartment = "Mã phòng ban bắt buộc không được để trống";
            public const string departmentName = "Tên phòng ban bắt buộc không được để trống";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 2, idDepartment },
                { 3, departmentName },
            };
        }
    }
}
