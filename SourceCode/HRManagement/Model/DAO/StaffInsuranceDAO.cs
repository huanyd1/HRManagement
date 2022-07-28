using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class StaffInsuranceDAO : BaseDAO
    {
        public StaffInsurance GetSingleByID(int id)
        {
            StaffInsurance staffInsurance = _db.StaffInsurances.Where(x => x.IDStaffInsurance == id).FirstOrDefault();

            return staffInsurance;
        }

        public List<string> GetAllInsuranceByIDStaff(string idStaff)
        {
            List<string> list = _db.StaffInsurances.Where(x => x.IDStaff == idStaff).Select(x => x.IDInsurance).ToList();

            return list;
        }

        public List<AllInfoStaffInsurance> AllInfoStaffInsurance()
        {
            List<AllInfoStaffInsurance> info = _db.AllInfoStaffInsurances.ToList();

            return info;
        }
        public List<AllInfoStaffInsurance> GetAllInsuranceByFilter(string staffName, string idInsurance)
        {
            List<AllInfoStaffInsurance> list = _db.AllInfoStaffInsurances.ToList();

            if (!string.IsNullOrEmpty(staffName))
            {
                list = list.Where(t => t.StaffName.Contains(staffName)).ToList();
            }

            if (!string.IsNullOrEmpty(idInsurance))
            {
                list = list.Where(t => t.IDInsurance == idInsurance).ToList();
            }

            return list;
        }

        public List<AllInfoStaffInsurance> AllInfoStaffInsuranceByIDStaff(string idStaff)
        {
            List<AllInfoStaffInsurance> info = _db.AllInfoStaffInsurances.Where(x => x.IDStaff == idStaff).ToList();

            return info;
        }

        public bool Add(List<string> lstIDInsurance, string idStaff)
        {
            try
            {
                foreach (var item in lstIDInsurance)
                {
                    StaffInsurance staffInsurance = new StaffInsurance();
                    staffInsurance.IDStaff = idStaff;
                    staffInsurance.IDInsurance = item;
                    _db.StaffInsurances.Add(staffInsurance);
                    _db.SaveChanges();
                }

                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(int idStaffInsurance)
        {
            try
            {
                StaffInsurance currentInsurance = GetSingleByID(idStaffInsurance);

                _db.StaffInsurances.Remove(currentInsurance);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
    }
}
