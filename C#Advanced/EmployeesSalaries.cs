using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Advanced
{
    internal class EmployeesSalaries
    {
        static List<Employee> employees = new List<Employee>();

        public static List<Employee> CreateList()
        {
            for (int i = 0; i < 100; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Bonus = Random.Shared.Next(100, 501),
                    Deductions = Random.Shared.Next(0, 100)
                });
            }
            return employees;

        }

        public delegate bool ShouldCalculate(Employee employee);
        public static void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deductions;
                    Console.WriteLine($"{employee.Id} - {employee.Name} Salary = {salary}");
                }

            }
        }
    }
}
