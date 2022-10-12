using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    public class OpenFileCommon
    {


        public OpenFileDialog OpenFileDialogCommon(string defaultExt, string filter, out OpenFileDialog openfile)
        {
            openfile = new OpenFileDialog();
            openfile.InitialDirectory = "C://Desktop";
            openfile.Title = "Select file to be upload.";
            openfile.DefaultExt = defaultExt;
            openfile.Filter = filter;
            openfile.AddExtension = true;
            openfile.RestoreDirectory = true;
            openfile.FilterIndex = 1;

            return openfile;
        }
    }
}
