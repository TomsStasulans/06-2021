using Exercise_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cat.Tests
{
    [TestClass]
    public class CatTests
    {
        private Exercise_6.Cat _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Exercise_6.Cat("Cat", "Kakis", 1, 0, "World", "Nice");
        }

        [TestMethod]
        public void MakeSound_Meow_ShouldBeStringMeow()
        {
            //Arrange
            var expected = "Meow";


            //Act
            var result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_1Meat_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Cat[Kakis, , 1, World, 1]";
            Food food = new Meat();
            //Act
            _target.EatFood(food, 1);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [TestMethod]
        public void IsItTasty_1Meat_ShouldBeTrue()
        {
            //Arrange
            Food food = new Vegetable();
            //Act
            var result = _target.IsItTasty(food);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_1Meat_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Cat[Kakis, , 1, World, 0]";
            Food food = new Meat();
            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
