﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class StaffCourseDAO : BaseDAO
    {
        public List<string> GetAllCourseByIDStaff(string idStaff)
        {
            List<string> list = _db.StaffCourses.Where(x => x.IDStaff == idStaff).Select(x => x.IDCourse).ToList();

            return list;
        }

        public List<AllInfoStaffCourse> GetAllCourseByFilter(string staffName, string idCourse)
        {
            List<AllInfoStaffCourse> list = _db.AllInfoStaffCourses.ToList();

            if (!string.IsNullOrEmpty(staffName))
            {
                list = list.Where(t => t.StaffName.Contains(staffName)).ToList();
            }

            if (!string.IsNullOrEmpty(idCourse))
            {
                list = list.Where(t => t.IDCourse == idCourse).ToList();
            }

            return list;
        }

        public List<AllInfoStaffCourse> AllInfoStaffCourse()
        {
            List<AllInfoStaffCourse> info = _db.AllInfoStaffCourses.ToList();

            return info;
        }

        public List<AllInfoStaffCourse> AllInfoStaffCourseByIDStaff(string idStaff)
        {
            List<AllInfoStaffCourse> info = _db.AllInfoStaffCourses.Where(x => x.IDStaff == idStaff).ToList();

            return info;
        }

        public List<AllInfoStaffCourse> AllCourseCompleteByIDStaff(string idStaff)
        {
            List<AllInfoStaffCourse> info = _db.AllInfoStaffCourses.Where(x => x.IDStaff == idStaff && x.Point >= 80).ToList();

            return info;
        }

        public StaffCourse GetSingleByID(int id)
        {
            StaffCourse staffCourse = _db.StaffCourses.Where(x => x.IDStaffCourse == id).FirstOrDefault();

            return staffCourse;
        }

        public bool Add(List<string> lstIDCourse, string idStaff)
        {
            try
            {
                foreach(var item in lstIDCourse)
                {
                    StaffCourse staffCourse = new StaffCourse();
                    staffCourse.IDStaff = idStaff;
                    staffCourse.IDCourse = item;
                    staffCourse.Point = 0;
                    staffCourse.Result = "0";
                    _db.StaffCourses.Add(staffCourse);
                    _db.SaveChanges();
                }

                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(int idStaffCourse)
        {
            try
            {
                StaffCourse currentCourse = GetSingleByID(idStaffCourse);

                _db.StaffCourses.Remove(currentCourse);
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
