using System.Data;
using System.Data.SqlClient;
namespace CAD;

public class Cad
{
    private string rq_sql = "select * users;";
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlCommand _command;
    private DataSet _dataSet;
    private const string UserName = "postgres";
    private const string Password = "qwertyuiop";
    private string _cnx;



    public Cad()
    {
        _cnx = $"jdbc:postgresql://localhost:5432/dbws2proc?user={UserName}&password={Password}";
        _adapter = new SqlDataAdapter();
        _command = new SqlCommand();
        _connection = new SqlConnection(_cnx);
        _dataSet = new DataSet("db");
        
    }

    public void ActionRows(String query)
    {
        try
        {
            _connection.Open();

            _command.CommandText = query;
            _command.Connection = _connection;

            _command.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine("Error while executing query : " + e.Message);
            throw;
        }
        finally
        {
            _connection.Close();
        }
    }


    public DataSet GetRows(string query, string dataTableName)
    {
        try
        {
            _connection.Open();
            
            _command.CommandText = query;
            _command.Connection = _connection;
            _adapter.SelectCommand = _command;
            _adapter.Fill(_dataSet, dataTableName);

        }
        catch (Exception e)
        {
            Console.WriteLine("Error while executing query : " + e.Message);
            throw;
        }
        finally
        {
            _connection.Close();
        }

        return _dataSet;
    }
}