using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class GravityCalculatorTests
    {
        private CalculateGravity _target;

        [TestMethod]
        public void CalculateFinalPositionWhenFallingTenSeconds_MethodeCall_ShouldBe490comma5()
        {
            //Arrange
            _target = new CalculateGravity();
            var expected = 490.5;
            //Act
            double result = _target.CalculateFinalPositionWhenFallingTenSeconds();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
