using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _8
{
    class DBHelper
    {
     
            private static string connString = "Data Source=DESKTOP-781JML6;Initial Catalog=sql;Integrated Security=True";
            public  static SqlConnection connection = new SqlConnection(connString);
       
    }
}
