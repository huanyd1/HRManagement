﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class SalaryDAO : BaseDAO
    {
        public List<Salary> GetAll()
        {
            List<Salary> list = _db.Salaries.ToList();

            return list;
        }

        public Salary GetSingleByID(string id)
        {
            Salary salary = _db.Salaries.Where(x => x.IDStaff == id).FirstOrDefault();

            return salary;
        }

        public List<AllInfoSalary> GetAllInfoSalaries()
        {
            List<AllInfoSalary> list = _db.AllInfoSalaries.ToList();

            return list;
        }

        public bool Add(Salary salary)
        {
            try
            {
                _db.Salaries.Add(salary);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Salary salary)
        {
            try
            {
                Salary currentSalary = GetSingleByID(salary.IDStaff);

                currentSalary.SalaryAmount = salary.SalaryAmount;
                currentSalary.Allowance = salary.Allowance;
                currentSalary.Tax = salary.Tax;
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
                Salary currentSalary = GetSingleByID(id);

                _db.Salaries.Remove(currentSalary);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitSalary(int salary)
        {
            var result = _db.Salaries.Where(x => x.SalaryAmount == salary).Any();

            return result;
        }
    }
}
