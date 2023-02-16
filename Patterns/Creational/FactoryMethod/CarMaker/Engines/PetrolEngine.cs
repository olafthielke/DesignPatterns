namespace Patterns.Creational.FactoryMethod.CarMaker.Engines
{
    public class PetrolEngine : CombustionEngine
    {
        public override string Type => "Petrol Engine";
        public override int SecondsTo100kmh => 8;
        public override string Sound => "Loud";
    }
}
