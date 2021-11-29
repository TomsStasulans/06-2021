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
            string[] words = { "ola", "jaka", "maks", "lelle" };
            var randomNumber = new Random();
            var word = words[randomNumber.Next(0, words.Length)];

            var guessable = new string('_', word.Length);
            var misses = string.Empty;

            while (guessable.IndexOf('_') != -1)
            {
                Console.WriteLine($"word: {guessable}");
                Console.WriteLine($"misess:");
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.WriteLine(guess);
                Console.WriteLine($"Guess: {guess}");
                

                if (word.IndexOf(guess) > -1)
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

                Console.ReadKey();
            }
        }
    }
}
