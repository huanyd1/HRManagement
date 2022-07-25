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

        public static string ExitForm()
        {
            return string.Format("Dữ liệu chưa được lưu lại, vẫn muốn thoát");
        }

        public static string DeleteVariable(string variable, string name)
        {
            return string.Format("Bạn có thực sự muốn xóa {0} '{1}' không?", variable, name);
        }
    }
}
