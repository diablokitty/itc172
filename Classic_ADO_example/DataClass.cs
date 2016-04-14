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
        DataTable tbl = null;
        string sql = "Select GrantTypeKey, GrantTypeName from GrantType";
        SqlCommand cmd = new SqlCommand(sql, connect);

        tbl = ReadData(cmd);

        return tbl;
    }

    public DataTable GetGrants(int grantTypeKey)
    {
        DataTable grantTbl = null;
        string sql = "Select GrantRequestDate, GrantRequestExplanation, GrantRequestAmount from GrantRequest Where GrantTypeKey=@Key";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Key", grantTypeKey);

        grantTbl = ReadData(cmd);

        return grantTbl;
    }

    private DataTable ReadData(SqlCommand cmd)
    {
        SqlDataReader reader = null;
        DataTable tbl = new DataTable();
        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();

        return tbl;

    }



}//end class