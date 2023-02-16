using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Creational.AbstractFactory.SalesTax.EvenBetter
{
    public class SalesTaxSelector
    {
        private List<SalesTax> Taxes { get; } = new List<SalesTax>();

        public SalesTaxSelector(params SalesTax[] taxes)
        {
            Taxes.AddRange(taxes);
        }

        public SalesTaxSelector(IEnumerable<SalesTax> taxes)
        {
            Taxes.AddRange(taxes);
        }


        public SalesTax Select(string country)
        {
            var tax = Taxes.SingleOrDefault(t => t.Country == country);
            if (tax == null)
                throw new InvalidOperationException($"{country} does not have a sales tax.");
            return tax;
        }
    }
}
