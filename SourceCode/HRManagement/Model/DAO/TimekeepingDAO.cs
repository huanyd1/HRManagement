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

        public Timekeeping GetSingleByID(int id)
        {
            Timekeeping time = _db.Timekeepings.Where(x => x.IDTime == id).FirstOrDefault();

            return time;
        }

        public Timekeeping GetTimeByIDStaff(string id)
        {
            Timekeeping time = _db.Timekeepings.Where(x => x.IDStaff == id).FirstOrDefault();

            return time;
        }

        public Timekeeping GetTimeByIDStaffExplanation(int idTime, string idStaff)
        {
            Timekeeping time = _db.Timekeepings.Where(x => x.IDTime == idTime && x.IDStaff == idStaff).FirstOrDefault();

            return time;
        }

        public List<Timekeeping> GetTimeByIDStaffType()
        {

            List<Timekeeping> time = _db.Timekeepings.Where(x => x.Type == "1").ToList();

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

            if( time == null )
            {
                time = 0;
            }

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

        public bool AddBonus(string idStaff, int month, int bonus)
        {
            try
            {
                List<Timekeeping> lstTime = _db.Timekeepings.Where(t => t.IDStaff == idStaff).ToList();
                List<Timekeeping> lstChange = new List<Timekeeping>();
                foreach(var item in lstTime)
                {
                    var info = DateTime.Parse(item.Checkin.ToString());
                    if(info.Month == month)
                    {
                        lstChange.Add(item);
                    }
                }

                foreach(var item in lstChange)
                {
                    Timekeeping currentTime = GetSingleByID(item.IDTime);

                    currentTime.IDTime = currentTime.IDTime;
                    currentTime.IDStaff = currentTime.IDStaff;
                    currentTime.Checkin = currentTime.Checkin;
                    currentTime.Checkout = currentTime.Checkout;
                    currentTime.Type = currentTime.Type;
                    currentTime.Description = currentTime.Description;
                    currentTime.Bonus = bonus;
                    currentTime.Status = currentTime.Status;
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

        public bool AddCheckout(Timekeeping time)
        {
            try
            {
                Timekeeping currentTime = GetSingleByID(time.IDTime);

                //currentTime.IDTime = time.IDTime;
                //currentTime.IDStaff = time.IDStaff;
                //currentTime.Checkin = time.Checkin;
                currentTime.Checkout = time.Checkout;
                //currentTime.Type = time.Type;
                //currentTime.Description = time.Description;

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

        public bool AgreeExplanation(Timekeeping time)
        {
            try
            {
                Timekeeping currentTime = GetTimeByIDStaffExplanation(time.IDTime, time.IDStaff);

                currentTime.IDTime = time.IDTime;
                currentTime.IDStaff = time.IDStaff;
                currentTime.Checkin = time.Checkin;
                currentTime.Checkout = time.Checkout;
                currentTime.Type = time.Type;
                currentTime.Description = time.Description;
                currentTime.Status = time.Status;

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

        public bool DeleteExplanation(int idTime, string idStaff)
        {
            try
            {
                Timekeeping currentTime = GetTimeByIDStaffExplanation(idTime, idStaff);

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
