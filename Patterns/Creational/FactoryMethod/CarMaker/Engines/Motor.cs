namespace Patterns.Creational.FactoryMethod.CarMaker.Engines
{
    public abstract class Motor
    {
        public abstract string Type { get; }

        public abstract int SecondsTo100kmh { get; }
        public abstract string Sound { get; }
    }
}
