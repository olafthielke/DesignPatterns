
namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public class ElectricCarRun : CarProductionRun
    {
        public override string Name => "Electric Car";

        public override Engine CreateEngine()
        {
            return new ElectricMotor();
        }

        public override Fuel CreateFuel()
        {
            return new Electricity();
        }

        public override FuelStorage CreateFuelStorage()
        {
            return new Battery();
        }
    }
}
