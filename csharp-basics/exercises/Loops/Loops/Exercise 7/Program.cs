using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;
            Console.WriteLine("Welcome to Piglet!");

            while (true)
            {
                Random randomNumber = new Random();
                int points = randomNumber.Next(1, 12);
                Console.WriteLine("\nYou rolled a {0}", points);

                if (points == 1)
                {
                    Console.WriteLine("\nYou got 0 points.");
                    break;
                }
                else
                {
                    totalPoints += points;
                    Console.WriteLine("\nRoll again?");
                    var input = Console.ReadKey();
                    var character = input.KeyChar;

                    if (character == 'y')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nYou got {0} points.", totalPoints);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
