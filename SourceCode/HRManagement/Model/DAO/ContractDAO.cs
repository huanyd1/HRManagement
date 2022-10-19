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

        public GetAllInfoContract_Result GetAllInfoContract(string idStaff)
        {
            GetAllInfoContract_Result info = _db.GetAllInfoContract(idStaff).FirstOrDefault();

            return info;
        }

        public List<AllInfoContract> GetContractByFilter(string idStaff, string staffName, string idType)
        {
            List<AllInfoContract> list = _db.AllInfoContracts.ToList();

            if (!string.IsNullOrEmpty(idStaff))
            {
                list = list.Where(x => x.IDStaff == idStaff).ToList();
            }

            if (!string.IsNullOrEmpty(staffName))
            {
                list = list.Where(x => x.ContractName.Contains(staffName)).ToList();
            }

            if (!string.IsNullOrEmpty(idType))
            {
                list = list.Where(x => x.IDType == idType).ToList();
            }

            return list;
        }

        public Contract GetSingleByID(string id)
        {
            Contract contract = _db.Contracts.Where(x => x.IDStaff == id).FirstOrDefault();

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

        public bool Edit(Contract contract, Staff staff)
        {
            try
            {
                Contract currentContract = GetSingleByID(contract.IDStaff);

                currentContract.ContractName = contract.ContractName;
                currentContract.ContractType = contract.ContractType;
                currentContract.NumberContract = contract.NumberContract;
                currentContract.IDType = contract.IDType;
                _db.SaveChanges();

                StaffDAO staffDAO = new StaffDAO();

                Staff currentStaff = staffDAO.GetSingleByID(contract.IDStaff);
                currentStaff.StartDate = staff.StartDate;
                currentStaff.EndDate = staff.EndDate;
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
