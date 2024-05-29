using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace PassManager
{
    class DataBaseConnection
    {
        static string connectionString = "server=127.0.0.1;port=3306;" +
           "userid=root;password=root;database=lockedpass;sslmode=none";
        static MySqlConnection myConnection = new MySqlConnection(connectionString);
        static MySqlCommand myCommand = new MySqlCommand();

        static public void OpenConnection()
        {
            myConnection.Open();
            myCommand.Connection = myConnection;
        }

        static public void CloseConnection()
        {
            myConnection.Close();
        }

        static public int ExecuteNonQuery(string SQL)
        {
            myCommand.CommandText = SQL;
            return myCommand.ExecuteNonQuery();
        }

        static public DataTable ExecuteDataQuery(string SQL)
        {
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(SQL, myConnection);
            DataTable dataTable = new DataTable();
            myAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}