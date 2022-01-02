namespace Exercise_6
{
    public abstract class Mammal : Animal
    {
        protected string livingRegion;

        protected Mammal(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
            this.foodEaten = foodEaten;
            this.livingRegion = livingRegion;
        }
    }
}
