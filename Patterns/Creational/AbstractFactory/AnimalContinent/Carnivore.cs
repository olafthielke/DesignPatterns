using System;

namespace Patterns.Creational.AbstractFactory.AnimalContinent
{
    public abstract class Carnivore : Animal
    {
        public virtual void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{Name} eats {herbivore.Name}");
        }
    }
}
