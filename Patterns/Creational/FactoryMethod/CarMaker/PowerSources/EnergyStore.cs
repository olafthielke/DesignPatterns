namespace Patterns.Creational.FactoryMethod.CarMaker.PowerSources
{
    public abstract class EnergyStore
    {
        public abstract string Type { get; }

        public abstract void Refuel();
    }
}
