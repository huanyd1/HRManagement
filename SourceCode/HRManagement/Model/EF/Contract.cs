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
    
    public partial class Contract
    {
        public Contract()
        {
            this.Staffs = new HashSet<Staff>();
        }
    
        public string IDContract { get; set; }
        public string ContractName { get; set; }
        public string ContractType { get; set; }
        public string IDType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string IDStaff { get; set; }
    
        public virtual ContractType ContractType1 { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
