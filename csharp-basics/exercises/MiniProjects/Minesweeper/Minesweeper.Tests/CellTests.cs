using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Core;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Minesweeper.Tests
{
    [TestClass]
    public class CellTests
    {
        private Cell _target;

        [TestInitialize]

        public void Setup()
        {
            _target = new Cell();
            _target.SetupDesign();
            _target.CellType = CellType.Regular;
            _target.CellState = CellState.Closed;
        }

        [TestMethod]
        public void OnFlag_ShouldReturnFlaggedCell()
        {
            //Arrange
            var expected = CellType.Flagged;
            //Act
            _target.OnFlag();
            var result = _target.CellType;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OffFlag_ShouldReturnFlaggedCell()
        {
            //Arrange
            var expected = CellType.Regular;
            //Act
            _target.OnFlag();
            _target.OffFlag();
            var result = _target.CellType;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsOutside_ShouldReturnTrue()
        {
            //Arrange
            int x = _target.XLoc = -1;
            int y = _target.YLoc = 0;
            //Act
            var result = _target.IsOutside(x, y);
            //Assert
            Assert.IsTrue(result);
        }
    }
}