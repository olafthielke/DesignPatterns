using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    public class ElectricCarFactory : CarFactory
    {
        protected override Motor MakeMotor()
        {
            return new ElectricMotor();
        }

        protected override EnergyStore MakeEnergyStore()
        {
            return new BatteryArray();
        }
    }
}
