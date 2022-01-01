using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Volvo.Tests
{
    [TestClass]
    public class VolvoTests
    {
        private DragRace.Volvo _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new DragRace.Volvo();
        }

        [TestMethod]
        public void ShowCurrentSpeed_5_ShouldBe10()
        {
            //Arrange
            var expected = "5";
            _target.SpeedUp();

            //Act
            var result = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StartEngine_String_ShouldBeStringRumPumPum()
        {
            //Arrange
            var expected = "--- rum pum pum ---";

            //Act
            var result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpeedUp_5_ShouldBe5()
        {
            //Arrange
            var expected = "5";

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_5_ShouldBe0()
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
        public void SlowDown_50_ShouldThrowExceptionYouAreAlreadyStopped()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.SlowDown());
        }

        [TestMethod]
        public void UseNitrousOxideEngine_5_ShouldBe5()
        {
            //Arrange
            var expected = "100";

            //Act
            _target.UseNitrousOxideEngine();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}