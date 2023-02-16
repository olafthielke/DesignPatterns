using System;

namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public abstract class FuelStorage : CarPart
    {
        public virtual void Drive(Fuel fuel)
        {
            Console.WriteLine($"{fuel.Name} in {Name} is going down.");
        }
    }
}
