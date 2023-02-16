using System;
using System.Data;
using System.Data.SqlClient;

namespace Patterns.Creational.Monostate
{
    public interface ISqlConnectionMonostate : IDisposable
    {
        Customer GetCustomer(int customerId);
    }


    public class SqlConnectionMonostate : ISqlConnectionMonostate
    {
        // Static field (or property) to hold single instance.
        private static SqlConnection _sqlConnection;

        public SqlConnectionMonostate()
        {
            if (IsConnectionClosed)
            {
                _sqlConnection = new SqlConnection("Server=.;Database=Components;Trusted_Connection=True;");
                _sqlConnection.Open();
            }
        }

        private static bool IsConnectionClosed => _sqlConnection == null ||
                                                  _sqlConnection.State == ConnectionState.Closed;


        public void Dispose()
        {
            _sqlConnection.Dispose();
        }


        public Customer GetCustomer(int customerId)
        {
            Customer customer = null;

            var cmd = new SqlCommand($"SELECT * FROM [dbo].[Customers] WHERE [CustomerId] = {customerId}", _sqlConnection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var custId = int.Parse(reader["CustomerId"].ToString());
                    var firstName = reader["FirstName"].ToString();
                    var lastName = reader["LastName"].ToString();

                    customer = new Customer(custId, firstName, lastName);
                }
            }

            return customer;
        }
    }
}
