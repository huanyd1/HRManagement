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

        public bool IsExistReport(string idStaff, int month)
        {
            var date = Convert.ToDateTime(string.Format(month + "/" + 15 + "/" + DateTime.Now.Year));
            var result = _db.ReportSalaryDailies.Where(t => t.IDStaff == idStaff && t.Month == date).Any();

            return result;
        }
    }
}
