using SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Entities;
using SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Interfaces;
using SoftwareArchitectureFundamentals.Stubs;
using System.Data;

namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            using (var sqlConnection = new SqlConnection())
            {
                using (var sqlCommand = new SqlCommand())
                {
                    sqlConnection.ConnectionString = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "Insert Into Customer (Id, FirstName, LastName, EmailAddress, InsertedAt) VALUES (@Id, @FirstName, @LastName, @EmailAddress, @InsertedAt))";

                    sqlCommand.Parameters("Id", customer.Id);
                    sqlCommand.Parameters("FirstName", customer.FirstName);
                    sqlCommand.Parameters("LastName", customer.LastName);
                    sqlCommand.Parameters("EmailAddress", customer.EmailAddress);
                    sqlCommand.Parameters("InsertedAt", customer.InsertedAt);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
