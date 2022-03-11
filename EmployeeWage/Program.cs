using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.\n");

            int empWage = Employee.CalculateEmpWage();
            Console.WriteLine("Total working Day is: " + Employee.TotalWorkDays);
            Console.WriteLine("Total Working Hours is: " + Employee.TotalEmpHrs + "\n");
            Console.WriteLine("And the Employee Wage for the month is: " + empWage + "\n");
        }
    }
}
