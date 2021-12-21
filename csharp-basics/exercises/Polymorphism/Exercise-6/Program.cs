using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                string[] input1 = Console.ReadLine().Split(' ');
                if (input1.Length == 1 && input1[0] == "End" )
                {
                    break;
                }
                string animalType = input1[0];
                string animalName = input1[1];
                double animalWeight = double.Parse(input1[2]);
                int foodEaten = int.Parse(input1[3]);
                string livingRegion = input1[4];

                if (input1.Length == 6)
                {
                    string breed = input1[5];
                    Cat cat = new Cat(animalType, animalName, animalWeight, foodEaten, livingRegion, breed);
                    animals.Add(cat);
                }
                else if (animalType == "Tiger")
                {
                    Tiger tiger = new Tiger(animalType, animalName, animalWeight, foodEaten, livingRegion);
                    animals.Add(tiger);
                }
                else if (animalType == "Zebra")
                {
                    Zebra zebra = new Zebra(animalType, animalName, animalWeight, foodEaten, livingRegion);
                    animals.Add(zebra);
                }
                else if (animalType == "Mouse")
                {
                    Mouse mouse = new Mouse(animalType, animalName, animalWeight, foodEaten, livingRegion);
                    animals.Add(mouse);
                }
                else if (input1[0] == "End")
                {
                    break;
                }

                animals.Last().MakeSound();

                string[] input2 = Console.ReadLine().Split(' ');
                string foodType = input2[0];
                int foodAmount = int.Parse(input2[1]);

                var food = new List<Food>();

                if (foodType == "Vegetable")
                {
                    Vegetable vegetable = new Vegetable(foodAmount);
                    food.Add(vegetable);
                }
                else
                {
                    Meat meat = new Meat(foodAmount);
                    food.Add(meat);
                }

                animals.Last().EatFood(food.Last(), foodAmount);

                if (animals.Last().IsItTasty(food.Last()))
                {
                    Console.WriteLine(animals.Last().ToString());
                }
            }

            Console.WriteLine(string.Join(", ", animals));
            Console.ReadKey();
        }
    }
}
