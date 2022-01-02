using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountTests
    {
        private WordCount _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new WordCount();
        }

        [TestMethod]
        public void GetLineCount_CallMethode_ShouldBe6()
        {
            //Arrange
            var expected = 6;
            //Act
            var linesCount = _target.GetLineCount();
            //Assert
            Assert.AreEqual(expected, linesCount);
        }

        [TestMethod]
        public void GetWordsCount_TextFile_ShouldBe39()
        {
            //Arrange
            var expected = 39;
            //Act
            var wordsCount = _target.GetWordCount();
            //Assert
            Assert.AreEqual(expected, wordsCount);
        }

        [TestMethod]
        public void GetLines_TextFile_ShouldBe258()
        {
            //Arrange
            var expected = 258;
            //Act
            var charCount = _target.GetCharCount();
            //Assert
            Assert.AreEqual(expected, charCount);
        }

        [TestMethod]
        public void GetLinesCount_TextFile_ShouldBeString()
        {
            //Act
            var text = _target.GetTextFromFile();
            //Assert
            Assert.AreEqual(typeof(string), text.GetType());
        }
    }
}
