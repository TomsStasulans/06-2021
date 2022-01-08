using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BMW.Tests
{
    [TestClass]
    public class BmWTests
    {
        private DragRace.Bmw _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new DragRace.Bmw();
        }

        [TestMethod]
        public void ShowCurrentSpeed_CallMethode_ShouldBe10()
        {
            //Arrange
            var expected = "10";
            _target.SpeedUp();

            //Act
            var result = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StartEngine_CallMethode_ShouldBeStringRrrrrrr()
        {
            //Arrange
            var expected = "Rrrrrrr.....";

            //Act
            var result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpeedUp_CallMethode_ShouldBe5()
        {
            //Arrange
            var expected = "10";

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_CallMethode_ShouldBe0()
        {
            //Arrange
            var expected = "0";
            _target.SpeedUp();

            //Act
            _target.SlowDown();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_CallMethode_ShouldThrowExceptionYouAreAlreadyStopped()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.SlowDown());
        }
    }
}
