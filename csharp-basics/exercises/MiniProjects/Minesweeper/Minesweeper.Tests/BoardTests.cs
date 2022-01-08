﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Core;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Minesweeper.Tests
{
    [TestClass]
    public class BoardTests
    {
        private Board _target;
        private Minesweeper _minesweeper;

        [TestInitialize]

        public void Setup()
        {
            _minesweeper = new Minesweeper();
            _target = new Board(_minesweeper, 9, 9, 10);
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
    }
}
