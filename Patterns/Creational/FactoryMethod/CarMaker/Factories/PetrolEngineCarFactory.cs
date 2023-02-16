using Patterns.Creational.FactoryMethod.CarMaker.Engines;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    public class PetrolEngineCarFactory : CombustionEngineCarFactory
    {
        protected override Motor MakeMotor()
        {
            return new PetrolEngine();
        }
    }
}
