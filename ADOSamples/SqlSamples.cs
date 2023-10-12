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
                    Console.Write(":");
                    Console.WriteLine(reader.GetValue(i));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }

        public void MultipleReaderSample()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "Select * from Categories; Select * from Product",
            };

            connection.Open();
            var reader = command.ExecuteReader();
            Console.WriteLine(reader.FieldCount);
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i));
                        Console.Write(":");
                        Console.WriteLine(reader.GetValue(i));
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }while (reader.NextResult());
            
        }

        public void AddProduct(int categoryId, string productName, string description, int price)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"insert into products(CategoryId, ProductName, Description, Price) values ({categoryId}, '{productName}', '{description}', {price})",
            };

            connection.Open();

            int result = command.ExecuteNonQuery();
            Console.WriteLine($"Affected row is {result}");
        }

        public void AddProductParameter(int categoryId, string productName, string description, int price)
        {
            SqlParameter categoryIdParam = new SqlParameter
            {
                ParameterName = "@CategoryId",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Input,
                Value = categoryId
            };
            SqlParameter productNameParam = new SqlParameter
            {
                ParameterName = "@productName",
                DbType = DbType.String,
                Direction = ParameterDirection.Input,
                Value = productName
            };
            SqlParameter descriptionParam = new SqlParameter
            {
                ParameterName = "@description",
                DbType = DbType.String,
                Direction = ParameterDirection.Input,
                Value = description
            };
            SqlParameter priceParam = new SqlParameter
            {
                ParameterName = "@price",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Input,
                Value = price
            };

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"insert into products(CategoryId,ProductName,Description,Price) values (@CategoryId,@productName,@description,@price)"
            };

            command.Parameters.Add(categoryIdParam);
            command.Parameters.Add(productNameParam);
            command.Parameters.Add(descriptionParam);
            command.Parameters.Add(priceParam);
            connection.Open();
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"Affected row {result}");
        }

        public void AddTransactional(string categoryName, int categoryId, string productName, string description, int price)
        {
            SqlTransaction transaction = null;
            SqlCommand AddProduct = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"insert into products(CategoryId,ProductName,Description,Price) values ({categoryId},'{productName}','{description}',{price})"
            };
            SqlCommand AddCategory = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"insert into Categories(CategoryName) values ('{categoryName}')"
            };


            connection.Open();
            try
            {
                transaction = connection.BeginTransaction();
                int result = AddProduct.ExecuteNonQuery();
                result += AddCategory.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine($"Affected row {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
            }



        }

    }
}
