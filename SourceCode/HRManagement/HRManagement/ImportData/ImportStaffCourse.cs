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
    public class ImportStaffCourse
    {
        public bool ImportDataStaffCourse(string fileName, out List<string> lstError)
        {
            lstError = new List<string>();
            List<int> lstRowError = new List<int>();
            List<Model.EF.StaffCourse> lstStaffCourse = new List<Model.EF.StaffCourse>();

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
                        string idCourse = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string point = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                        string errorHeader = ValidateHeader(rowNoheader, idStaff, idCourse, point);
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
                        string idCourses = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        string points = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                        
                        bool errorDataBeforeCheck = ValidateBeforeFileEmpty(rowNoheaders, idStaffs, idCourses, points);

                        if (errorDataBeforeCheck)
                        {
                            string idStaff = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty; // ma khoa hoc
                            string idCourse = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString().Trim() : string.Empty; // ten khoa hoc
                            string point = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString().Trim() : string.Empty; // ten khoa hoc

                            bool errorDataEmpty = ValidateFileEmpty(idStaff, idCourse, point);

                            if (!errorDataEmpty)
                            {
                                string errorData = ValidateImportData(idStaff, idCourse, point);
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
                                var isExistStaff = staffDAO.IsExitStaff(idStaff);

                                CourseDAO courseDAO = new CourseDAO();
                                var isExistCourse = courseDAO.IsExistIDCourse(idCourse);

                                if (!isExistCourse && !isExistStaff)
                                {
                                    Model.EF.StaffCourse staffCourse = new Model.EF.StaffCourse();
                                    staffCourse.IDCourse = idCourse;
                                    staffCourse.IDStaff = idStaff;
                                    staffCourse.Point = int.Parse(point);
                                    staffCourse.Result = 80 <= int.Parse(point) ? "1" : "0";

                                    lstStaffCourse.Add(staffCourse);
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

                    StaffCourseDAO dao = new StaffCourseDAO();
                    if (dao.AddListStaffCourse(lstStaffCourse))
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

        private string ValidateHeader(string stt, string idStaff, string idCourse, string point)
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
            if (!idCourse.Equals("Mã khóa học*"))
            {
                result += "3,";
            }
            if (!point.Equals("Điểm*"))
            {
                result += "4,";
            }

            return result;
        }

        private bool ValidateBeforeFileEmpty(string stt, string idStaff, string idCourse, string point)
        {
            bool result = true;
            if (string.IsNullOrEmpty(stt) && string.IsNullOrEmpty(idStaff) && string.IsNullOrEmpty(idCourse) && string.IsNullOrEmpty(point))
            {
                result = false;
            }

            return result;
        }

        private string ValidateImportData(string idStaff, string idCourse, string point)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(idStaff))
            {
                result += "2,";
            }
            if (string.IsNullOrEmpty(idCourse))
            {
                result += "3,";
            }
            if (string.IsNullOrEmpty(point))
            {
                result += "4,";
            }

            return result;
        }

        private bool ValidateFileEmpty(string idStaff, string idCourse, string point)
        {
            bool result = true;
            if (string.IsNullOrEmpty(idStaff) || string.IsNullOrEmpty(idCourse) || string.IsNullOrEmpty(point))
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
            public const string idCourse = "Sai định dạng tiêu đề mã khóa học";
            public const string point = "Sai định dạng tiêu đề điểm";

            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 1, Stt },
                { 2, idStaff },
                { 3, idCourse },
                { 4, point },
            };
        }

        public class ImportEmptyResidence
        {
            public const string idStaff = "Mã nhân viên bắt buộc không được để trống";
            public const string idCourse = "Mã khóa học bắt buộc không được để trống";
            public const string point = "Điểm bắt buộc không được để trống";

            public static Dictionary<int, string> dctImportData = new Dictionary<int, string>()
            {
                { 2, idStaff },
                { 3, idCourse },
                { 4, point },
            };
        }
    }
}
