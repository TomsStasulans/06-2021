using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_6;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6Tests
    {
        private CozaLozaWoza _target;

        [TestMethod]
        public void GetANumber_CheckNumber_IfModuleOfNumberIsZeroShouldReturnCoza()
        {
            //Arrange
            _target = new CozaLozaWoza( 12);
            //Act
            string result = _target.ReturnCoza();
            //Assert
            Assert.AreEqual("Coza", result);
        }

        [TestMethod]
        public void GetANumber_CheckNumber_IfModuleOfNumberIsZeroShouldReturnLoza()
        {
            //Arrange
            _target = new CozaLozaWoza(10);
            //Act
            string result = _target.ReturnLoza();
            //Assert
            Assert.AreEqual("Loza", result);
        }

        [TestMethod]
        public void GetANumber_CheckNumber_IfModuleOfNumberIsZeroShouldReturnWoza()
        {
            //Arrange
            _target = new CozaLozaWoza(21);
            //Act
            string result = _target.ReturnWoza();
            //Assert
            Assert.AreEqual("Woza", result);
        }

        [TestMethod]
        public void GetANumber_CheckNumber_IfModuleOfNumberIsZeroShouldReturnNumber()
        {
            //Arrange
            _target = new CozaLozaWoza(11);
            //Act
            string result = _target.ReturnNumber();
            //Assert
            Assert.AreEqual("11", result);
        }
    }
}
