using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_Ottomars12234567_ShouldContainOttomars()
        {
            //Arrange
            var expected = "12234567";

            //Act
            _target.PutNumber("Ottomars", "12234567");

            //Assert
            Assert.AreEqual(expected, _target.GetNumber("Ottomars"));
        }

        [TestMethod]
        public void GetNumber_janis_ShouldBeNull()
        {
            //Act
            var number = _target.GetNumber("janis");

            //Assert
            Assert.AreEqual(null, number);
        }

        [TestMethod]
        public void PutNumber_NameIsNull_ShouldThrowException()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber(null, "1234567"));
        }

        [TestMethod]
        public void PutNumber_NumberIsNull_ShouldThrowException()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber("Toms", null));
        }
    }
}
