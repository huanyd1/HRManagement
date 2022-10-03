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
            List<AllInfoAccount> list = _db.AllInfoAccounts.Where(t=>t.Type == "4").ToList();

            return list;
        }

        public List<AllInfoAccount> GetInfoAccountsManager()
        {
            List<AllInfoAccount> list = _db.AllInfoAccounts.Where(t => t.Type != "4" && t.Type != "0").ToList();

            return list;
        }

        public string GetInfoTypeLogin(string username, string password)
        {
            string type = _db.Accounts.Where(x => x.Username == username && x.Password == password).Select(x => x.Type).FirstOrDefault();

            if(type == null)
            {
                return null;
            }

            return type;
        }

        public string GetIDStaffByLogin(string username, string password)
        {
            string idStaff = _db.Accounts.Where(x => x.Username == username && x.Password == password).Select(x => x.IDStaff).FirstOrDefault();

            return idStaff;
        }

        public string GetPasswordByIDStaff(string idStaff)
        {
            string password = _db.Accounts.Where(x => x.IDStaff == idStaff).Select(x => x.Password).FirstOrDefault();

            return password;
        }

        public Account GetSingleByID(string id)
        {
            Account account = _db.Accounts.Where(x => x.IDStaff == id).FirstOrDefault();

            return account;
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

                currentAccount.IDStaff = account.IDStaff;
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

        public bool ChangePassword(string idStaff, string oldPass, string newPass)
        {
            try
            {
                Account currentStaff = GetSingleByID(idStaff);

                if(currentStaff.Password != oldPass)
                {
                    return false;
                }
                else
                {
                    currentStaff.Password = newPass;
                    _db.SaveChanges();
                }
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
