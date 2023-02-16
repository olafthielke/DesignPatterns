using System;
using Xunit;
using FluentAssertions;
using Patterns.Creational.AbstractFactory.SalesTax.EvenBetter;

namespace Tests.Creational.AbstractFactory.SalesTax.EvenBetter
{
    public class SalesTaxServiceTests
    {
        [Theory]
        [InlineData("New Zealand", "GST", 0.15, 15)]
        [InlineData("United Kingdom", "VAT", 0.20, 20)]
        [InlineData("Australia", "GST", 0.10, 10)]
        public void Countries_With_SalesTax_Tests(string country, string taxName, decimal taxRate, decimal taxAmount)
        {
            var salesTaxService = new SalesTaxService();
            salesTaxService.GetSalesTaxName(country).Should().Be(taxName);
            salesTaxService.GetSalesTaxRate(country).Should().Be(taxRate);
            salesTaxService.CalcSalesTaxAmount(100, country).Should().Be(taxAmount);
            salesTaxService.DoesCountryHaveSalesTax(country).Should().BeTrue();
        }

        [Theory]
        //[InlineData("Australia")]
        [InlineData("USA")]
        [InlineData("Malta")]
        [InlineData("Vietnam")]
        public void Countries_Without_SalesTax_Tests(string country)
        {
            var salesTaxService = new SalesTaxService();
            VerifyThrowsException(() => salesTaxService.GetSalesTaxName(country), country);
            VerifyThrowsException(() => salesTaxService.GetSalesTaxRate(country), country);
            VerifyThrowsException(() => salesTaxService.CalcSalesTaxAmount(100, country), country);
        }

        private void VerifyThrowsException(Action action, string country)
        {
            action.Should().ThrowExactly<InvalidOperationException>()
                .WithMessage($"{country} does not have a sales tax.");
        }
    }
}
