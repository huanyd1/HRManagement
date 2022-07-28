using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AccountDAO : BaseDAO
    {
        public List<Account> GetAll()
        {
            List<Account> list = _db.Accounts.ToList();

            return list;
        }

        public List<AllInfoAccount> GetAllInfoAccounts()
        {
            List<AllInfoAccount> list = _db.AllInfoAccounts.ToList();

            return list;
        }

        public Account GetSingleByID(string id)
        {
            Account contract = _db.Accounts.Where(x => x.IDStaff == id).FirstOrDefault();

            return contract;
        }

        public bool Add(Account account)
        {
            try
            {
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

        public bool Edit(Account account)
        {
            try
            {
                Account currentAccount = GetSingleByID(account.IDStaff);

                currentAccount.Username = account.Username;
                currentAccount.Password = account.Password;
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
                Account currentAccount = GetSingleByID(id);

                _db.Accounts.Remove(currentAccount);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitAccount(string username)
        {
            var result = _db.Accounts.Where(x => x.Username == username).Any();

            return result;
        }
    }
}
