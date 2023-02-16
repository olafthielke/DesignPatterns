using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;
using Patterns.Structural.Facade.Interfaces;

namespace Patterns.Structural.Facade
{
    public class GetCustomerUseCase
    {
        private ICustomerRepository Repository { get; }


        public GetCustomerUseCase(ICustomerRepository repository)
        {
            Repository = repository;
        }


        public async Task<Customer> GetCustomer(int customerId)
        {
            // In here is business logic, and it does not care from how many
            // data sources need to be accessed to get the customer data.
            // Hide data source complexity behind a Facade.

            return await Repository.GetCustomer(customerId);
        }
    }
}
