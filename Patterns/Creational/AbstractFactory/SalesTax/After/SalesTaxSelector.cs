using System;

namespace Patterns.Creational.AbstractFactory.SalesTax.After
{
    /// <summary>
    /// This class is the AbstractFactory.
    /// </summary>
    public class SalesTaxSelector
    {
        // Can also do as static version
        public SalesTax Select(string country)
        {
            switch (country)
            {
                // TODO: country is Australia.
                case "New Zealand":
                    return new NewZealandGst();
                case "United Kingdom":
                    return new UnitedKingdomVat();

                // Add more country-specific SalesTaxes, as required.

                default:
                    throw new InvalidOperationException($"{country} does not have a sales tax.");
            }
        }

        // Can also do a static version. However, this is problematic. Why?
        public static SalesTax Choose(string country)
        {
            switch (country)
            {
                // TODO: country is Australia.
                case "New Zealand":
                    return new NewZealandGst();
                case "United Kingdom":
                    return new UnitedKingdomVat();

                // Add more country-specific SalesTaxes, as required.

                default:
                    throw new InvalidOperationException($"{country} does not have a sales tax.");
            }
        }
    }
}
