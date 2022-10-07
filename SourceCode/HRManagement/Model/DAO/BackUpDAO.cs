using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class BackUpDAO : BaseDAO
    {
        public bool BackUp(string path)
        {
            try
            {
                _db.BackUpDatabase(path);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Restore(string path)
        {
            try
            {
                _db.RestoreDatabase(path);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return true;
            }
            return true;
        }
    }
}
