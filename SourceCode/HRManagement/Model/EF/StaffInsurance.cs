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
    
    public partial class StaffInsurance
    {
        public int IDStaffInsurance { get; set; }
        public string IDStaff { get; set; }
        public string IDInsurance { get; set; }
    
        public virtual Insurance Insurance { get; set; }
        public virtual Staff Staff { get; set; }
    }
}