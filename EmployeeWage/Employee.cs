using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {

        const int IsFullTime = 1;
        const int IsPartTime = 2;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;

        string Company;
        int EmpRatePerHr, NumOfWorkDays, MaxHrsPerMonth, TotalEmpWage;

        public Employee(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth)
        {
            this.Company = company;
            this.EmpRatePerHr = empRatePerHr;
            this.NumOfWorkDays = numOfWorkDays;
            this.MaxHrsPerMonth = maxHrsPerMonth;
        }

        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }

        public void CalculateEmpWage()
        {
            int empHrs=0, totalEmpHrs=0, totalWorkDays=0;

            Console.WriteLine($"\nDetails of an Employee working in {this.Company} are:");

            while (totalWorkDays < this.NumOfWorkDays && totalEmpHrs < this.MaxHrsPerMonth)
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
            this.TotalEmpWage = totalEmpHrs * this.EmpRatePerHr;
        }

        public void DisplayEmpWage()
        {
            Console.WriteLine($"Total Employee Wage for company {this.Company} is: " + this.TotalEmpWage);
        }
    }
}
