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
    
    public partial class Salary
    {
        public Salary()
        {
            this.Staffs = new HashSet<Staff>();
        }
    
        public string IDSalary { get; set; }
        public Nullable<int> SalaryAmount { get; set; }
        public Nullable<int> Allowance { get; set; }
        public Nullable<int> Tax { get; set; }
    
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
