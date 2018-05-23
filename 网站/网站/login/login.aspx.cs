using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class login_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
      protected void Button1_Click(object sender, EventArgs e)
    {
        string username = user.Text;
        string password = pwd.Text;

        string str = @"Data Source=DESKTOP-781JML6\SQL;Initial Catalog=student;Integrated Security=SSPI";

        SqlConnection connection1 = new SqlConnection(str);
        int count = 0;
        Session["name"] = user.Text;

        try
        {
            string sql = string.Format("select count(*) from login where id='{0}' and password='{1}'",user.Text, pwd.Text);
            SqlCommand command = new SqlCommand(sql, connection1);
            connection1.Open();
            count = (int)command.ExecuteScalar();
            if (count == 1)
            {
                Response.Write("<script>window.alert('登陆成功！');window.location='../index.aspx'</script>");
              // Response.Redirect("~..//index.aspx");


                /*frm2.receivedata = this.senddata;*/



            }
            else
            {
                Response.Write("<script>window.alert('用户名或密码不存在')</script>");

            }
            int result = command.ExecuteNonQuery();

            if (result == 1)

            {
                Response.Write("失败！");
            }
        }
        catch (Exception)
        {
            Response.Write("该账户已被注册");
        }
        connection1.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("../register.aspx");

    }


}
