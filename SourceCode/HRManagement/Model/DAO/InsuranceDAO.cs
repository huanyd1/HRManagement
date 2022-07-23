using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class InsuranceDAO : BaseDAO
    {
        public List<Insurance> GetAll()
        {
            List<Insurance> list = _db.Insurances.ToList();

            return list;
        }

        public Insurance GetSingleByID(string id)
        {
            Insurance insurance = _db.Insurances.Where(x => x.IDInsurance == id).FirstOrDefault();

            return insurance;
        }

        public bool Add(Insurance insurance)
        {
            try
            {
                _db.Insurances.Add(insurance);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Insurance insurance)
        {
            try
            {
                Insurance currentInsurance = GetSingleByID(insurance.IDInsurance);

                currentInsurance.InsuranceName = insurance.InsuranceName;
                currentInsurance.Amount = insurance.Amount;
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
                Insurance currentInsurance = GetSingleByID(id);

                _db.Insurances.Remove(currentInsurance);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitInsurance(string name)
        {
            var result = _db.Insurances.Where(x => x.InsuranceName == name).Any();

            return result;
        }
    }
}
