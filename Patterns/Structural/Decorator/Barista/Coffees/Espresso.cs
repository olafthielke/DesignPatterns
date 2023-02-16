namespace Patterns.Structural.Decorator.Barista.Coffees
{
    public class Espresso : Coffee
    {
        public override string Description => "Espresso";
        public override decimal Cost => 3.50m;
    }
}
