namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public abstract class CarProductionRun
    {
        public abstract string Name { get; }

        public abstract Engine CreateEngine();
        public abstract Fuel CreateFuel();
        public abstract FuelStorage CreateFuelStorage();
    }
}
