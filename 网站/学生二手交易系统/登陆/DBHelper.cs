using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 登陆
{
    class DBHelper
    {
        private static string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
        public static SqlConnection connection = new SqlConnection(str);
    }
}
