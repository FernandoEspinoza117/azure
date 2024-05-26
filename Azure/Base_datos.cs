using System;
using System.Data.SqlClient;

public class ConexionBD
{
    private static string connectionString = @"Data Source = SPARTAN117\SQLSERVER; Initial Catalog = azure; Persist Security Info = True; User ID = root2; Password = root2";
    private static SqlConnection Connection;

    private ConexionBD()
    {

    }

    public static SqlConnection GetConnection()
    {
        if (Connection == null)
        {
            Connection = new SqlConnection(connectionString);           
        }
        else if (Connection.State == System.Data.ConnectionState.Closed)
        {
            Connection.Open();
        }

        return Connection;
    }

    public static void CloseConnection()
    {
        if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
        {
            Connection.Close();
        }
    }
}






