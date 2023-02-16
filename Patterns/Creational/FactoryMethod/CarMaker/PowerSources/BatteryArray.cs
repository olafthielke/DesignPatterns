using System;

namespace Patterns.Creational.FactoryMethod.CarMaker.PowerSources
{
    public class BatteryArray : EnergyStore
    {
        public override string Type => "Battery Array";

        public override void Refuel()
        {
            Console.WriteLine("\tRecharges for $2 in 60 minutes.");
        }
    }
}
