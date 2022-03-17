using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IsAbsent = 0;
        const int IsFullTime = 1;
        const int IsPartTime = 2;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;

        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
        public static void CalculateEmpWage(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth)
        {
            int empHrs=0, totalEmpHrs=0, totalWorkDays=0;

            Console.WriteLine($"Details of an Employee working in {company} are:");

            while (totalWorkDays < numOfWorkDays && totalEmpHrs < maxHrsPerMonth)
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
            int empWage = totalEmpHrs * empRatePerHr;

            Console.WriteLine($"Total Employee Wage for company {company} is: " + empWage + "\n");
        }
    }
}
