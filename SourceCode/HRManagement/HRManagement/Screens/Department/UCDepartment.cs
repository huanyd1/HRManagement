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

namespace HRManagement.Screens.Department
{
    public partial class UCDepartment : DevExpress.XtraEditors.XtraUserControl
    {
        public UCDepartment()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            gDepartment.DataSource = dao.GetAll();
        }

        private void LoadDepartmentStatus()
        {
            cbStatus.Items.Clear();

            cbStatus.Items.Add("Tất cả");
            cbStatus.Items.Add("Hoạt động");
            cbStatus.Items.Add("Ngừng hoạt động");

            cbStatus.SelectedText = "Tất cả";
        }

        private void UCDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartmentStatus();
            LoadAllDepartment(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idDepartment = txtIDDepartment.Text.ToString();
            string departmentName = txtDepartmentName.Text.ToString();
            string status = cbStatus.Text.ToString();

            DepartmentDAO dao = new DepartmentDAO();
            gDepartment.DataSource = dao.GetDepartmentByFilter(idDepartment, departmentName, status);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (gvDepartment.RowCount > 0)
            {
                string idDepartment = gvDepartment.GetFocusedRowCellValue("IDDepartment").ToString();

                ChangeDepartment infoDepartment = new ChangeDepartment();
                infoDepartment.IsAdd = false;
                infoDepartment.IdDepartment = idDepartment;
                infoDepartment.IsInfo = true;
                infoDepartment.Show();
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            ChangeDepartment addDepartment = new ChangeDepartment();
            addDepartment.IsAdd = true;
            addDepartment.Show();

            if (addDepartment.IsSave)
            {
                LoadAllDepartment();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(gvDepartment.RowCount > 0)
            {
                string idDepartment = gvDepartment.GetFocusedRowCellValue("IDDepartment").ToString();

                ChangeDepartment editDepartment = new ChangeDepartment();
                editDepartment.IsAdd = false;
                editDepartment.IdDepartment = idDepartment;
                editDepartment.Show();

                if (editDepartment.IsSave)
                {
                    LoadAllDepartment();
                }
            }        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gvDepartment.RowCount > 0)
            {
                string departmentName = gvDepartment.GetFocusedRowCellValue("DepartmentName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteVariable("Phòng ban", departmentName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    string idDepartment = gvDepartment.GetFocusedRowCellValue("IDDepartment").ToString();

                    DepartmentDAO dao = new DepartmentDAO();
                    if (dao.Delete(idDepartment))
                    {
                        Model.NotificationCommon.DeleteSuccess("Phòng ban");
                        LoadAllDepartment();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Phòng ban");
                    }
                }
            }
        }
    }
}
