using System;
using System.Collections.Generic;
using System.Data;
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
            List<Staff> list = _db.Accounts.Where(x => x.Type == "4").Select(x => x.Staff).ToList();

            return list;
        }

        public Staff GetSingleByID(string id)
        {
            Staff staff = _db.Staffs.Where(x => x.IDStaff == id).FirstOrDefault();

            return staff;
        }

        public GetAllInfoByIDStaff_Result GetAllInfoByIDStaff(string idStaff)
        {
            GetAllInfoByIDStaff_Result staff = _db.GetAllInfoByIDStaff(idStaff).FirstOrDefault();

            return staff;
        }

        public List<Staff> GetStaffByFilter(string idDepartment, string idStaff, string staffName)
        {
            List<Staff> list = _db.Accounts.Where(x => x.Type != "0" && x.Type != "2").Select(x => x.Staff).ToList();

            if (!string.IsNullOrEmpty(idDepartment))
            {
                list = list.Where(x => x.IDDepartment == idDepartment).ToList();
            }

            if (!string.IsNullOrEmpty(idStaff))
            {
                list = list.Where(x => x.IDStaff == idStaff).ToList();
            }

            if (!string.IsNullOrEmpty(staffName))
            {
                list = list.Where(x => x.StaffName.Contains(staffName)).ToList();
            }

            return list;
        }

        public string GetStaffNameByID(string idStaff)
        {
            string name = _db.Staffs.Where(x => x.IDStaff == idStaff).Select(x => x.StaffName).FirstOrDefault();

            return name;
        }

        public List<Staff> GetStaffByIDDepartment(string idDepartment)
        {
            List<Staff> list = _db.Staffs.Where(x => x.IDDepartment == idDepartment).ToList();

            return list;
        }

        public bool Add(Staff staff, Contract contract, Salary salary, Account account)
        {
            try
            {
                _db.Staffs.Add(staff);
                _db.SaveChanges();
                _db.Contracts.Add(contract);
                _db.SaveChanges();
                _db.Salaries.Add(salary);
                _db.SaveChanges();
                _db.Accounts.Add(account);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool AddAdmin(Staff staff)
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
                currentStaff.DateRange = staff.DateRange;
                currentStaff.IssueBy = staff.IssueBy;
                currentStaff.IDNation = staff.IDNation;
                currentStaff.IDAcademic = staff.IDAcademic;
                currentStaff.IDSpecialize = staff.IDSpecialize;

                currentStaff.Numberphone = staff.Numberphone;
                currentStaff.IDDepartment = staff.IDDepartment;
                currentStaff.Email = staff.Email;
                currentStaff.Sex = staff.Sex;
                currentStaff.IDPosition = staff.IDPosition;

                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool EditAdmin(Staff staff)
        {
            try
            {
                Staff currentStaff = GetSingleByID(staff.IDStaff);

                currentStaff.StaffName = staff.StaffName;
                currentStaff.Email = staff.Email;
                //currentStaff.Status = staff.Status;
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
                _db.RemoveAllInfoStaff(id);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool ChangeAvatar(string idStaff, string filename)
        {
            try
            {
                Staff currentStaff = GetSingleByID(idStaff);

                currentStaff.Image = filename;
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitStaff(string cccd)
        {
            var result = _db.Staffs.Where(x => x.CCCD == cccd).Any();

            return result;
        }

        public bool IsExistStaff(string id)
        {
            var result = _db.Staffs.Where(x => x.IDStaff == id).Any();

            return result;
        }
    }
}
