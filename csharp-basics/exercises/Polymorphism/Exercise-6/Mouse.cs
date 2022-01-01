namespace Exercise_6
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "Pepee";
        }

        public override void EatFood(Food food, int amount)
        {
            foodEaten += amount;
        }
        public override bool IsItTasty(Food typeOfFood) => true;

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
