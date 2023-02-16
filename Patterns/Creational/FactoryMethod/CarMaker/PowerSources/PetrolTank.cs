using System;

namespace Patterns.Creational.FactoryMethod.CarMaker.PowerSources
{
    public class FuelTank : EnergyStore
    {
        public override string Type => "Fuel Tank";

        public override void Refuel()
        {
            Console.WriteLine($"\tFill up for $100 in 5 minutes.");
        }
    }
}
