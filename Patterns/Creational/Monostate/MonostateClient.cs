using Patterns.Creational;

namespace Patterns.Creational.Monostate
{
    public class MonostateClient
    {
        private ISqlConnectionMonostate Database { get; }

        public MonostateClient(ISqlConnectionMonostate database)
        {
            Database = database;
        }

        public Customer GetCustomer(int customerId)
        {
            // Not so hard to unit test with some minor changes.
            var customer = Database.GetCustomer(customerId);

            // Perform some other logic we want to unit test.

            return customer;
        }
    }
}
