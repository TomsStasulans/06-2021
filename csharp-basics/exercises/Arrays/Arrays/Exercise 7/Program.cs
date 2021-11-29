using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chars = new char[,] {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

            Console.WriteLine("Hello lets start the game!");

            for (int i = 1; i <= 9; i++)
            {
                char player;
                player = i % 2 != 0 ? 'X' : 'O';

                Console.WriteLine($"\n{player}, choose your location (row, column):");
                string input = Console.ReadLine();
                int[] coordinatesArray = Array.ConvertAll(input.Split(' '), int.Parse);
                chars[coordinatesArray[0], coordinatesArray[1]] = player;

                ShowField(chars);

                if (DoWeHaveAWinner(chars))
                {
                    Console.WriteLine($"\n{player} won!!! Congratulations!");
                    break;
                }
                else if (i == 9 && !(DoWeHaveAWinner(chars)))
                {
                    Console.WriteLine("The game is a tie.");
                }
            }

            Console.ReadKey();
        }
        public static bool DoWeHaveAWinner(char[,] chars)
        {
            if (chars[0, 0] == chars[0, 1] && chars[0, 0] == chars[0, 2] && chars[0, 0] != '-')
            {
                return true;
            }

            if (chars[1, 0] == chars[1, 1] && chars[1, 0] == chars[1, 2] && chars[1, 0] != '-')
            {
                return true;
            }

            if (chars[2, 0] == chars[2, 1] && chars[2, 0] == chars[2, 2] && chars[2, 0] != '-')
            {
                return true;
            }

            if (chars[0, 0] == chars[1, 0] && chars[0, 0] == chars[2, 0] && chars[0, 0] != '-')
            {
                return true;
            }

            if (chars[0, 1] == chars[1, 1] && chars[0, 1] == chars[2, 1] && chars[0, 1] != '-')
            {
                return true;
            }

            if (chars[0, 2] == chars[1, 2] && chars[0, 2] == chars[2, 2] && chars[0, 2] != '-')
            {
                return true;
            }

            if (chars[0, 0] == chars[1, 1] && chars[0, 0] == chars[2, 2] && chars[0, 0] != '-')
            {
                return true;
            }

            if (chars[2, 0] == chars[1, 1] && chars[2, 0] == chars[0, 2] && chars[2, 0] != '-')
            {
                return true;
            }

            return false;
        }

        public static void ShowField(char[,] chars)
        {
            Console.WriteLine();

            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(chars[k, j]);
                }

                Console.WriteLine("    --+-+--");
                Console.WriteLine();
            }
        }
    }
}
