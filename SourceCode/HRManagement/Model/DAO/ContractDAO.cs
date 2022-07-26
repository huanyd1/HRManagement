using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class ContractDAO : BaseDAO
    {
        public List<Contract> GetAll()
        {
            List<Contract> list = _db.Contracts.ToList();

            return list;
        }

        public List<AllInfoContract> GetAllInfoContract()
        {
            List<AllInfoContract> list = _db.AllInfoContracts.ToList();

            return list;
        }

        public List<AllInfoContract> GetContractByFilter(string idContract, string contractName, string idType)
        {
            List<AllInfoContract> list = _db.AllInfoContracts.ToList();

            if (!string.IsNullOrEmpty(idContract))
            {
                list.Where(x => x.IDContract.Contains(idContract));
            }

            if (!string.IsNullOrEmpty(contractName))
            {
                list.Where(x => x.ContractName.Contains(contractName));
            }

            if (!string.IsNullOrEmpty(idType))
            {
                list.Where(x => x.IDType == idType);
            }

            return list.ToList();
        }

        public Contract GetSingleByID(string id)
        {
            Contract contract = _db.Contracts.Where(x => x.IDContract == id).FirstOrDefault();

            return contract;
        }

        public List<Contract> GetContractByIDType(string id)
        {
            List<Contract> list = _db.Contracts.Where(x => x.IDType == id).ToList();

            return list;
        }

        public bool Add(Contract contract)
        {
            try
            {
                _db.Contracts.Add(contract);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Contract contract)
        {
            try
            {
                Contract currentContract = GetSingleByID(contract.IDContract);

                currentContract.ContractName = contract.ContractName;
                currentContract.ContractType = contract.ContractType;
                currentContract.IDType = contract.IDType;
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
                Contract currentContract = GetSingleByID(id);

                _db.Contracts.Remove(currentContract);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitContract(string name)
        {
            var result = _db.Contracts.Where(x => x.ContractName == name).Any();

            return result;
        }
    }
}
