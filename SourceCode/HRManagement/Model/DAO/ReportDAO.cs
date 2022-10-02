﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ReportDAO : BaseDAO
    {
        public List<EarningsReport_Result> GetEarningsReport()
        {
            List<EarningsReport_Result> results = _db.EarningsReport().ToList();

            return results;
        }

        public List<StaffVolatility_Result> GetStaffVolatility(int year)
        {
            List<StaffVolatility_Result> results = _db.StaffVolatility(year).ToList();

            return results;
        }

        public List<TotalStaffByDepartment_Result> GetTotalStaffByDepartment()
        {
            List<TotalStaffByDepartment_Result> results = _db.TotalStaffByDepartment().ToList();

            return results;
        }

    }
}
