using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommodityClassLib
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-IQ5OFLO";

            string database = "_ОптоваяТорговля_";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
