using System.Data;
using CAD;

namespace Middleware;

public class CLprocessus
{
    private DataSet oDs;
    private CLmapTB_A2_WS2 oMap;
    private Cad oCad;
    private string rq_sql;
    
    public CLprocessus()
    {
        oDs = new DataSet();
        oMap = new CLmapTB_A2_WS2();
        oCad = new Cad();
        rq_sql = string.Empty;
    }
    public DataSet Display(string dataTableName)
    {
        oDs.Tables.Clear();
        rq_sql = oMap.SelectAll();
        oDs = oCad.GetRows(rq_sql, dataTableName);
        return oDs;
    }

    public DataSet FindName(string dataTableName, string nom)
    {
        oDs.Tables.Clear();
        rq_sql = oMap.SelectByName(nom);
        oDs = oCad.GetRows(rq_sql, dataTableName);
        return oDs;
    }

    public void DeleteById(int id)
    {
        oMap.SetId(id);
        rq_sql = oMap.Delete();
        oCad.ActionRows(rq_sql);
    }

    public void InsertUpdate(string firstname, string lastname, char methode)
    {
        oDs.Tables.Clear();
        // oMap.SetId(id);
        oMap.SetFirstName(firstname);
        oMap.SetLastName(lastname);

        if (methode == 'i')
        {
            rq_sql = oMap.Insert();
        }
        else if (methode == 'u')
        {
            rq_sql = oMap.Update();
        }

        oCad.ActionRows(rq_sql);
    }

}