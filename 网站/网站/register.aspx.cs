using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = name.Text;
        string pwd = password.Text;

        string str = @"Data Source=DESKTOP-781JML6\SQL;Initial Catalog=student;Integrated Security=SSPI";

        SqlConnection connection1 = new SqlConnection(str);
        int count = 0;
        if (password.Text != password1.Text)
        {
            Response.Write("<script>window.alert('两次密码内容不一致！');</script>");
            return;
        }

        else try
            {
                string sql = string.Format("insert into login(id,password) values ('{0}','{1}')", name.Text, password.Text);
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();
                count = (int)command.ExecuteNonQuery();
                if (count == 1)
                {
                    Response.Write("<script>window.alert('注册成功！d(￣▽￣*)b');window.location='../index.aspx'</script>");
                    // Response.Redirect("~..//index.aspx");






                }
                else
                {
                    Response.Write("<script>window.alert('因某种神奇的原因注册失败（＞人＜；）')</script>");

                }



            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('该用户名已被注册，老铁换个吧(￣、￣)')</script>");
            }
        connection1.Close();
    }
}