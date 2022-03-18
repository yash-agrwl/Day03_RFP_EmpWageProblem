using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee : IComputeEmpWage
    {

        const int IsFullTime = 1;
        const int IsPartTime = 2;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;

        private int NumOfCompany=0;
        private readonly CompanyEmpWage[] CompanyEmpWageArray;

        public Employee()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth)
        {
            CompanyEmpWageArray[this.NumOfCompany] = new CompanyEmpWage(company, empRatePerHr, numOfWorkDays, maxHrsPerMonth);
            NumOfCompany++;
        }

        public static int Check()
        {
            Random random = new();
            return random.Next(0, 3);
        }

        public void CalculateEmpWage()
        {
            for(int i = 0; i < NumOfCompany; i++)
            {
                CalculateEmpWage(this.CompanyEmpWageArray[i]);
                this.CompanyEmpWageArray[i].DisplayEmpWage();
            }
        }

        private static void CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs, totalEmpHrs=0, totalWorkDays=0;

            Console.WriteLine($"\nDetails of an Employee working in {companyEmpWage.Company} are:");

            while (totalWorkDays < companyEmpWage.NumOfWorkDays && totalEmpHrs < companyEmpWage.MaxHrsPerMonth)
            {
                int empCheck = Employee.Check();
                switch (empCheck)
                {
                    case IsFullTime:
                        empHrs = FullTimeHr;
                        break;
                    case IsPartTime:
                        empHrs = PartTimeHr;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                totalWorkDays++;
                Console.WriteLine("Day#:" + totalWorkDays + " Emp Hrs: " + empHrs);
            }
            companyEmpWage.TotalEmpWage = totalEmpHrs * companyEmpWage.EmpRatePerHr;
        }
    }
}
