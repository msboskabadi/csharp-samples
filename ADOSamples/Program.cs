

using ADOSamples;
using Microsoft.Data.SqlClient;
using System.Data;

// var ConnectionString = "Server=.; Initial catalog=OnlineShopDb";

SqlSamples sample = new SqlSamples();

sample.AddProduct(1, "nokia", "nokia desc", 200);

Console.ReadKey();