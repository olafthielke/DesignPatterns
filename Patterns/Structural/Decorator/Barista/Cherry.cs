using Patterns.Structural.Decorator.Barista.Coffees;

namespace Patterns.Structural.Decorator.Barista
{
    public class Cherry : CoffeeDecorator
    {
        public Cherry(Coffee coffee)
            : base(coffee)
        { }

        public override string Description => $"{Coffee.Description}, with Cherry on top";

        public override decimal Cost => Coffee.Cost + 0.75m;
    }
}
