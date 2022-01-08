using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_6;

namespace Mouse.Tests
{
    [TestClass]
    public class MouseTests
    {
        private Exercise_6.Mouse _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Exercise_6.Mouse("Mouse", "Pele", 1, 0, "World");
        }

        [TestMethod]
        public void MakeSound_CallMethode_ShouldBeStringPepee()
        {
            //Arrange
            var expected = "Pepee";
            

            //Act
            var result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_1Meat_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Mouse[Pele, 1, World, 1]";
            Food food = new Meat();
            //Act
            _target.EatFood(food, 1);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [TestMethod]
        public void IsItTasty_Meat_ShouldBeTrue()
        {
            //Arrange
            Food food = new Meat();
            //Act
            var result = _target.IsItTasty(food);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_CallMethode_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Mouse[Pele, 1, World, 0]";

            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
