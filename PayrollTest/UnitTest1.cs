using EmployeePayroll;

namespace PayrollTest
{
    public class Tests
    {
        private double computed_pay;
        [SetUp]
        public void Setup()
        {
            PayrollSystem _payroll;
            _payroll = new PayrollSystem();
            Employee Developer= new Employee("Mustafa","Developer",68.5,40);
            _payroll.AddEmployee(Developer);
            computed_pay=Developer.CalculatePay();
        }

        [Test]
        public void CalculateCorrectPay()
        {
            
            double expected_pay = 2740;
            Assert.That(computed_pay, Is.EqualTo(2740));
        }
    }
}