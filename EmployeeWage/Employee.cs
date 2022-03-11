using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        public const int Is_Absent = 0;
        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
        public static string Attendance()
        {
            int empCheck = Employee.Check();
            if (empCheck == Is_Absent)
                return "Absent";
            else
                return "Present";           
        }
    }
}
