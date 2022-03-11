using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.\n");

            int empWage = Employee.CalculateEmpWage();
            Console.WriteLine("The Employee Wage for a month is: " + empWage + "\n");
        }
    }
}
