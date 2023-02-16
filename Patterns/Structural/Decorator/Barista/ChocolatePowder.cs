using Patterns.Structural.Decorator.Barista.Coffees;

namespace Patterns.Structural.Decorator.Barista
{
    public class ChocolatePowder : CoffeeDecorator
    {
        public ChocolatePowder(Coffee coffee)
            : base(coffee)
        { }

        public override string Description => $"{Coffee.Description}, with Chocolate Powder";

        public override decimal Cost => Coffee.Cost + 0.50m;
    }
}
