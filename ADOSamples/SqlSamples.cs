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
        private SqlConnection connection;
        public SqlSamples()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "OnlineShopDb";
            builder.DataSource = ".";
            builder.Password = "0910173532";
            builder.UserID = "sa";
            builder.Encrypt = false;
            builder.ConnectTimeout = 100;
            builder.CommandTimeout = 200;
            connection = new(builder.ConnectionString);
        }
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

        public void ConnectionBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "OnlineShopDb";
            builder.DataSource = ".";
            builder.Password = "0910173532";
            builder.UserID = "sa";
            builder.Encrypt = false;
            builder.ConnectTimeout = 100;
            builder.CommandTimeout = 200;
            SqlConnection connection = new(builder.ConnectionString);
        }

        public void TestCommand()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "Select * from Categories",
            };

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id : {reader["Id"]} ");
            }


            connection.Close();
            Console.WriteLine(connection.State);
        }

        public void ReaderSample()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "Select * from Categories",
            };

            connection.Open();
            var reader = command.ExecuteReader();
            Console.WriteLine(reader.FieldCount);
            
            while(reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i));
                    Console.Write("\t");
                }
            }
        }
    }
}
