using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface IComputeEmpWage
    {

        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth);

        public void CalculateEmpWage();
    }
}
