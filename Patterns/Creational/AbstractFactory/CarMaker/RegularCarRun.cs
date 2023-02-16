namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public class RegularCarRun : CarProductionRun
    {
        public override string Name => "Regular Car";

        public override Engine CreateEngine()
        {
            return new CombustionEngine();
        }

        public override Fuel CreateFuel()
        {
            return new Petrol();
        }

        public override FuelStorage CreateFuelStorage()
        {
            return new PetrolTank();
        }
    }
}
