using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class ContractTypeDAO : BaseDAO
    {
        public List<ContractType> GetAll()
        {
            List<ContractType> list = _db.ContractTypes.ToList();

            return list;
        }

        public ContractType GetSingleByID(string id)
        {
            ContractType contractType = _db.ContractTypes.Where(x => x.IDType == id).FirstOrDefault();

            return contractType;
        }

        public bool Add(ContractType contractType)
        {
            try
            {
                _db.ContractTypes.Add(contractType);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(ContractType contractType)
        {
            try
            {
                ContractType currentContractType = GetSingleByID(contractType.IDType);

                currentContractType.TypeName = contractType.TypeName;
                _db.SaveChanges();
            }
            catch(Exception ex)
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
                ContractType currentContractType = GetSingleByID(id);

                _db.ContractTypes.Remove(currentContractType);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitContractType(string name)
        {
            var result = _db.ContractTypes.Where(x => x.TypeName == name).Any();

            return result;
        }

        public string GetIDContractTypeByName(string name)
        {
            string idAcademic = _db.ContractTypes.Where(t => t.TypeName == name).Select(t => t.IDType).FirstOrDefault();

            return idAcademic;
        }
    }
}
