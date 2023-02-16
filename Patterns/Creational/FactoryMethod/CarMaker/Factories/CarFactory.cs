using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    public abstract class CarFactory
    {
        // This is the Factory Method. It combines part standard build (chassis, number of wheels),
        // and part custom build (motor, energy store). The custom build Make methods are overridable
        // (here: abstract, but could also be virtual). We provide custom implementions via specific
        // child car factories (ElectricCarFactory, PetrolCarFactory, etc.).
        public Car Make()
        {
            // Build standard chassis
            var chassis = new Chassis();

            // Make specialised engine.
            var motor = MakeMotor();

            // Make specialised power source.
            var energyStore = MakeEnergyStore();

            // Initialise standard number of wheels.
            var numberOfWheels = 4;

            // ...

            var car = new Car(chassis, motor, energyStore, numberOfWheels);

            // ...

            return car;
        }


        protected abstract Motor MakeMotor();
        protected abstract EnergyStore MakeEnergyStore();
    }
}
