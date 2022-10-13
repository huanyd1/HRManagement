using DevExpress.XtraEditors;
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
    public partial class FormErrorImport : DevExpress.XtraEditors.XtraForm
    {
        List<string> errors = new List<string>();
        ListBox listBox1 = new ListBox();

        public FormErrorImport(List<string> lstError)
        {
            InitializeComponent();
            errors = lstError;
        }

        private void FormErrorImport_Load(object sender, EventArgs e)
        {
            this.Text = "Danh sách lỗi";
            this.Size = new Size(600, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //add controls
            listBox1.Enabled = true;
            listBox1.Font = new Font("Cascadia Code", 12, FontStyle.Bold);
            listBox1.Items.Add("Danh sách lỗi");
            listBox1.Dock = DockStyle.Fill;
            panel1.Controls.Add(listBox1);

            LoadAllError(errors);
        }

        private void LoadAllError(List<string> lstError)
        {
            foreach(var item in lstError)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}