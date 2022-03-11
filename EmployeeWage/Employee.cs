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
        const int WagePerHr = 20;
        const int FullTimeHr = 8;
        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        public static string Attendance(int empCheck)
        {
            if (empCheck == IsAbsent)
                return "Absent";
            else
                return "Present";          
        }
        public static int DailyEmpWage(int empCheck)
        {
            int empHrs;
            if (empCheck == IsFullTime)
                empHrs = FullTimeHr;
            else
                empHrs = 0;
            int empWage = empHrs * Employee.WagePerHr;
            return empWage;
        }
    }
}
