using Xunit;
using FluentAssertions;
using Patterns.Creational;
using Patterns.Creational.Singleton;

namespace Tests.Creational
{
    public class SingletonClientTests
    {
        [Fact]
        public void GetCustomer_Test()
        {
            var client = new SingletonClient();
            var gotCustomer = client.GetCustomer(1);
            gotCustomer.Should().BeEquivalentTo(FredFlintstone);
        }

        public static readonly Customer FredFlintstone = new Customer(1, "Fred", "Flintstone");
    }
}
