using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csdlnc_doan1
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = ".";
            string database = "QUANLI_KH";
            string username = "MSI\\MSI GAMING";
            string pass = "";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, pass);
        }
    }
}
