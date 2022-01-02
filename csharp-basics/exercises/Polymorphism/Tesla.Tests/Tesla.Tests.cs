using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tesla.Tests
{
    [TestClass]
    public class TeslaTests
    {
        private DragRace.Tesla _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new DragRace.Tesla();
        }

        [TestMethod]
        public void ShowCurrentSpeed_CallMethode_ShouldBe10()
        {
            //Arrange
            var expected = "15";
            _target.SpeedUp();

            //Act
            var result = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StartEngine_CallMethode_ShouldBeStringRumPumPum()
        {
            //Arrange
            var expected = "-- silence ---";

            //Act
            var result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpeedUp_CallMethode_ShouldBe5()
        {
            //Arrange
            var expected = "15";

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
