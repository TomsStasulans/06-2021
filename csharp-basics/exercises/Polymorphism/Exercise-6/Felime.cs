namespace Exercise_6
{
    public abstract class Felime : Mammal
    {
        protected Felime(string animalType, string animalName, double animalWeight, int foodEaten, string livingRegion)
            : base(animalType, animalName, animalWeight, foodEaten, livingRegion)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
            this.foodEaten = foodEaten;
            this.livingRegion = livingRegion;
        }
    }
}
