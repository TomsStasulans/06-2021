namespace Exercise_6
{
    public class Cat : Felime
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

        public override bool IsItTasty(Food typeOfFood) => true;

        public override string MakeSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {_breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
