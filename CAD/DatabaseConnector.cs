using Npgsql;
using DotNetEnv;
namespace CAD;

public class DatabaseConnector
{
    private string connectionString;
    private string username = "postgres";
    private string password = "qwertyuiop";

    public DatabaseConnector()
    {
        Env.Load("CAD.env");
        connectionString = $"jdbc:postgresql://localhost:5432/dbws2proc?user={username}&password={password}";
        Console.Write(connectionString);
    }
    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(connectionString);
    }

}