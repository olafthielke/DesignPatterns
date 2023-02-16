using Patterns.Creational.FactoryMethod.CarMaker.Engines;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    public class DieselEngineCarFactory : CombustionEngineCarFactory
    {
        protected override Motor MakeMotor()
        {
            return new DieselEngine();
        }
    }
}
