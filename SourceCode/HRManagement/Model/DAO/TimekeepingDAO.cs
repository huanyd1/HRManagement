using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class TimekeepingDAO : BaseDAO
    {
        public List<Timekeeping> GetAll()
        {
            List<Timekeeping> list = _db.Timekeepings.ToList();

            return list;
        }

        public Timekeeping GetTimeByIDStaff(string id)
        {
            Timekeeping time = _db.Timekeepings.Where(x => x.IDStaff == id).FirstOrDefault();

            return time;
        }

        public bool IsExistTimekeeping(string idStaff, DateTime checkin)
        {
            var date = checkin.Date;
            return _db.Timekeepings.Where(t => t.IDStaff == idStaff && t.Checkin.Value.Date == date).Any();
        }

        public List<GetTimekeepingByMonth_Result> GetAllInfoTimekeeping(string idDepartment, int month)
        {
            List<GetTimekeepingByMonth_Result> timekeeping = _db.GetTimekeepingByMonth(idDepartment, month).ToList();

            return timekeeping;
        }

        public bool Add(Timekeeping time)
        {
            try
            {
                _db.Timekeepings.Add(time);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Timekeeping time)
        {
            try
            {
                Timekeeping currentTime = GetTimeByIDStaff(time.IDStaff);

                currentTime.Checkin = time.Checkin;
                currentTime.Checkout = time.Checkout;
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
                Timekeeping currentTime = GetTimeByIDStaff(id);

                _db.Timekeepings.Remove(currentTime);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitTimekeeping(string id)
        {
            var result = _db.Timekeepings.Where(x => x.IDStaff == id && x.Checkin.Value.Date != DateTime.Now.Date).Any();

            return result;
        }
    }
}
