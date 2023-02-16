namespace Patterns.Creational.FactoryMethod.CarMaker.Engines
{
    public class ElectricMotor : Motor
    {
        public override string Type => "Electric Motor";
        public override int SecondsTo100kmh => 4;
        public override string Sound => "Quiet";
    }
}
