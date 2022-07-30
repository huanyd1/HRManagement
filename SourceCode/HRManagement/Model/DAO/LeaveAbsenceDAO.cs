using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class LeaveAbsenceDAO : BaseDAO
    {
        //Xin nghi phep

        public List<LeaveAbsence> GetAll()
        {
            List<LeaveAbsence> list = _db.LeaveAbsences.ToList();

            return list;
        }

        public LeaveAbsence GetSingleByID(int id)
        {
            LeaveAbsence leave = _db.LeaveAbsences.Where(x => x.IDLeaveAbsence == id).FirstOrDefault();

            return leave;
        }

        public List<LeaveAbsence> GetListLeaveAbsenceByID(string id)
        {
            List<LeaveAbsence> listByID = _db.LeaveAbsences.Where(x => x.IDStaff == id).ToList();

            return listByID;
        }

        public int GetRemainByIDStaff(string idStaff)
        {
            int remain = int.Parse(_db.Staffs.Where(x => x.IDStaff == idStaff).Select(x => x.Remain).FirstOrDefault().ToString());

            return remain;
        }

        public bool Add(LeaveAbsence leaveAbsence)
        {
            try
            {
                _db.LeaveAbsences.Add(leaveAbsence);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(LeaveAbsence leave)
        {
            try
            {
                LeaveAbsence currentLeaveAbsence = GetSingleByID(leave.IDLeaveAbsence);

                currentLeaveAbsence.IDStaff = currentLeaveAbsence.IDStaff;
                currentLeaveAbsence.FromDate = currentLeaveAbsence.FromDate;
                currentLeaveAbsence.ToDate = currentLeaveAbsence.ToDate;
                currentLeaveAbsence.TotalDay = currentLeaveAbsence.TotalDay;
                currentLeaveAbsence.Descript = currentLeaveAbsence.Descript;
                currentLeaveAbsence.Status = leave.Status;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                LeaveAbsence currentLeaveAbsence = GetSingleByID(id);

                _db.LeaveAbsences.Remove(currentLeaveAbsence);
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
