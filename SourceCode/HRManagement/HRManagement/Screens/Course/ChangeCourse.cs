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

namespace HRManagement.Screens.Course
{
    public partial class ChangeCourse : DevExpress.XtraEditors.XtraForm
    {
        private bool _isSave = false;
        private bool _isAdd;
        private bool _isInfo = false;
        private string _idCourse;

        private readonly string idCourse = "Mã khóa học";
        private readonly string courseName = "Tên khóa học";

        public ChangeCourse()
        {
            InitializeComponent();
        }

        public bool IsSave
        {
            get { return _isSave; }
        }
        public bool IsAdd
        {
            get { return _isAdd; }
            set { _isAdd = value; }
        }
        public bool IsInfo
        {
            get { return _isInfo; }
            set { _isInfo = value; }
        }
        public string IdCourse
        {
            set { _idCourse = value; }
        }

        private void LoadStatusCourse()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Hoạt động");
            cbStatus.Items.Add("Ngừng hoạt động");

            cbStatus.SelectedText = "Hoạt động";
        }

        private void UCChangeCourse_Load(object sender, EventArgs e)
        {
            LoadStatusCourse();

            if (!_isAdd)
            {
                this.Text = Model.ActionCommon.EditAction("Khóa học");
                txtIDCourse.ReadOnly = true;
                btnSave.Text = "Cập nhật";

                CourseDAO dao = new CourseDAO();
                Model.EF.Course course = dao.GetSingleByID(_idCourse);

                txtIDCourse.Text = course.IDCourse.ToString();
                txtCourseName.Text = course.CourseName.ToString();
                //cbStatus.SelectedValue = course.id.ToString();

                //Nếu info thì disable tất cả
                if (_isInfo)
                {
                    txtIDCourse.ReadOnly = true;
                    txtCourseName.ReadOnly = true;
                    cbStatus.Enabled = false;

                    btnSave.Visible = false;
                    this.Text = Model.ActionCommon.InfoAction("Khóa học");
                }
            }
            else
            {
                this.Text = Model.ActionCommon.AddAction("Khóa học");
                btnSave.Text = "Thêm mới";
            }
        }

        public bool CheckNullVariable()
        {
            bool flag = true;

            if (txtIDCourse.Text == string.Empty)
            {
                errorIDCourse.SetError(txtIDCourse, Model.CheckVariableCommon.NullVariable(idCourse));
                flag = false;
            }
            else
            {
                errorIDCourse.SetError(txtIDCourse, null);
            }

            if (txtCourseName.Text == string.Empty)
            {
                errorCourseName.SetError(txtCourseName, Model.CheckVariableCommon.NullVariable(courseName));
                flag = false;
            }
            else
            {
                errorCourseName.SetError(txtCourseName, null);
            }

            return flag;
        }

        public Model.EF.Course GetInfoCourse()
        {
            Model.EF.Course course = new Model.EF.Course();
            course.IDCourse = txtIDCourse.Text;
            course.CourseName = txtCourseName.Text;
            course.Status = cbStatus.Text == "Hoạt động" ? "1" : "0";

            return course;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullVariable())
            {
                return;
            }

            CourseDAO dao = new CourseDAO();

            Model.EF.Course course = GetInfoCourse();

            if (_isAdd)
            {
                if (dao.IsExitCourse(txtCourseName.Text))
                {
                    DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.IsExitVariable(courseName), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (dao.Add(course))
                        {
                            _isSave = true;
                        }
                    }
                }
                else
                {
                    if (dao.Add(course))
                    {
                        _isSave = true;
                    }
                }
            }
            else
            {
                if (dao.Edit(course))
                {
                    _isSave = true;
                }
            }

            if (_isSave)
            {
                Model.NotificationCommon.AddSuccess(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Khóa học");
                this.Close();
            }
            else
            {
                Model.NotificationCommon.AddFaild(_isAdd == true ? "Thêm mới" : "Sửa thông tin", "Khóa học");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtIDCourse.Text != string.Empty || txtCourseName.Text != string.Empty) && _isInfo == false)
            {
                DialogResult dialog = MessageBox.Show(Model.MessageBoxCommon.ExitForm(), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}