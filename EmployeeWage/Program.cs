using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            Employee Dmart = new Employee("DMart",20,5,30);
            Employee Reliance = new Employee("Reliance",10,4,20);

            Dmart.CalculateEmpWage();
            Reliance.CalculateEmpWage();

            Console.WriteLine();

            Dmart.DisplayEmpWage();         
            Reliance.DisplayEmpWage();
        }
    }
}
