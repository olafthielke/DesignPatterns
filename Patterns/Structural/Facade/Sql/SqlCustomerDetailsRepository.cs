using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Patterns.Structural.Facade.Entities;
using Patterns.Structural.Facade.Interfaces;

namespace Patterns.Structural.Facade.Sql
{
    public class SqlCustomerDetailsRepository : ICustomerDetailsRepository
    {
        public async Task<CustomerDetails> GetDetails(int customerId)
        {
            CustomerDetails details = null;

            await using var connection = new SqlConnection("Server=.;Database=DesignPatterns;Trusted_Connection=True;");
            connection.Open();
            var cmd = new SqlCommand($"SELECT * FROM [dbo].[Customers] WHERE [CustomerId] = {customerId}", connection);
            await using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                details = new CustomerDetails
                {
                    CustomerId = int.Parse(reader["CustomerId"].ToString()),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    EmailAddress = reader["EmailAddress"].ToString()
                };
            }

            return details;
        }
    }
}
