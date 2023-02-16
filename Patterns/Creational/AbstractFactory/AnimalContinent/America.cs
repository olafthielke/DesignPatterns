namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    public class America : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Sheep();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Battery();
        }
    }
}
