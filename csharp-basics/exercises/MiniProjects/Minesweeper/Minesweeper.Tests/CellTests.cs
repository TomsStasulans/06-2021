using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Core;
using Xunit;
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
        }

        [TestMethod]
        public void OnFlag_ShouldReturnFlaggedCell()
        {
            //Arrange
            var expected = _target.CellType == CellType.Flagged;
            _target.CellState = CellState.Closed;
            _target.CellType = CellType.Regular;
            //Act
            _target.OnFlag();
            //Assert
           // Assert.AreEqual(expected, );
        }
    }
}