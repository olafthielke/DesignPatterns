using FluentAssertions;
using Patterns.Creational.Monostate;
using Xunit;
using Customer = Patterns.Creational.Customer;

namespace Tests.Creational
{
    public class MonostateClientTests
    {
        [Fact]
        public void GetCustomer_Test()
        {
            var stubDatabase = new StubSqlConnectionMonostate(FredFlintstone);
            var client = new MonostateClient(stubDatabase);
            var gotCustomer = client.GetCustomer(1);
            gotCustomer.Should().BeEquivalentTo(FredFlintstone);
        }

        public static readonly Customer FredFlintstone = new Customer(1, "Fred", "Flintstone");
    }


    public class StubSqlConnectionMonostate : ISqlConnectionMonostate
    {
        public Customer CustomerToReturn;

        public StubSqlConnectionMonostate(Customer customerToReturn)
        {
            CustomerToReturn = customerToReturn;
        }

        public Customer GetCustomer(int customerId)
        {
            return CustomerToReturn;
        }

        public void Dispose()
        {

        }
    }
}
