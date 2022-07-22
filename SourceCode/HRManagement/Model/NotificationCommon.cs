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

        
    }
}
