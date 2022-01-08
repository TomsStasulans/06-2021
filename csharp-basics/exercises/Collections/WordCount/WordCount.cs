using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        public string _textFromFile = "../../lear.txt";

        public string GetTextFromFile()
        {
            return System.IO.File.ReadAllText(_textFromFile);
        }

        public int GetLineCount()
        {
            return File.ReadLines(_textFromFile).Count();
        }

        public int GetWordCount()
        {
            return GetTextFromFile().Split(' ').ToList().Count;
        }

        public int GetCharCount()
        {
            return GetTextFromFile().ToCharArray().Count();
        }

    }
}