using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CircleArea_5_ShouldReturn78Point5()
        {
            //Arrange
            var radius = 5;
            var expected = 78.5;
            //Act
            var result = Math.Round(Geometry.AreaOfCircle(radius), 1);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RectangleArea_5_7_ShouldReturn35()
        {
            //Arrange
            var expected = 35;
            var length = 7;
            var width = 5;
            //Act
            var result = Geometry.AreaOfRectangle(length, width);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleArea_5_10_ShouldReturn25()
        {
            //Arrange
            var expected = 25;
            var height = 10;
            var ground = 5;
            //Act
            var result = Geometry.AreaOfTriangle(height, ground);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
