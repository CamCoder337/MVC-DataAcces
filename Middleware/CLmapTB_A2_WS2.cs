namespace Middleware;

public class CLmapTB_A2_WS2
{
    private string rq_sql;
    private int id;
    private string firstname;
    private string lastname;
    private const string table = "users";

    public string SelectAll()
    {
        rq_sql = $"SELECT * FROM table";
        return rq_sql;
    }

    public string SelectByName(string paramName)
    {
        rq_sql = $"SELECT * FROM table WHERE firstname = '{paramName}'";
        return rq_sql;
    }

    public string Delete()
    {
        rq_sql = $"DELETE FROM table WHERE id = {id}";
        return rq_sql;
    }

    public string Insert()
    {
        rq_sql = $"INSERT INTO table (firstname, lastname) VALUES ('{firstname}', '{lastname}')";
        return rq_sql;
    }

    public string Update()
    {
        rq_sql = $"UPDATE table SET firstname = '{firstname}', lastname = '{lastname}' WHERE id = {id}";
        return rq_sql;
    }

    public void SetId(int paramId)
    {
        id = paramId;
    }

    public void SetFirstName(string paramfirstname)
    {
        firstname = paramfirstname;
    }

    public void SetLastName(string paramlastname)
    {
        lastname = paramlastname;
    }
}
