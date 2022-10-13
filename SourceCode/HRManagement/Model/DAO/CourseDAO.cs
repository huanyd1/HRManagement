using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CourseDAO : BaseDAO
    {
        public List<Course> GetAll()
        {
            List<Course> list = _db.Courses.ToList();

            return list;
        }

        public Course GetSingleByID(string id)
        {
            Course course = _db.Courses.Where(x => x.IDCourse == id).FirstOrDefault();

            return course;
        }

        public bool AddListCourse(List<Model.EF.Course> lstCourse)
        {
            foreach (var course in lstCourse)
            {
                try
                {
                    if (!IsExistIDCourse(course.IDCourse))
                    {
                        _db.Courses.Add(course);
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Model.NotificationCommon.Error(ex.Message);
                    return false;
                }
            }
            return true;
        }

        public bool Add(Course course)
        {
            try
            {
                _db.Courses.Add(course);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Course course)
        {
            try
            {
                Course currentCourse = GetSingleByID(course.IDCourse);

                currentCourse.CourseName = course.CourseName;
                currentCourse.Status = course.Status;
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
                Course currentCourse = GetSingleByID(id);

                _db.Courses.Remove(currentCourse);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitCourse(string name)
        {
            var result = _db.Courses.Where(x => x.CourseName == name).Any();

            return result;
        }

        public bool IsExistIDCourse(string id)
        {
            var result = _db.Courses.Where(x => x.IDCourse == id).Any();

            return result;
        }
    }
}
