using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_6;

namespace Arrays_Exercise_6.Tests
{
    [TestClass]
    public class Exercise6Tests
    {
        private ArrayOfTen _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new ArrayOfTen();
        }

        [TestMethod]
        public void ArrayOfTenRandomNumbers_tenElements_ShouldHaveTenRandomNumbers()
        {
            //Act
            var newArray = _target.ArrayOfTenRandomNumbers();
            //Assert
            Assert.AreEqual(newArray.Length, 10);
        }

        [TestMethod]
        public void GetDuplicateArray_tenElements_ShouldHaveSameNumbers()
        {
            //Act
            var first = _target.ArrayOfTenRandomNumbers();
            var second = _target.GetDuplicateArray();
            //Assert
            CollectionAssert.AreEqual(first, second);
        }

        [TestMethod]
        public void GetArray_tenElements_LastElementShouldBeDifferent()
        {
            //Act
            var second = _target.ArrayWithLastElementChanged();
            //Assert
            Assert.AreEqual(-7, second[9]);
        }
    }
}
