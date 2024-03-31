using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{

    //public class PetrolCarFactory
    //{
    //    public PetrolCar Assemble()
    //    {
    //        var chassis = new Chassis();
    //        var engine = new PetrolEngine();
    //        var fueltank = new FuelTank();
    //        var numberOfWheels = 4;

    //        return new PetrolCar(chassis, 
    //            engine, 
    //            fueltank,
    //            numberOfWheels);
    //    }
    //}




    public class PetrolCarFactory : CarFactory
    {
        protected override Motor MakeMotor()
        {
            return new PetrolEngine();
        }

        protected override EnergyStore MakeEnergyStore()
        {
            return new FuelTank();
        }
    }
}
