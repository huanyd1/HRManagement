using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class InsuranceTypeDAO : BaseDAO
    {
        public List<InsuranceType> GetAll()
        {
            List<InsuranceType> list =  _db.InsuranceTypes.ToList();

            return list;
        }

        public string GetNameTypeByID(string idInsurance)
        {
            string type = _db.InsuranceTypes.Where(x => x.IDInsuranceType == idInsurance).Select(x => x.TypeName).FirstOrDefault();

            return type;
        } 

        public bool Add(InsuranceType type)
        {
            try
            {
                _db.InsuranceTypes.Add(type);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitInsuranceType(string name)
        {
            var result = _db.InsuranceTypes.Where(x => x.TypeName == name).Any();

            return result;
        }
    }
}
