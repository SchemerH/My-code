using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class talk : System.Web.UI.Page
{
   public string loginid;
    
    public void Page_Load(object sender, EventArgs e)
    {
          if (!IsPostBack)
          {

              if (Session["id"] == null)
              {
                 //  loginid = "zoe";
                //  Label1.Text = "请登录";
              }
              else
              {
                  loginid = Session["id"].ToString();
                Label1.Text = Session["id"].ToString();

            }
          }
    }

    public void Do(object sender, EventArgs e)
    {

        
        string str = @"Data Source=DESKTOP-781JML6\SQL;Initial Catalog=student;Integrated Security=SSPI";

        SqlConnection connection1 = new SqlConnection(str);
        int count = 0;

        if (text.Text != "")
        {
            name.Text = "";
            try
            {
                string sql = string.Format("insert into text1(id,text) values ('{0}','{1}')", Label1.Text, text.Text);
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();
                count = (int)command.ExecuteScalar();
                if (count == 1)
                {
                    Response.Write("<script>window.alert('已发送！');");




                }
                
                int result = command.ExecuteNonQuery();

                if (result == 1)

                {
                    Response.Write("失败！");
                }
                connection1.Close();
            }
             
            catch (Exception)
            {
                Response.Write("<script>window.alert('数据库操作出错')</script>");
            }
            text.Text = "";







            try
            {

                string sql2 = string.Format("select * from text1 order by 编号");
                SqlCommand command2 = new SqlCommand(sql2, connection1);
                connection1.Open();

                SqlDataReader dataReader;
                dataReader = command2.ExecuteReader();
                text.Text = "";

                if (!dataReader.HasRows)
                {
                    Response.Write("<script>window.alert('数据库操作出错::>_<::')</script>");

                }
                else
                {
                    Response.Write("<script>window.alert('数据库操作成功(～￣▽￣)～')</script>");

                    while (dataReader.Read())
                    {

                        string id;

                        string message;
                        int num;


                        id = (string)dataReader["id"];




                        //     name.Attributes.Add("style", "text-align:right;background-color:transparent;color:yellow");

                        name.Attributes.Add("style", "text-align:left;background-color:transparent;color:yellow");

                        message = (string)dataReader["text"];
                        num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                        name.Text += (id + "\r\n" + message + "\r\n"+"\n"+ "..........................................................................................................................................................................................................................................................................................................................................................................................................................." + "\n");


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
    


        if (text.Text == "")
        {
            name.Text = "";

            






            try
            {

                string sql2 = string.Format("select * from text1 order by 编号");
                SqlCommand command2 = new SqlCommand(sql2, connection1);
                connection1.Open();

                SqlDataReader dataReader;
                dataReader = command2.ExecuteReader();
                text.Text = "";

                if (!dataReader.HasRows)
                {
                    Response.Write("<script>window.alert('数据库操作出错::>_<::')</script>");

                }
                else
                {
                    Response.Write("<script>window.alert('数据库操作成功(～￣▽￣)～')</script>");

                    while (dataReader.Read())
                    {

                        string id;

                        string message;
                        int num;

                        
                        id = (string)dataReader["id"];
                        
                       

                           
                            //     name.Attributes.Add("style", "text-align:right;background-color:transparent;color:yellow");

                            name.Attributes.Add("style", "text-align:left;background-color:transparent;color:yellow");

                            message = (string)dataReader["text"];
                            num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                            name.Text += (id + "\r\n" + message + "\r\n" + "\n" + "..........................................................................................................................................................................................................................................................................................................................................................................................................................." + "\n");
                            
                       
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
    }

}