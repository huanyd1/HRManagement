using Model.EF;
using System;
using System.Collections.Generic;
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
                currentTime.Checkoout = time.Checkoout;
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
