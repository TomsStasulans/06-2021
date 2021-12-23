using System;

namespace Exercise_6
{
    internal class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Pepee");
        }

        public override void EatFood(Food food, int amount)
        {
            throw new NotImplementedException();
        }
        public override bool IsItTasty(Food typeOfFood)
        {
            return true;
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
