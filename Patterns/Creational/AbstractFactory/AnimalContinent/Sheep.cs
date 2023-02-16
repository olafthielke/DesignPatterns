namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    public class Sheep : Herbivore
    {
        public override string Name => "Sheep";

        public override string MakeSound()
        {
            return "Bah Bah";
        }
    }
}
