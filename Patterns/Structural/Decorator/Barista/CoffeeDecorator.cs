using Patterns.Structural.Decorator.Barista.Coffees;

namespace Patterns.Structural.Decorator.Barista
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee Coffee { get; }

        protected CoffeeDecorator(Coffee coffee)
        {
            Coffee = coffee;
        }
    }
}
