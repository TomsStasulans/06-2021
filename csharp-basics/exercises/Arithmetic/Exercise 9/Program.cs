using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your weight in kg and I will tell if your BMI index is ok");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Also provide me your height in meters");
            double height = double.Parse(Console.ReadLine());

            double weightInPounds = weight * 2.2046;
            double heightInInches = height * 39.3701;

            double BMI = weightInPounds * 703 / Math.Pow(heightInInches, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI is too low. You are underweight.");
            } 
            else if (BMI > 25)
            {
                Console.WriteLine("Your BMI is too high. You are overweight.");
            }
            else
            {
                Console.WriteLine("Your BMI is optimal. Congratulations!");
            }
            Console.ReadKey();
        }
    }
}