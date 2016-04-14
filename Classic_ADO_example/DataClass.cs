using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libraries needed to talk to the database
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// This class will connect to the database
/// It will have methods to retrieve the Services in the db
/// and Show all the grants for the chosen service
/// Amy Pierce 4/12/16 (Free scoop day at Ben and Jerry's
/// </summary>
public class DataClass
{
    private SqlConnection connect;
    public DataClass()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ToString());

            }//end of the contructor

    public DataTable GetServices()
    {
        DataTable tbl = new DataTable();

        string sql = "Select GrantTypeKey, GrantTypeName from GrantType";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();

        return tbl;
    }

}//end class
