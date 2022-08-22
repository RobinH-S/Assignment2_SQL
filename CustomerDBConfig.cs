using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCoding
{
    public static class CustomerDBConfig
    {
        public static string GetConnectionString()                                      //Is called in costumer class. Not working???
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            conn.DataSource = "localhost\\SQLEXPRESS";                                  //ADD Correct Path to database 
            conn.InitialCatalog = "Customer";                                           //Table name
            conn.IntegratedSecurity = true;
            return conn.ConnectionString;
        }
    }

}
