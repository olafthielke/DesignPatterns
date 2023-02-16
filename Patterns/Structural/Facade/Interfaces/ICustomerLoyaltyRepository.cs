using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;

namespace Patterns.Structural.Facade.Interfaces
{
    public interface ICustomerLoyaltyRepository
    {
        Task<CustomerLoyalty> GetLoyalty(int customerId);
    }
}
