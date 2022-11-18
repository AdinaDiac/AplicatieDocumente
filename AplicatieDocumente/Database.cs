using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AplicatieDocumente
{
    internal class Database
    {
        public string connectionString;
        public SqlConnection myConnection;
        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            myConnection = new SqlConnection(connectionString);


        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();

            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();

            }
        }

    }
}
