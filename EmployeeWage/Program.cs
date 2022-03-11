using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.\n");

            int empCheck = Employee.Check();
            string empStatus = Employee.Attendance(empCheck);
            Console.WriteLine("Employee is " + empStatus + "\n");

            int empWage = Employee.DailyEmpWage(empCheck);
            Console.WriteLine("The Daily Employee Wage is: " + empWage + "\n");
        }
    }
}
