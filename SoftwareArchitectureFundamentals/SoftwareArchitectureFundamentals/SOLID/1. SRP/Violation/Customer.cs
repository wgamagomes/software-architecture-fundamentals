using SoftwareArchitectureFundamentals.Stubs;
using System;
using System.Data;
using System.Text.RegularExpressions;


namespace SoftwareArchitectureFundamentals.SOLID.SRP.Violation
{

    /// <summary>
    /// Single responsibility principle 
    /// Robert Cecil Martin, popularly known as "Uncle Bob" expresses the single responsibility principle as, "A class should have only one reason to change
    /// However in this class there are many responsibilities: data validation, open database connection, save data into database, build message  body and send email
    /// </summary>
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime InsertedAt { get; set; }
        public Customer()
        {
            Id = new Guid();
        }

        public string Add()
        {
            if (!Regex.IsMatch(EmailAddress, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                return "Invalid email";

            if (string.IsNullOrWhiteSpace(FirstName))
                return "First Name is empty";

            if (string.IsNullOrWhiteSpace(LastName))
                return "Last Name is empty";


            using (var sqlConnection = new SqlConnection())
            {
                using (var sqlCommand = new SqlCommand())
                {
                    sqlConnection.ConnectionString = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "Insert Into Customer (Id, FirstName, LastName, EmailAddress, InsertedAt) VALUES (@Id, @FirstName, @LastName, @EmailAddress, @InsertedAt))";

                    sqlCommand.Parameters("Id", Id);
                    sqlCommand.Parameters("FirstName", FirstName);
                    sqlCommand.Parameters("LastName", LastName);
                    sqlCommand.Parameters("EmailAddress", EmailAddress);
                    sqlCommand.Parameters("InsertedAt", InsertedAt);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }

            var mailMessage = new MailMessage("company@company.com", EmailAddress);

            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = "Network",
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = "Welcome.";
            mailMessage.Body = "Congratulations! You are registered.";
            smtpClient.Send(mailMessage);

            return "Customer successfully registered!";
        }
    }
}

