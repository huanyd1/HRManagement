using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CheckVariableCommon
    {
        public static string NullVariable(string variable)
        {
            string messageError = " không được để trống";
            return variable + messageError;
        }
    }
}
