using System;

namespace Patterns.Creational.AbstractFactory.SalesTax.Before
{
    public class SalesTaxService
    {
        public string GetSalesTaxName(string country)
        {
            switch (country)
            {
                case "Australia":
                case "New Zealand":
                    return "GST";
                case "United Kingdom":
                    return "VAT";
                // Must change the code to add more countries

                default:
                    throw new InvalidOperationException($"{country} does not have a sales tax.");
            }
        }

        public decimal GetSalesTaxRate(string country)
        {
            switch (country)
            {
                case "Australia":
                    return 0.1m;
                case "New Zealand":
                    return 0.15m;
                case "United Kingdom":
                    return 0.20m;
                    // Must change this code to add more countries! 
                    // Which SOLID Principle is violated?
            }
            throw new InvalidOperationException($"{country} does not have a sales tax.");
        }

        public decimal CalcSalesTaxAmount(decimal amount, string country)
        {
            return amount * GetSalesTaxRate(country);
        }

        public bool DoesCountryHaveSalesTax(string country)
        {
            switch (country)
            {
                case "Australia":
                case "New Zealand":
                case "United Kingdom":
                    return true;

                default:
                    return false;
            }
        }
    }
}