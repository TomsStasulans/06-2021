using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it!");
            int guesedNumber = int.Parse(Console.ReadLine());

            if (guesedNumber > randomNumber)
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of {0}.", randomNumber);
            } 
            else if (guesedNumber < randomNumber)
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of {0}.", randomNumber);
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds ?!?");
            }
            Console.ReadKey();
        }
    }
}
