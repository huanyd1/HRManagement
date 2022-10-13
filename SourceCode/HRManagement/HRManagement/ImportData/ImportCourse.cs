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
    public class ImportCourse
    {//phòng ban, khóa học, bảo hiểm, nhân viên
        public bool ImportDataCourse(string fileName, out List<string> lstError)
        {
            lstError = new List<string>();
            List<int> lstRowError = new List<int>();
            List<Model.EF.Course> lstCourse = new List<Model.EF.Course>();

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
                        string idCourse = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                        string courseName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                        string errorHeader = ValidateHeader(rowNoheader, idCourse, courseName);
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
                        string idCourses = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                        string courseNames = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                        bool errorDataBeforeCheck = ValidateBeforeFileEmpty(rowNoheaders, idCourses, courseNames);

                        if (errorDataBeforeCheck)
                        {
                            string idCourse = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma phong ban
                            string courseName = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten phong ban
                            bool errorDataEmpty = ValidateFileEmpty(idCourse, courseName);

                            if (!errorDataEmpty)
                            {
                                string errorData = ValidateImportData(idCourse, courseName);
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
                                Model.EF.Course department = new Model.EF.Course();
                                department.IDCourse = idCourse;
                                department.CourseName = courseName;
                                department.Status = "1";

                                lstCourse.Add(department);
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

                    CourseDAO dao = new CourseDAO();
                    if (dao.AddListCourse(lstCourse))
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

        private string ValidateHeader(string stt, string idCourse, string courseName)
        {
            string result = string.Empty;
            int index = 1;
            string comma = ",";

            if (!stt.Equals("STT"))
            {
                result += index.ToString() + comma;
                index++;
            }
            if (!idCourse.Equals("Mã khóa học*"))
            {
                result += index.ToString() + comma;
                index++;
            }
            if (!courseName.Equals("Tên khóa học*"))
            {
                result += index.ToString() + comma;
                index++;
            }

            return result;
        }

        private bool ValidateBeforeFileEmpty(string stt, string idCourse, string courseName)
        {
            bool result = true;
            if (string.IsNullOrEmpty(stt) && string.IsNullOrEmpty(idCourse) && string.IsNullOrEmpty(courseName))
            {
                result = false;
            }

            return result;
        }

        private string ValidateImportData(string idCourse, string courseName)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(idCourse))
            {
                result += "2,";
            }
            if (string.IsNullOrEmpty(courseName))
            {
                result += "3,";
            }

            return result;
        }

        private bool ValidateFileEmpty(string idCourse, string courseName)
        {
            bool result = true;
            if (string.IsNullOrEmpty(idCourse) || string.IsNullOrEmpty(courseName))
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
            public const string idCourse = "Sai định dạng tiêu đề mã khóa học";
            public const string courseName = "Sai định dạng tiêu đề tên khóa học";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 1, Stt },
                { 2, idCourse },
                { 3, courseName },
            };
        }

        public class ImportEmptyResidence
        {
            public const string idCourse = "Mã phòng ban bắt buộc không được để trống";
            public const string courseName = "Tên phòng ban bắt buộc không được để trống";


            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 2, idCourse },
                { 3, courseName },
            };
        }
    }
}
