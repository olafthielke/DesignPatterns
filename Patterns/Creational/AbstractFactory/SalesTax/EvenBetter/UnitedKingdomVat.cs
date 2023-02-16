namespace Patterns.Creational.AbstractFactory.SalesTax.EvenBetter
{
    public class UnitedKingdomVat : SalesTax
    {
        public override string Country => "United Kingdom";
        public override string TaxName => "VAT";
        public override decimal TaxRate => 0.20m;
    }
}
