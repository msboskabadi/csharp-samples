using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOSamples
{
    public class SqlSamples
    {
        public void FirstSample()
        {
            var ConnectionString = "Server=.; Database= OnlineShopDb; User Id=sa; Password=0910173532; Encrypt=False";

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            Console.WriteLine(connection.State);


            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Categories";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id : {reader["Id"]} ");
            }


            connection.Close();
            Console.WriteLine(connection.State);
        }

        public void WorkingWithConnection()
        {
            var ConnectionString = "Server=.; Database= OnlineShopDb; User Id=sa; Password=0910173532; Encrypt=False";

            SqlConnection connection = new SqlConnection(ConnectionString);


            // this parameter is readonly
            Console.WriteLine(connection.Database);
            Console.WriteLine(connection.DataSource);
            Console.WriteLine(connection.CommandTimeout);
            Console.WriteLine(connection.CommandTimeout);
        }
    }
}
