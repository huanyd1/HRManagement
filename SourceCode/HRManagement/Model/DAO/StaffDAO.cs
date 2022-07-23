using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class StaffDAO : BaseDAO
    {
        public List<Staff> GetAll()
        {
            List<Staff> list = _db.Staffs.ToList();

            return list;
        }

        public Staff GetSingleByID(string id)
        {
            Staff staff = _db.Staffs.Where(x => x.IDStaff == id).FirstOrDefault();

            return staff;
        }

        public List<Staff> GetStaffByFilter(string idStaff, string idDepartment)
        {
            List<Staff> list = GetAll();

            //Lọc theo mã nhân viên
            if (!string.IsNullOrEmpty(idStaff))
            {
                list.Where(t => t.IDStaff == idStaff);
            }

            //Lọc theo phòng ban
            if (!string.IsNullOrEmpty(idDepartment))
            {
                list.Where(t => t.IDDepartment == idDepartment);
            }

            return list;
        }

        public bool Add(Staff staff)
        {
            try
            {
                _db.Staffs.Add(staff);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Staff staff)
        {
            try
            {
                Staff currentStaff = GetSingleByID(staff.IDStaff);

                currentStaff.StaffName = staff.StaffName;
                currentStaff.Birthday = staff.Birthday;
                currentStaff.Place = staff.Place;
                currentStaff.CCCD = staff.CCCD;
                currentStaff.Numberphone = staff.Numberphone;
                currentStaff.IDSalary = staff.IDSalary;
                currentStaff.IDDepartment = staff.IDDepartment;
                currentStaff.IDInsurance = staff.IDInsurance;
                currentStaff.IDContract = staff.IDContract;
                currentStaff.IDStaffCource = staff.IDStaffCource;
                currentStaff.IDPosition = staff.IDPosition;
                currentStaff.Status = staff.Status;
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
                Staff currentStaff = GetSingleByID(id);

                _db.Staffs.Remove(currentStaff);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitStaff(string name)
        {
            var result = _db.Staffs.Where(x => x.StaffName == name).Any();

            return result;
        }
    }
}
