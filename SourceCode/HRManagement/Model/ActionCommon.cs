using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ActionCommon
    {
        public static string InfoAction(string variable)
        {
            return string.Format("Xem chi tiết " + variable);
        }

        public static string AddAction(string variable)
        {
            return string.Format("Thêm mới " + variable);
        }

        public static string EditAction(string variable)
        {
            return string.Format("Chỉnh sửa thông tin " + variable);
        }
    }
}
