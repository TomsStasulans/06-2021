using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        private Account _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Account("Toms", 100);
        }

        [TestMethod]
        public void Balance_100_BalanceShouldBe100()
        {
            //Arrange
            var expected = 100;

            //Act
            var result = _target.Balance();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Name_Toms_NameShouldBeToms()
        {
            //Arrange
            var expected = "Toms";

            //Act
            var result = _target.Name;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Deposite_100_BalanceShouldBe200()
        {
            //Arrange
            var expected = 200;

            //Act
            _target.Deposit(100);

            //Assert
            Assert.AreEqual(expected, _target.Balance());
        }

        [TestMethod]
        public void Deposite_minus100_ShouldThrowException()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.Deposit(-100));
        }

        [TestMethod]
        public void Withdrawal_50_BalanceShouldBe50()
        {
            //Arrange
            var expected = 50;

            //Act
            _target.Withdrawal(50);

            //Assert
            Assert.AreEqual(expected, _target.Balance());
        }

        [TestMethod]
        public void Withdrawal_150_ShouldThrowExceptionNotEnoughMoney()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.Withdrawal(150));
        }

        [TestMethod]
        public void ToString_Toms100_ShouldBeToms100()
        {
            //Arrange
            var expected = "Toms: 100";

            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
