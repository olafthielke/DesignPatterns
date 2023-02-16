namespace Patterns.Creational.AbstractFactory.SalesTax.After
{
    public class NewZealandGst : SalesTax
    {
        public override string TaxName => "GST";
        public override decimal TaxRate => 0.15m;
    }
}
