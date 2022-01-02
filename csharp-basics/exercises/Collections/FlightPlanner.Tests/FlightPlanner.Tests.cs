using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class FightPlannerTests
    {
        private FlightPlanner _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new FlightPlanner();
        }

        [TestMethod]
        public void DisplayCities_ListWithCities_ShouldBeStringOfCities()
        {
            //Arrange
            var cities = new List<string>();
            cities.Add("Riga");
            cities.Add("Liepaja");
            cities.Add("Ogre");
            var expected = "Riga Liepaja Ogre";

            //Act
            var result = _target.DisplayCities(cities);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FlightsToList_ArrayOfCities_ShouldBeListOfCities()
        {
            //Arrange
            string[] givenArray = {"Riga", "Liepaja", "Ogre"};
            List<string> expected = new List<string>() { "Riga", "Liepaja", "Ogre" };

            //Act
            var result = _target.FlightsToList(givenArray);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SplitRoute_ArrayOfCities_ShouldBeTwoStrings()
        {
            //Arrange
            var givenString = "Riga -> Liepaja";
            string[] expected = { "Riga", "Liepaja" };

            //Act
            var result = _target.SplitRoute(givenString);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddCitiesToHashset_String_ShouldBeHashsetOfTwoStrings()
        {
            //Arrange
            string[] givenString = { "Riga -> Liepaja" };
            HashSet<string> expected = new HashSet<string> { "Riga", "Liepaja" };

            //Act
            var result = _target.AddCitiesToHashset(givenString);

            //Assert
            Assert.IsTrue(expected.SetEquals(result));
        }
    }
}
