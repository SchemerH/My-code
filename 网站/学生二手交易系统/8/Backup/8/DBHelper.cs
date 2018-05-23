using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _8
{
    class DBHelper
    {
     
            private static string connString = "Data Source=VANCOU-PC;Initial Catalog=test;Integrated Security=True";
            public  static SqlConnection connection = new SqlConnection(connString);
       
    }
}
