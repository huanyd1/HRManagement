//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.UserCourses = new HashSet<UserCourse>();
        }
    
        public string IDCourse { get; set; }
        public string CourseName { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
