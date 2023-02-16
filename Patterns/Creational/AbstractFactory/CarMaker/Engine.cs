using System;

namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public abstract class Engine : CarPart
    {
        public virtual void Drive(Fuel fuel)
        {
            Console.WriteLine($"{Name} uses {fuel.Name}");
        }
    }
}
