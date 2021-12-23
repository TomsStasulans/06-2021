using System;

namespace Exercise_6
{
    internal class Cat : Felime
    {
        private string _breed;
        public Cat(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion, string breed) 
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
            breed = _breed;
        }

        public override void EatFood(Food food, int amount)
        {
            foodEaten += amount;
        }

        public override bool IsItTasty(Food typeOfFood)
        {
            if (typeOfFood is Vegetable || typeOfFood is Meat)
            {
                return true;
            }

            return false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {_breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
