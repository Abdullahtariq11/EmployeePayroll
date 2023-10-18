using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string Name,string Role,double Hourlyrate, int HoursWorked) 
        {
            this.Name = Name;
            this.Role = Role;
            this.HourlyRate = Hourlyrate;
            this.HoursWorked = HoursWorked;
       
        }

        public double CalculatePay()
        {
            var pay= HourlyRate*HoursWorked;
            return pay;
        }

      
    }
}
