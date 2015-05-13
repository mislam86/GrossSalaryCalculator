using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSalaryCalculator
{
    class Salary
    {
        public string employeeName;
        public double employeeBasicSalary;
        public double houseRent;
        public double medicalAllowance;

        public double CalculateSalary()
        {
            return employeeBasicSalary + (employeeBasicSalary*houseRent)/100 +
                   (medicalAllowance*employeeBasicSalary)/100;
        }
    }
}
