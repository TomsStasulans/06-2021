using System;

namespace Exercise_6
{
    internal class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Krkr");
        }

        public override void EatFood(Food food, int amount)
        {
            if (food is Vegetable)
            {
                foodEaten += amount;
            }
            else
            {
                Console.WriteLine("Zebras are not eating that type of food!");
            }
        }

        public override bool IsItTasty(Food typeOfFood)
        {
            if (typeOfFood is Vegetable)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
