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
    
    public partial class GetTimeSheetsByMonthAndIDStaff_Result
    {
        public string IDDepartment { get; set; }
        public string DepartmentName { get; set; }
        public string IDStaff { get; set; }
        public string StaffName { get; set; }
        public string Username { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<int> SalaryAmount { get; set; }
        public Nullable<int> Allowance { get; set; }
        public Nullable<int> Tax { get; set; }
        public string InsuranceName { get; set; }
        public Nullable<int> Amount { get; set; }
    }
}
