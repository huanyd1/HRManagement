using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class StaffCourseDAO : BaseDAO
    {
        //public List<StaffCourse> GetAll()
        //{
        //    List<StaffCourse> list = _db.StaffCourses.ToList();

        //    return list;
        //}

        //public StaffCourse GetSingleByID(string idStaff, string idCourse)
        //{
        //    StaffCourse userCourse = _db.StaffCourse.Where(x => x.IDStaff == idStaff && x.IDCourse == idCourse).FirstOrDefault();

        //    return userCourse;
        //}

        //public bool Add(UserCourse userCourse)
        //{
        //    try
        //    {
        //        _db.UserCourses.Add(userCourse);
        //        _db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        Model.NotificationCommon.Error(ex.Message);
        //        return false;
        //    }
        //    return true;
        //}

        //public bool Edit(UserCourse userCourse)
        //{
        //    try
        //    {
        //        UserCourse currentCourse = GetSingleByID(userCourse.IDStaff, userCourse.IDCourse);

        //        currentCourse.IDCourse = userCourse.IDCourse;
        //        currentCourse.IDStaff = userCourse.IDStaff;
        //        _db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        Model.NotificationCommon.Error(ex.Message);
        //        return false;
        //    }
        //    return true;
        //}

        //public bool Delete(string idStaff, string idCourse)
        //{
        //    try
        //    {
        //        UserCourse currentCourse = GetSingleByID(idStaff, idCourse);

        //        _db.UserCourses.Remove(currentCourse);
        //        _db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        Model.NotificationCommon.Error(ex.Message);
        //        return false;
        //    }
        //    return true;
        //}

        //public bool IsExitUserCourse(string idStaff, string idCourse)
        //{
        //    var result = _db.UserCourses.Where(x => x.IDStaff == idStaff && x.IDCourse == idCourse).Any();

        //    return result;
        //}
    }
}
