using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine().ToLower();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        result += 2;
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        result += 3;
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        result += 4;
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        result += 5;
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        result += 6;
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        result += 7;
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        result += 8;
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        result += 9;
                        break;
                    default:
                        result += "?";
                        break;
                }
            }

            if (result.Contains("?"))
            {
                Console.WriteLine("Not all characters are letters");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
