namespace Patterns.Structural.Decorator.Barista.Coffees
{
    public abstract class Coffee
    {
        public abstract string Description { get; }
        public abstract decimal Cost { get; }
    }
}
