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

            foreach(var department in list)
            {
                if(department.Status == "1")
                {
                    department.Status = "Hoạt động";
                }
                else
                {
                    department.Status = "Ngừng hoạt động";
                }  
            }

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
                list.Where(x => x.IDDepartment == idDepartment);
            }

            if (!string.IsNullOrEmpty(departmentName))
            {
                list.Where(x => x.DepartmentName == departmentName);
            }

            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                list.Where(x => x.Status == status);
            }

            return list.ToList();
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
    }
}
