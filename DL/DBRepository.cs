using Microsoft.Data.SqlClient;
using System.Data;

namespace DL;

public class DBRepository : IRepository
{
    private readonly string _connectionString;
    public DBRepository(string connectionString)
    {
        Console.WriteLine(connectionString);
        _connectionString = connectionString;
    }
}