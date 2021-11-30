using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool WantToPlay = true;
            var word = ChooseRandomWord();
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            var tries = 0;

            while (guessable.IndexOf('_') != -1)
            {
                Console.WriteLine("You guesed: {0} {1}", tries, tries == 1 ? "time" : "times", tries);
                Console.WriteLine($"word: {guessable}");
                Console.WriteLine($"misess: {misses}");
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.WriteLine($"\nGuess: {guess}");
                

                if (IsLetterInWord(word, guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess)
                        {
                            var guessableWord = new StringBuilder(guessable);
                            guessableWord[i] = word[i];
                            guessable = guessableWord.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }

                tries++;

                if (misses.Length == 7)
                {
                    Console.WriteLine("You made 7 mistakes.It's too many. Try again?");
                }


                
            }
        }

        public static bool IsLetterInWord(string word, char guess)
        {
            return word.IndexOf(guess) != -1;
        }

        public static string ChooseRandomWord()
        {
            string[] words = { "ola", "jaka", "maks", "lelle" };
            var randomNumber = new Random();
            return words[randomNumber.Next(0, words.Length)];
        }
    }
}
