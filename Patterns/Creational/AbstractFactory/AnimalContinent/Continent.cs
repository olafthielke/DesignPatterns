namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    // Maybe this could be a car factory (producing electric cars and petrol and diesel cars.

    public abstract class Continent
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
