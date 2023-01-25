using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommodityClassLib
{
    class DBSQLServerUtils
    {
        public static SqlConnection
        GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=DESKTOP-IQ5OFLO;Initial Catalog=_ОптоваяТорговля_;Integrated Security=True
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}

