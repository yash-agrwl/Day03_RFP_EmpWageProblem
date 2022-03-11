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
        const int WagePerHr = 20;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;
        const int NumWorkingDays = 20;
        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
        public static int CalculateEmpWage()
        {
            int empHrs, TotalEmpHrs = 0;
            for (int day = 1; day <= NumWorkingDays; day++)
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
                TotalEmpHrs += empHrs;
            }
            
            int empWage = TotalEmpHrs * Employee.WagePerHr;
            return empWage;
        }
    }
}
