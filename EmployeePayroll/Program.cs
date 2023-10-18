using EmployeePayroll;

PayrollSystem _payroll;
_payroll = new PayrollSystem();
Employee Ceo = new Employee("Abdullah", "CEO",85,40);
Employee Manager = new Employee("Sameen", "Manager", 45, 40);
_payroll.AddEmployee(Ceo);
_payroll.AddEmployee(Manager);
_payroll.ProcessPayroll();