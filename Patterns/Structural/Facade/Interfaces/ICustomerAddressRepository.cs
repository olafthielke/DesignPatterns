using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;

namespace Patterns.Structural.Facade.Interfaces
{
    public interface ICustomerAddressRepository
    {
        Task<CustomerAddress> GetAddress(int customerId);
        Task SaveAddress(CustomerAddress customerAddress);
    }
}
