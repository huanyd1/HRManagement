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
    public class ImportDepartment
    {//phòng ban, khóa học, bảo hiểm, nhân viên
        public bool ImportDataDepartment(string fileName, out List<string> lstError)
        {
            lstError = new List<string>();
            List<int> lstRowError = new List<int>();
            List<Model.EF.Department> lstDepartment = new List<Model.EF.Department>();

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
                        string idDepartment = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma nop tien
                        string departmentName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ho va ten

                        string errorHeader = ValidateHeader(rowNoheader, idDepartment, departmentName);
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
                        string idDepartments = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // stt
                        string departmentNames = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ma nop tien

                        bool errorDataBeforeCheck = ValidateBeforeFileEmpty(rowNoheaders, idDepartments, departmentNames);

                        if (errorDataBeforeCheck)
                        {
                            string idDepartment = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma phong ban
                            string departmentName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten phong ban
                            bool errorDataEmpty = ValidateFileEmpty(idDepartment, departmentName);

                            if (!errorDataEmpty)
                            {
                                string errorData = ValidateImportData(idDepartment, departmentName);
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
                                Model.EF.Department department = new Model.EF.Department();
                                department.IDDepartment = idDepartment;
                                department.DepartmentName = departmentName;
                                department.Status = "1";

                                lstDepartment.Add(department);
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

                    DepartmentDAO dao = new DepartmentDAO();
                    if (dao.AddListDepartment(lstDepartment))
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

        private string ValidateHeader(string stt, string idDepartment, string departmentName)
        {
            string result = string.Empty;
            int index = 1;
            string comma = ",";

            if (!stt.Equals("STT"))
            {
                result += index.ToString() + comma;
                index++;
            }
            if (!idDepartment.Equals("Mã phòng ban*"))
            {
                result += index.ToString() + comma;
                index++;
            }
            if (!departmentName.Equals("Tên phòng ban*"))
            {
                result += index.ToString() + comma;
                index++;
            }

            return result;
        }

        private bool ValidateBeforeFileEmpty(string stt, string idDepartment, string departmentName)
        {
            bool result = true;
            if (string.IsNullOrEmpty(stt) && string.IsNullOrEmpty(idDepartment) && string.IsNullOrEmpty(departmentName))
            {
                result = false;
            }

            return result;
        }

        private string ValidateImportData(string idDepartment, string departmentName)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(idDepartment))
            {
                result += "2,";
            }
            if (string.IsNullOrEmpty(departmentName))
            {
                result += "3,";
            }

            return result;
        }

        private bool ValidateFileEmpty(string idDepartment, string departmentName)
        {
            bool result = true;
            if (string.IsNullOrEmpty(idDepartment) || string.IsNullOrEmpty(departmentName))
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
