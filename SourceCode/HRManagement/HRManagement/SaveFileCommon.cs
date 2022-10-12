using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    public class SaveFileCommon
    {
        public SaveFileDialog SaveFileDialogCommon(string defaultExt, string filter, out SaveFileDialog savefile)
        {
            savefile = new SaveFileDialog();
            savefile.DefaultExt = defaultExt;
            savefile.Filter = filter;
            savefile.AddExtension = true;
            savefile.RestoreDirectory = true;
            savefile.Title = "Where do you want to save the file?";
            savefile.InitialDirectory = @"C:/";

            return savefile;
        }
    }
}
