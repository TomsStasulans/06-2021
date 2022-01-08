using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_1.Tests
{
    [TestClass]
    public class ProductTests
    {
        private Product _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Product(40.00, 6, "Toma Krekls");
        }

        [TestMethod]
        public void PrintProduct_TomaKrekls40and6_ShouldBeEqual()
        {
            //Arrange
            var expected = "Toma Krekls, 40, 6";

            //Act
            var result = _target.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
