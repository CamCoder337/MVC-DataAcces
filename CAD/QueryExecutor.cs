using Npgsql;

namespace CAD;

public class QueryExecutor
{
    private NpgsqlConnection _connection;

    public QueryExecutor(NpgsqlConnection connection)
    {
        this._connection = connection;
    }

    public void ExecuteNonQuery(string query)
    {
        using (NpgsqlCommand command = new NpgsqlCommand(query, _connection))
        {
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
    
    public NpgsqlDataReader ExecuteReader(string query)
    {
        using (NpgsqlCommand command = new NpgsqlCommand(query, _connection))
        {
            _connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}