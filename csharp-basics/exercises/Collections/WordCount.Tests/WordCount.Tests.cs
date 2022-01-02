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
        public void GetLinesCount_TextFile_ShouldBe6()
        {
            //Act
            var linesCount = _target.GetLineCount();
            //Assert
            Assert.AreEqual(6, linesCount);
        }

        [TestMethod]
        public void GetWordsCount_TextFile_ShouldBe39()
        {
            //Act
            var wordsCount = _target.GetWordCount();
            //Assert
            Assert.AreEqual(39, wordsCount);
        }

        [TestMethod]
        public void GetLines_TextFile_ShouldBe258()
        {
            //Act
            var charCount = _target.GetCharCount();
            //Assert
            Assert.AreEqual(258, charCount);
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
