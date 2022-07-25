using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public static class NotificationCommon
    {
        public static void Success(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string message)
        {
            MessageBox.Show(string.Format("Đã có lỗi xảy ra {0} {1}", Environment.NewLine, message), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string message)
        {
            MessageBox.Show(string.Format("Đã có lỗi xảy ra {0} {1}", Environment.NewLine, message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AddSuccess(string action, string variable)
        {
            MessageBox.Show(string.Format("{0} {1} thành công", action, variable), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AddFaild(string action, string variable)
        {
            MessageBox.Show(string.Format("{0} {1} thất bại", action, variable), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DeleteSuccess(string variale)
        {
            MessageBox.Show(string.Format("Xóa {0} thành công!", variale), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DeleteFaild(string variale)
        {
            MessageBox.Show(string.Format("Hiện tại không thể xóa {0} này, vui lòng thử lại!", variale), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
