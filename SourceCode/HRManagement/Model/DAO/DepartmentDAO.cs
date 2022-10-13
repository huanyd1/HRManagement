using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DepartmentDAO : BaseDAO
    {
        public List<Department> GetAll()
        {
            List<Department> list = _db.Departments.ToList();

            return list;
        }

        public Department GetSingleByID(string id)
        {
            Department department = _db.Departments.Where(x => x.IDDepartment == id).FirstOrDefault();

            return department;
        }

        public List<Department> GetDepartmentByFilter(string idDepartment, string departmentName, string status)
        {
            List<Department> list = _db.Departments.ToList();

            if (!string.IsNullOrEmpty(idDepartment))
            {
                list = list.Where(x => x.IDDepartment == idDepartment).ToList();
            }

            if (!string.IsNullOrEmpty(departmentName))
            {
                list =  list.Where(x => x.DepartmentName == departmentName).ToList();
            }

            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                list = list.Where(x => x.Status == status).ToList();
            }

            return list.ToList();
        }

        public string GetDepartmentNameByIDStaff(string idStaff)
        {
            string idDepartment = _db.Staffs.Where(t => t.IDStaff == idStaff).Select(t => t.IDDepartment).FirstOrDefault();

            string departmentName = _db.Departments.Where(t => t.IDDepartment == idDepartment).Select(t => t.DepartmentName).FirstOrDefault();

            return departmentName;
        }

        public bool AddListDepartment(List<Model.EF.Department> lstDepartment)
        {
            foreach(var department in lstDepartment)
            {
                try
                {
                    if (!IsExistIDDepartment(department.IDDepartment))
                    {
                        _db.Departments.Add(department);
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Model.NotificationCommon.Error(ex.Message);
                    return false;
                }
            }
            return true;
        }

        public bool Add(Department department)
        {
            try
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Department department)
        {
            try
            {
                Department currentDepartment = GetSingleByID(department.IDDepartment);

                currentDepartment.DepartmentName = department.DepartmentName;
                currentDepartment.Status = currentDepartment.Status;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(string id)
        {
            try
            {
                Department currentDepartment = GetSingleByID(id);

                _db.Departments.Remove(currentDepartment);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitDepartment(string name)
        {
            var result = _db.Departments.Where(x => x.DepartmentName == name).Any();

            return result;
        }

        public bool IsExistIDDepartment(string id)
        {
            var result = _db.Departments.Where(x => x.IDDepartment == id).Any();

            return result;
        }
    }
}
