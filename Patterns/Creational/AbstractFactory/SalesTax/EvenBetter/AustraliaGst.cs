namespace Patterns.Creational.AbstractFactory.SalesTax.EvenBetter
{
    public class AustraliaGst : SalesTax
    {
        public override string Country => "Australia";
        public override string TaxName => "GST";
        public override decimal TaxRate => 0.1m;
    }
}
