namespace Patterns.Creational.AbstractFactory.SalesTax.EvenBetter
{
    public class NewZealandGst : SalesTax
    {
        public override string Country => "New Zealand";
        public override string TaxName => "GST";
        public override decimal TaxRate => 0.15m;
    }
}
