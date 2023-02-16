namespace Patterns.Creational.AbstractFactory.SalesTax.EvenBetter
{
    // Note: SalesTax is an abstract class. That is important for Abstract Factory.
    // SalesTax could also have been defined an interface.
    public abstract class SalesTax
    {
        public abstract string Country { get; }
        public abstract string TaxName { get; }
        public abstract decimal TaxRate { get; }
    }
}
