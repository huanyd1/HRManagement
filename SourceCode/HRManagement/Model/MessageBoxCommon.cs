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
        public static string IsExistVariable(string variable)
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

        public static string DeleteLeaveAbsence()
        {
            return string.Format("Đơn này chưa được duyệt, bạn có thực sự muốn xóa?");
        }

        public static string DeleteStaffCourse(string course,  string staff)
        {
            return string.Format("Bạn có thực sự muốn xóa Khóa học '{0}' của Nhân viên '{1}' không?", course, staff);
        }

        public static string DeleteExplanation()
        {
            return string.Format("Giải trình này chưa được duyệt, vẫn muốn xóa?");
        }

        public static string AccountError()
        {
            return string.Format("Tài khoản hoặc mật khẩu không đúng, vui lòng thử lại");
        }

        public static string IsNotExistReport()
        {
            return string.Format("Không thể tìm thấy Báo cáo này hiện tại, Vui lòng thử lại!");
        }

        public static string SendMailSuccess()
        {
            return string.Format("Hệ thống đã gửi thông tin Email thành công!");
        }

        public static string SendMainError()
        {
            return string.Format("Đã có lỗi trong quá trình xử lý, Vui lòng kiểm tra lại!");
        }
    }
}
