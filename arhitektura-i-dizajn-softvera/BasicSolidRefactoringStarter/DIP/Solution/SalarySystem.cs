using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.DIP.Solution
{
    public static class SalarySystem
    {
        public static void Flow()
        {
            Employee employee = new Employee(new SalaryCalculator2022());
            employee.Name = "John";
            employee.HoursWorked = 40;
            employee.HourlyRate = 10;
            Console.WriteLine(employee.GetSalary());
        }
    }

    public interface ISalaryCalculator
    {
        decimal CalculateSalary(decimal hoursWorked, decimal hourlyRate);
    }

    public class SalaryCalculator2022 : ISalaryCalculator
    {
        public decimal CalculateSalary(decimal hoursWorked, decimal hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }

    public class Employee
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public string Name { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public Employee(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public decimal GetSalary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
