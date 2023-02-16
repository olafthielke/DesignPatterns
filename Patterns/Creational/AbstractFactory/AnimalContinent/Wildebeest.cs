namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    public class Wildebeest : Herbivore
    {
        public override string Name => "Wildebeest";

        public override string MakeSound()
        {
            return "Scrunch Scrunch";
        }
    }
}
