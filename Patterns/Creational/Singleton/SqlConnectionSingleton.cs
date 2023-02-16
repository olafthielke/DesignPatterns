using Patterns.Creational;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Patterns.Creational.Singleton
{
    // Must restrict the database connection to a single instance.
    // Using the Singleton pattern.
    public class SqlConnectionSingleton : IDisposable
    {
        // Static field (or property) to hold single instance.
        private static SqlConnectionSingleton _instance;

        // Private constructor to avoid direct creation.
        private SqlConnectionSingleton()
        {
            _sqlConnection = new SqlConnection("Server=.;Database=Components;Trusted_Connection=True;");
            _sqlConnection.Open();
        }

        // Static method to retrieve single instance. 
        public static SqlConnectionSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new SqlConnectionSingleton();
            return _instance;
        }


        // Instance Behaviour (Public methods and properties)
        private SqlConnection _sqlConnection;


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

        public void Dispose()
        {
            if (_sqlConnection.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
        }
    }

}
