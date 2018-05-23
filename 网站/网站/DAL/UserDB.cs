using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class UserDB
    {
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public int AddUser(UserInfo userInfo)
        {
            //对数据库进添加一个用户操作    
            string commandText = "insert into UserInfo (userName,Password)values(@userName,@Password)";
            SqlParameter[] paras = new SqlParameter[]
            {
           new SqlParameter ("@userName",userInfo.UserName ),
           new SqlParameter ("@Password",userInfo.Password )
            };
            return SqlHelper.ExecuteNonQuery(connString, CommandType.Text, commandText, paras);
        }
    }
}
