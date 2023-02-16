using System;

namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    public class AnimalWorld
    {
        private Herbivore Herbivore { get; }
        private Carnivore Carnivore { get; }


        public AnimalWorld(Continent continent)
        {
            Herbivore = continent.CreateHerbivore();
            Carnivore = continent.CreateCarnivore();
        }

        public void Run()
        {
            Console.WriteLine($"{Herbivore.Name} says '{Herbivore.MakeSound()}'");
            Carnivore.Eat(Herbivore);
        }
    }
}
