using System;

namespace Exercise_6
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
        }

        public override void EatFood(Food food, int amount)
        {
            if (food is Vegetable)
            {
                throw new Exception("Tigers are not eating that type of food!");
            }

            foodEaten += amount;
        }

        public override bool IsItTasty(Food typeOfFood)
        {
            return typeOfFood is Meat;
        }

        public override string MakeSound()
        {
            return "Roar";
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}