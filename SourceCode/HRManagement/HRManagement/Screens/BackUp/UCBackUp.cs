using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.BackUp
{
    public partial class UCBackUp : DevExpress.XtraEditors.XtraUserControl
    {
        public UCBackUp()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "bak";
            saveFileDialog1.Filter = "Backup File |*.bak";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.InitialDirectory = @"C:/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BackUpDAO dao = new BackUpDAO();
                if (dao.BackUp(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Sao lưu dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!");
                }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string ext = "bak";
            string filter = "Backup File |*.bak";

            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                BackUpDAO dao = new BackUpDAO();
                if (dao.Restore(openFile.FileName))
                {
                    MessageBox.Show("Sao lưu dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!");
                }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            openFile.Dispose();
            openFile = null;
        }
    }
}
