using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server=LAB102-02;Database=Tienda3; integrated security=true";

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
