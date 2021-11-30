using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = GetMenu();

            if (menuChoice < 1 || menuChoice > 4)
            {
                Console.WriteLine("\nThere is no such choice");
            }
            else if (menuChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (menuChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (menuChoice == 3)
            {
                CalculateTriangleArea();
            }
            else if(menuChoice == 4)
            {
                Console.WriteLine("\nBye!");
            }

            Console.ReadKey();
        }

        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            char input = keyboard.KeyChar;
            userChoice = int.Parse(input.ToString());

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("\nWhat is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length;
            decimal width;

            Console.WriteLine("\nEnter length ");
            length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter width ");
            width = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground;
            decimal height;

            Console.WriteLine("\nEnter length of the triangle's base? ");
            ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
