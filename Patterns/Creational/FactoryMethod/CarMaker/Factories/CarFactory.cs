using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    public abstract class CarFactory
    {
        public Car Assemble()
        {
            var chassis = new Chassis();
            var motor = MakeMotor();
            var energyStore = MakeEnergyStore();
            var numberOfWheels = 4;

            return new Car(chassis, motor, energyStore, numberOfWheels);
        }

        protected abstract Motor MakeMotor();
        protected abstract EnergyStore MakeEnergyStore();
    }
}
