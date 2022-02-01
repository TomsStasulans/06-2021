using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Core;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Minesweeper.Tests
{
    [TestClass]
    public class BoardTests
    {
        private Board _target;
        private Minesweeper _minesweeper;
        private Cell _cell;

        [TestInitialize]

        public void Setup()
        {
            _minesweeper = new Minesweeper();
            _target = new Board(_minesweeper, 9, 9, 10);
            _cell = new Cell();
            _target.SetupCell(0, 0, CellType.Flagged);
        }
        
        [TestMethod]
        public void SetupBoard_ShouldReturn9x9Board()
        {
            //Arrange
            var expected = 81;
            //Act
            _target.SetupBoard();
            var result = _target.Cells.Length;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetBombs_ShouldReturn10Bombs()
        {
            //Arrange
            var expected = _target.NumMines;
            //Act
            var result = _target.GetBombs(10).Count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FlaggedOrFlaggedMine_Cell_ShouldBeTrue()
        {
            //Arrange
            var cell = _target.Cells[0, 0];
            //Act
            var res = _target.FlaggedOrFlaggedMine(cell);
            //Assert
            Assert.IsTrue(res);
        }
    }
}
