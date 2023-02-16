using System.Threading.Tasks;
using Patterns.Structural.Facade.Interfaces;
using Customer = Patterns.Structural.Facade.Entities.Customer;

namespace Patterns.Structural.Facade
{
    public class CustomerRepositoryFacade : ICustomerRepository
    {
        private ICustomerDetailsRepository CustomerDetailsRepo { get; }
        private ICustomerAddressRepository CustomerAddressRepo { get; }
        private ICustomerLoyaltyRepository CustomerLoyaltyRepo { get; }


        public CustomerRepositoryFacade(ICustomerDetailsRepository customerDetailsRepo,
            ICustomerAddressRepository customerAddressRepo,
            ICustomerLoyaltyRepository customerLoyaltyRepo)
        {
            CustomerDetailsRepo = customerDetailsRepo;
            CustomerAddressRepo = customerAddressRepo;
            CustomerLoyaltyRepo = customerLoyaltyRepo;
        }


        public async Task<Customer> GetCustomer(int customerId)
        {
            var details = await CustomerDetailsRepo.GetDetails(customerId);
            if (details == null)
                return null;

            // TODO: Do data retrieval asynchronously.

            var address = await CustomerAddressRepo.GetAddress(customerId);

            var loyalty = await CustomerLoyaltyRepo.GetLoyalty(customerId);

            return new Customer(details, address, loyalty);
        }
    }
}
