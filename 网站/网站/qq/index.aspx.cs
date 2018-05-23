using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class qq_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["name"] == null)
            {
                name.Text = "请登陆！";
            }
            else
            {
                name.Text = Session["name"].ToString();
                string a = name.Text;

            }
        }

    }
  /*  protected void Do(object sender, EventArgs e)
    {
        

        string str = "Data Source=DESKTOP-U4I1D8J;Initial Catalog=student;Integrated Security=SSPI";

        SqlConnection connection1 = new SqlConnection(str);
        int count = 0;

        if (dope1.Text != "")
        {
            try
            {
                string sql = string.Format("insert into text(id,text) values ('{0}','{1}')", name.Text, dope1.Text);
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();
                count = (int)command.ExecuteScalar();
                if (count == 1)
                {
                    Response.Write("<script>window.alert('已发送！');");
                   



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
                Response.Write("<script>window.alert('数据库操作出错')</script>");
            }
            dope1.Text = "";
        }






        try
        {

            string sql2 = string.Format("select * from text order by 编号");
            SqlCommand command2 = new SqlCommand(sql2, connection1);
            connection1.Open();

            SqlDataReader dataReader;
            dataReader = command2.ExecuteReader();
            dope2.Text = "";

            if (!dataReader.HasRows)
            {
                Response.Write("<script>window.alert('数据库操作出错')</script>");

            }
            else
            {
                Response.Write("<script>window.alert('数据库操作成功')</script>");

                while (dataReader.Read())
                {
                    string type;
                    string id;

                    string message;
                    int num;

                    
                    id = (string)dataReader["id"];

                    message = (string)dataReader["text"];
                    num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                    dope2.Text = ( id + "\r\n" + message + "\r\n");
                }




            }
            dataReader.Close();
            connection1.Close();

        }
        catch (Exception)
        {
            Response.Write("<script>window.alert('数据库操作成功')</script>");
        }
    



        if (dope1.Text == "")
        {

            
            






            try
            {

                string sql2 = string.Format("select * from text order by 编号");
                SqlCommand command2 = new SqlCommand(sql2, connection1);
                connection1.Open();

                SqlDataReader dataReader;
                dataReader = command2.ExecuteReader();
                dope2.Text = "";

                if (!dataReader.HasRows)
                {
                    Response.Write("<script>window.alert('数据库操作出错')</script>");

                }
                else
                {
                    Response.Write("<script>window.alert('数据库操作成功')</script>");

                    while (dataReader.Read())
                    {
                       
                        string id;
                        
                        string message;
                        int num;

                        
                        id = (string)dataReader["id"];
                        
                        message = (string)dataReader["text"];
                        num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                        dope2.Text=( id + "\r\n" + message + "\r\n");
                    }




                }
                dataReader.Close();
                connection1.Close();

            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('数据库操作成功')</script>");
            }
        }






     
        connection1.Close();
    }*/
   
}