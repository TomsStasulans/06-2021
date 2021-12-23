using System;

namespace Exercise_6
{
    internal class Tiger : Felime
    {
        private new string _livingRegion;

        public Tiger(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion) 
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
            _livingRegion = livingRegion;
        }
        
        public override void EatFood(Food food, int amount)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
            else
            {
                foodEaten += amount;
            }
        }

        public override bool IsItTasty(Food typeOfFood)
        {
            if (typeOfFood is Meat)
            {
                return true;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
