using System;

namespace Patterns.Creational.AbstractFactory.SalesTax.After
{
    public class SalesTaxService
    {
        public string GetSalesTaxName(string country)
        {

            var tax = GetTax(country);
            return tax.TaxName;
        }

        private SalesTax GetTax(string country)
        {
            var selector = new SalesTaxSelector();
            return selector.Select(country);
        }

        public decimal GetSalesTaxRate(string country)
        {
            var tax = GetTax(country);
            return tax.TaxRate;
        }

        public decimal CalcSalesTaxAmount(decimal amount, string country)
        {
            return amount * GetSalesTaxRate(country);
        }

        public bool DoesCountryHaveSalesTax(string country)
        {
            try
            {
                var tax = GetTax(country);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
