namespace Patterns.Creational.AbstractFactory.SalesTax.After
{
    public class UnitedKingdomVat : SalesTax
    {
        public override string TaxName => "VAT";
        public override decimal TaxRate => 0.20m;
    }
}
