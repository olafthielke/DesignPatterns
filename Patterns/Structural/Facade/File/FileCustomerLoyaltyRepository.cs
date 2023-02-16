using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;
using Patterns.Structural.Facade.Interfaces;

namespace Patterns.Structural.Facade.File
{
    public class FileCustomerLoyaltyRepository : ICustomerLoyaltyRepository
    {
        const string LoyaltyFilePath = @"C:\Users\olaft\source\repos\DesignPatterns\Patterns\Structural\Facade\File\CustomerLoyalty.csv";

        public async Task<CustomerLoyalty> GetLoyalty(int customerId)
        {
            var lines = System.IO.File.ReadAllLines(LoyaltyFilePath);
            foreach (var line in lines)
            {
                var loyalty = line.Split(',');
                var customerNumber = int.Parse(loyalty[0]);
                if (customerNumber == customerId)
                {
                    var loyaltyPoints = int.Parse(loyalty[1]);
                    return new CustomerLoyalty
                    {
                        CustomerId = customerId,
                        LoyaltyPoints = loyaltyPoints
                    };
                }
            }

            return null;
        }
    }
}
