using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCompare
{
    public class SqlHelper
    {

        public SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["UnitTest"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public bool Insert()
        {
            try
            {
                string sql = "Insert into User values('Alan','wang')";
                using (SqlConnection conn = GetConnection())
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        
    }
}
