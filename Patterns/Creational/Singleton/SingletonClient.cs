namespace Patterns.Creational.Singleton
{
    public class SingletonClient
    {
        public Customer GetCustomer(int customerId)
        {
            // Why is this instantiation problematic?
            var database = SqlConnectionSingleton.GetInstance();

            var customer = database.GetCustomer(customerId);

            // Perform some other logic we want to unit test.
            // ...

            return customer;
        }
    }
}
