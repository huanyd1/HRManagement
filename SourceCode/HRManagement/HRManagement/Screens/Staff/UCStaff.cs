using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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

namespace HRManagement.Screens.Staff
{
    public partial class UCStaff : DevExpress.XtraEditors.XtraUserControl
    {
        public UCStaff()
        {
            InitializeComponent();
        }

        private void LoadAllInfoStaff()
        {
            StaffDAO dao = new StaffDAO();
            gStaff.DataSource = dao.GetAll();
        }

        private void LoadAllDepartment()
        {
            DepartmentDAO dao = new DepartmentDAO();
            cbDepartment.DataSource = dao.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "IDDepartment";
        }

        private void UCStaff_Load(object sender, EventArgs e)
        {
            LoadAllInfoStaff();
            LoadAllDepartment();

            gvStaff.RowCellStyle += (sen, evt) =>
            {
                GridView view = sender as GridView;
                if (evt.Column.FieldName == "Status")
                {
                    evt.Appearance.BackColor = (string)evt.CellValue == "1" ? Color.LightGreen : Color.IndianRed;
                }
            };
        }

        private void gvStaff_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Sex" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Sex").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Nữ"; break;
                    case "1": e.DisplayText = "Nam"; break;
                }
            }
            else if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                string currencyType = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status").ToString();
                switch (currencyType)
                {
                    case "0": e.DisplayText = "Ngừng hoạt động"; break;
                    case "1": e.DisplayText = "Hoạt động"; break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idDepartment = cbDepartment.SelectedValue.ToString();
            string idStaff = txtIDStaff.Text.ToString();
            string staffName = txtStaffName.Text.ToString();

            StaffDAO dao = new StaffDAO();
            gStaff.DataSource = dao.GetStaffByFilter(idDepartment, idStaff, staffName);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(gvStaff.RowCount > 0)
            {
                string idStaff = gvStaff.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeStaff infoStaff = new FormChangeStaff();
                infoStaff.IsInfo = true;
                infoStaff.IdStaff = idStaff;
                infoStaff.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChangeStaff addStaff = new FormChangeStaff();
            addStaff.IsAdd = true;
            addStaff.Show();

            if (addStaff.IsSave)
            {
                LoadAllInfoStaff();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(gvStaff.RowCount > 0)
            {
                string idStaff = gvStaff.GetFocusedRowCellValue("IDStaff").ToString();

                FormChangeStaff editStaff = new FormChangeStaff();
                editStaff.IsAdd = false;
                editStaff.IdStaff = idStaff;
                editStaff.Show();

                if (editStaff.IsSave)
                {
                    LoadAllInfoStaff();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvStaff.RowCount > 0)
            {
                string staffName = gvStaff.GetFocusedRowCellValue("StaffName").ToString();

                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.DeleteVariable("Nhân viên", staffName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string idStaff = gvStaff.GetFocusedRowCellValue("IDStaff").ToString();         

                    StaffDAO dao = new StaffDAO();
                    if (dao.Delete(idStaff))
                    {
                        Model.NotificationCommon.DeleteSuccess("Nhân viên");
                        LoadAllInfoStaff();
                    }
                    else
                    {
                        Model.NotificationCommon.DeleteFaild("Nhân viên");
                    }
                }
            }
        }
    }
}
