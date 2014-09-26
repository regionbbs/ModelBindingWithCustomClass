using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomClassModelBinding.Models
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> Select()
        {
            var connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NW"].ConnectionString);
            var cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Customers";

            connection.Open();
            var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                yield return new Customer()
                {
                    Id = reader.GetString(reader.GetOrdinal("CustomerID")),
                    CompanyName = reader.GetString(reader.GetOrdinal("CompanyName")),
                    ContactName = reader.GetString(reader.GetOrdinal("ContactName")),
                    ContactPhone = reader.GetString(reader.GetOrdinal("Phone"))
                };
            }

            reader.Close();
        }
    }
}