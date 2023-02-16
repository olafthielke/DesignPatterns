namespace Patterns.Creational.FactoryMethod.CarMaker.Engines
{
    public class DieselEngine : CombustionEngine
    {
        public override string Type => "Diesel Engine";
        public override int SecondsTo100kmh => 12;
        public override string Sound => "Loud";
    }
}
