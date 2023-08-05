using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Realtor
{
    internal class DB
    {
        public SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
   
        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
            
        }
    }
}
