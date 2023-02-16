using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;

namespace Patterns.Structural.Facade.Interfaces
{
    public interface ICustomerDetailsRepository
    {
        Task<CustomerDetails> GetDetails(int customerId);
    }
}
