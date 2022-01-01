using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_5.Tests
{
    [TestClass]
    public class DateTests
    {
        private Date _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Date(2022, 1, 1);
        }

        [TestMethod]
        public void DisplayDate_20220101_ShouldBeEqual()
        {
            //Arrange
            var expected = "1/1/2022";

            //Act
            var result = _target.DisplayDate();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
