using System;

namespace Exercise_6
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Krkr";
        }

        public override void EatFood(Food food, int amount)
        {
            if (food is Meat)
            {
                throw new Exception("Zebras are not eating that type of food!");

            }

            foodEaten += amount;
        }

        public override bool IsItTasty(Food typeOfFood)
        {
            return typeOfFood is Vegetable;
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
