using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.\n");

            Employee.CalculateEmpWage("DMart",20,5,30);
            Employee.CalculateEmpWage("Reliance",10,4,20);
        }
    }
}
