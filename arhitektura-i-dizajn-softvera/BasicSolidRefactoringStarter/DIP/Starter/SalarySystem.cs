using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.DIP.Starter
{
    public static class SalarySystem
    {
        public static void Flow()
        {
            Employee employee = new Employee();
            employee.Name = "John";
            employee.HoursWorked = 40;
            employee.HourlyRate = 10;
            Console.WriteLine(employee.GetSalary());
        }
    }

    public class SalaryCalculator2022
    {
        public decimal CalculateSalary(decimal hoursWorked, decimal hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal GetSalary()
        {
            SalaryCalculator2022 salaryCalculator = new SalaryCalculator2022();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
