using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            Employee manager = new();

            manager.AddCompanyEmpWage("DMart",20,5,30);
            manager.AddCompanyEmpWage("Reliance",10,4,20);

            manager.CalculateEmpWage();
        }
    }
}
