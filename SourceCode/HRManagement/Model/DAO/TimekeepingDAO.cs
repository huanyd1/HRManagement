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

        public IsExistCheckTime_Result IsExistTimekeeping(string idStaff, DateTime checkin)
        {
            return _db.IsExistCheckTime(idStaff, checkin).FirstOrDefault();
        }

        public List<GetTimekeepingByMonth_Result> GetInfoTimeByFilter(string idDepartment, string staffName, int month)
        {
            List<GetTimekeepingByMonth_Result> timekeeping = _db.GetTimekeepingByMonth(idDepartment, month).ToList();

            if (!string.IsNullOrEmpty(staffName))
            {
                timekeeping = timekeeping.Where(t => t.StaffName.Contains(staffName)).ToList();
            }

            return timekeeping;
        }

        public List<GetTimekeepingByMonth_Result> GetAllInfoTimekeeping(string idDepartment, int month)
        {
            List<GetTimekeepingByMonth_Result> timekeeping = _db.GetTimekeepingByMonth(idDepartment, month).ToList();

            return timekeeping;
        }

        public int totalTime (string idDepartment, int month, string idStaff)
        {
            var time = _db.GetTimekeepingByMonth(idDepartment, month).Where(x => x.IDStaff == idStaff).Select(x => x.TotalTime).FirstOrDefault();

            int totalTime = int.Parse(time.ToString());

            return totalTime;
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

                currentTime.IDTime = time.IDTime;
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

        public bool IsExitExplanation(string idStaff, DateTime date)
        {
            var result = _db.Timekeepings.Where(x => x.IDStaff == idStaff && x.Checkin.Value.Date != date).Any();

            return result;
        }
    }
}
