using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_8.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private CalculateSalary _target;

        [TestMethod]
        public void AddBasePayAndHoursWorked_TwoNumbers_ShouldReturn414comma1()
        {
            //Arrange
            _target = new CalculateSalary(8.2, 47);
            //Act
            double result = _target.CalculateTotalPay();
            //Assert
            Assert.AreEqual(414.1, result);
        }

        [TestMethod]
        public void CheckBasePayAndHoursWorked_EmployeesSalary_ShouldFail()
        {
            //Arrange
            _target = new CalculateSalary(7.5, 35);

            //Act
            double employee = _target.CalculateTotalPay();

            //Assert
            Assert.ThrowsException<IncorrectTotalPayException>(() => _target.CorrectTotalPay());
        }
    }
}
