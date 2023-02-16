using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;
using Patterns.Structural.Facade.Interfaces;

namespace Patterns.Structural.Facade.Redis
{
    public class RedisCustomerAddressRepository : RedisCache<CustomerAddress>, ICustomerAddressRepository
    {
        public RedisCustomerAddressRepository(IRedisConnector connector)
            : base(connector)
        { }

        public async Task<CustomerAddress> GetAddress(int customerId)
        {
            var cacheKey = BuildCustomerAddressCacheKey(customerId);
            return await Get(cacheKey);
        }

        public async Task SaveAddress(CustomerAddress customerAddress)
        {
            var cacheKey = BuildCustomerAddressCacheKey(customerAddress.CustomerId);
            await Save(cacheKey, customerAddress);
        }

        private static string BuildCustomerAddressCacheKey(int customerId)
        {
            return $"address_customer_{customerId}";
        }
    }
}
