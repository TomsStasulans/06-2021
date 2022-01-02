using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_1;

namespace Exercise1.Tests
{
    [TestClass]
    public class Exercise1Tests
    {
        private FifteenMagic _target;

        [TestMethod]
        public void IsAnyNumberFifteen_TwoNumbers_IfAnyIsFifteenShouldReturnTrue()
        {
            //Arrange
            _target = new FifteenMagic(15, 16);
            //Act
            bool result = _target.IsAnyNumberFifteen();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSumOrDifferenceFifteen_TwoNumbers_IfSumOrDifferenceFifteenShouldReturnFalse()
        {
            //Arrange
            _target = new FifteenMagic(4, 16);
            //Act
            bool result = _target.IsSumOrDifferenceFifteen();
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSumOrDifferenceFifteen_TwoNumbers_IfSumOrDifferenceFifteenShouldReturnTrue()
        {
            //Arrange
            _target = new FifteenMagic(10, 5);
            //Act
            bool result = _target.IsSumOrDifferenceFifteen();
            //Assert
            Assert.IsTrue(result);
        }
    }
}
