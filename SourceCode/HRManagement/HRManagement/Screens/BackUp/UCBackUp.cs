using DevExpress.XtraEditors;
using HRManagement.ImportData;
using Model.DAO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.Screens.BackUp
{
    public partial class UCBackUp : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly string templatePath = Environment.CurrentDirectory + "\\..\\..\\Template\\";
        private readonly string templateCourse = "TemplateCourse.xlsx";
        private readonly string templateDepartment = "TemplateDepartment.xlsx";
        private readonly string templateInsurance = "TemplateInsurance.xlsx";
        private readonly string templateStaff = "TemplateStaff.xlsx";
        private readonly string templateStaffCourse = "TemplateStaffCourse.xlsx";

        public UCBackUp()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string ext = "bak";
            string filter = "Backup File |*.bak";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            SaveFileCommon save = new SaveFileCommon();
            save.SaveFileDialogCommon(ext, filter, out saveFileDialog1);

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

        private void btnImportDepartment_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportDepartment import = new ImportDepartment();
                if (import.ImportDataDepartment(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void btnImportCourse_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportCourse import = new ImportCourse();
                if (import.ImportDataCourse(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void btnImportInsurance_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportInsurance import = new ImportInsurance();
                if (import.ImportDataInsurance(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void btnImportStaffCourse_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportStaffCourse import = new ImportStaffCourse();
                if (import.ImportDataStaffCourse(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void btnImportStaff_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";
            OpenFileDialog openFile = new OpenFileDialog();

            OpenFileCommon open = new OpenFileCommon();
            open.OpenFileDialogCommon(ext, filter, out openFile);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> lstError = new List<string>();
                ImportStaff import = new ImportStaff();
                if (import.ImportDataStaff(openFile.FileName, out lstError))
                {
                    if (lstError.Count > 0)
                    {
                        FormErrorImport form = new FormErrorImport(lstError);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nhập dữ liệu thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void btnTempDepartment_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;

                if (File.Exists(save.FileName))
                {
                    File.Create(path);
                }

                try
                {
                    File.Copy(templatePath + templateDepartment, path);
                    MessageBox.Show("Tải file mẫu thành công!");
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }

        private void btnTempCourse_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;

                if (File.Exists(save.FileName))
                {
                    File.Create(path);
                }

                try
                {
                    File.Copy(templatePath + templateCourse, path);
                    MessageBox.Show("Tải file mẫu thành công!");
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }

        private void btnTempInsurance_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;

                if (File.Exists(save.FileName))
                {
                    File.Create(path);
                }

                try
                {
                    File.Copy(templatePath + templateInsurance, path);
                    MessageBox.Show("Tải file mẫu thành công!");
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }

        private void btnTempStaffCourse_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;

                if (File.Exists(save.FileName))
                {
                    File.Create(path);
                }

                try
                {
                    File.Copy(templatePath + templateStaffCourse, path);
                    MessageBox.Show("Tải file mẫu thành công!");
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }

        private void btnTempStaff_Click(object sender, EventArgs e)
        {
            string ext = "xlsx";
            string filter = "XLSX File |*.xlsx";

            SaveFileDialog save = new SaveFileDialog();

            SaveFileCommon saveFile = new SaveFileCommon();
            saveFile.SaveFileDialogCommon(ext, filter, out save);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;

                if (File.Exists(save.FileName))
                {
                    File.Create(path);
                }

                try
                {
                    File.Copy(templatePath + templateStaff, path);
                    MessageBox.Show("Tải file mẫu thành công!");
                }
                catch { System.Windows.MessageBox.Show("Có lỗi trong quá trình sao lưu, Vui lòng thử lại!"); }
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            save.Dispose();
        }
    }
}
