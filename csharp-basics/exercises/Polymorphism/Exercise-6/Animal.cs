namespace Exercise_6
{
    public abstract class Animal
    {
        protected string animalName;
        protected string animalType;
        protected double animalWeight;
        protected int foodEaten;

        public abstract string MakeSound();

        public abstract void EatFood(Food food, int amount);

        public abstract bool IsItTasty(Food typeOfFood);
    }
}
