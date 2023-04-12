// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using TestConsoleApp;

Console.WriteLine("Hello, World!");
var connString = Environment.GetEnvironmentVariable("dbConnectionString");
LocalInit localInit = new LocalInit();
localInit.init();
Console.WriteLine(connString);

var sql = "select * from employee";

using (var connection = new SqlConnection("Data Source=INBLR3LB2MN9K3;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True"))
{
    connection.Open();
    using (var command = new SqlCommand(sql, connection))
    {
        using (var reader = command.ExecuteReader())
        {
           
        }
    }
}


Console.ReadLine();