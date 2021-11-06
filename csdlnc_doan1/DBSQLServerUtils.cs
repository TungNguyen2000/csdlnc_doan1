using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csdlnc_doan1
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            //connection string Data Source=.;Initial Catalog=QUANLI_KH;Integrated Security=True
            try
            {
                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                            + database + ";Integrated Security=True;";

                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            };
            return null;
        }
    }
}
