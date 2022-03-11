using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int Is_Present = 1;
        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        public static void Attendance()
        {
            int empCheck = Employee.Check();
            if (empCheck == Is_Present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
