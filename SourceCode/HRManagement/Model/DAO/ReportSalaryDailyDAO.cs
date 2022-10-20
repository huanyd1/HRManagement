using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ReportSalaryDailyDAO : BaseDAO
    {
        public bool Add(ReportSalaryDaily daily)
        {
            try
            {
                _db.ReportSalaryDailies.Add(daily);
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
