using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_13_part_01_ua
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> GetAllEmployees(this IEnumerable<Employee> employees)
        {
            return employees;
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryGreaterThan(this IEnumerable<Employee> employees, decimal minSalary)
        {
            return employees.Where(e => e.Salary > minSalary);
        }

        public static IEnumerable<Employee> GetManagerEmployees(this IEnumerable<Employee> employees)
        {
            return employees.Where(e => e.Position.ToLower() == "manager");
        }

        public static IEnumerable<Employee> GetEmployeesWithPhoneNumberStartingWith(this IEnumerable<Employee> employees, string prefix)
        {
            return employees.Where(e => e.ContactNumber.StartsWith(prefix));
        }

        public static IEnumerable<Employee> GetEmployeesWithEmailStartingWith(this IEnumerable<Employee> employees, string prefix)
        {
            return employees.Where(e => e.Email.StartsWith(prefix));
        }

        public static IEnumerable<Employee> GetEmployeesWithName(this IEnumerable<Employee> employees, string name)
        {
            return employees.Where(e => e.FullName.Contains(name));
        }
    }
}
