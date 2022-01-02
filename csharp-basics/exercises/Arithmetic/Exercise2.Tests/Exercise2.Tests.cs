using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_2;

namespace Exercise2.Tests
{
    [TestClass]
    public class Exercise2Tests
    {
        public OddOrEven _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new OddOrEven(3);
        }

        [TestMethod]
        public void CheckTheNumber_GiveOddNumber_ShouldFail()
        {
            //Act
            bool result = _target.CheckIfEven();
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckTheNumber_GiveOddNumber_ShouldPass()
        {
            //Act
            bool result = _target.CheckIfOdd();
            //Assert
            Assert.IsTrue(result);
        }
    }
}
