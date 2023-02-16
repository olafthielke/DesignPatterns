using Patterns.Structural.Decorator.Barista.Coffees;

namespace Patterns.Structural.Decorator.Barista
{
    public class WhippedCream : CoffeeDecorator
    {
        public WhippedCream(Coffee coffee)
            : base(coffee)
        { }

        public override string Description => $"{Coffee.Description}, with Whipped Cream";

        public override decimal Cost => Coffee.Cost + 1.00m;
    }
}
