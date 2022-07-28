using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class MessageBoxCommon
    {
        public static string IsExitVariable(string variable)
        {
            return string.Format("{0} đã có trong Cơ sở dữ liệu, vẫn muốn thêm?", variable);
        }

        public static string IsExistTime()
        {
            return string.Format("Ngày công này đã tồn tại trong Cơ sở dữ liệu, vui lòng kiểm tra lại");
        }

        public static string IsNotExistTime()
        {
            return string.Format("Không thể xóa ngày công này do chưa tồn tại trong Cơ sở dữ liệu, vui lòng kiểm tra lại");
        }

        public static string ExitForm()
        {
            return string.Format("Dữ liệu chưa được lưu lại, vẫn muốn thoát");
        }

        public static string DeleteVariable(string variable, string name)
        {
            return string.Format("Bạn có thực sự muốn xóa {0} '{1}' không?", variable, name);
        }

        public static string DeleteStaffCourse(string course,  string staff)
        {
            return string.Format("Bạn có thực sự muốn xóa Khóa học '{0}' của Nhân viên '{1}' không?", course, staff);
        }
    }
}
