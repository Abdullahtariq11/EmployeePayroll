using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class PayrollSystem
    {
        private List<Employee> Employees;

        public PayrollSystem()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void ProcessPayroll()
        {
            foreach (Employee employee in Employees)
            {
                
                Console.WriteLine("Name: " + employee.Name+ ", Role: "+ employee.Role + ", Pay: " + employee.CalculatePay());
            }
        }

    }
}
