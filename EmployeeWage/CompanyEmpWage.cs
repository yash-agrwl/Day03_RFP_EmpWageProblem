using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class CompanyEmpWage
    {

        public string Company;
        public int EmpRatePerHr, NumOfWorkDays, MaxHrsPerMonth, TotalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth)
        {
            this.Company = company;
            this.EmpRatePerHr = empRatePerHr;
            this.NumOfWorkDays = numOfWorkDays;
            this.MaxHrsPerMonth = maxHrsPerMonth;
        }

        public void DisplayEmpWage()
        {
            Console.WriteLine($"Total Employee Wage for company {this.Company} is: " + this.TotalEmpWage);
        }
    }
}
