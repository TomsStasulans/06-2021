using Exercise_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Zebra.Tests
{
    [TestClass]
    public class ZebraTests
    {
        private Exercise_6.Zebra _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Exercise_6.Zebra("Zebra", "Zuze", 100, 0, "Africa");
        }

        [TestMethod]
        public void MakeSound_Roar_ShouldBeStringRoar()
        {
            //Arrange
            var expected = "Krkr";
            //Act
            var result = _target.MakeSound();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EatFood_1Vegetable_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Zebra[Zuze, 100, Africa, 1]";
            Food food = new Vegetable();
            //Act
            _target.EatFood(food, 1);
            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [TestMethod]
        public void EatFood_1Meat_FoodEatenShouldThrowException()
        {
            //Arrange
            Food food = new Meat();
            //Assert
            Assert.ThrowsException<Exception>(() => _target.EatFood(food, 1));
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
        public void IsItTasty_1Vegetable_ShouldBeFalse()
        {
            //Arrange
            Food food = new Meat();
            //Act
            var result = _target.IsItTasty(food);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToString_1Meat_FoodEatenShouldBe1()
        {
            //Arrange
            var expected = "Zebra[Zuze, 100, Africa, 0]";
            Food food = new Meat();
            //Act
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
