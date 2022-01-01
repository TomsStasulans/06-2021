using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lada.Tests
{
    [TestClass]
    public class LadaTests
    {
        private DragRace.Lada _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new DragRace.Lada();
        }

        [TestMethod]
        public void ShowCurrentSpeed_50_ShouldBe10()
        {
            //Arrange
            var expected = "50";
            _target.SpeedUp();

            //Act
            var result = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StartEngine_String_ShouldBeStringRrrrrrr()
        {
            //Arrange
            var expected = "--- rum rum rum ---";

            //Act
            var result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpeedUp_50_ShouldBe5()
        {
            //Arrange
            var expected = "50";

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_50_ShouldBe0()
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
    }
}
