using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["name"] == null)
            {
                loginlable.Text = "请登陆！";
            }
            else
            {
                loginlable.Text = Session["name"].ToString();
                string a = loginlable.Text;
                
            }
          //  Session["name"] = loginlable.Text;
        }
    }

    public string CloseWindow()
    {
        Session.Clear();
        return "";
    }

    protected void buttonc(object sender, EventArgs e)
    {
      //  window.open('../登陆.exe');

    }
    protected void buttona(object sender, EventArgs e)
    {
        Session["id"] = loginlable.Text;
        if ( loginlable.Text!=("请登陆！"))
        {
            
            Response.Write("<script>window.alert('登陆成功！(ง •_•)ง');window.open('../talk.aspx')</script>");
        }
        else
        {
            Response.Write("<script>window.alert('请登陆后再进行操作！(ง •_•)ง');</script>");
        }

    }
    protected void buttonb(object sender, EventArgs e)
    {
        Session["name"] = loginlable.Text;
        if (loginlable.Text != ("请登陆！"))
        {

            Response.Write("<script>window.alert('登陆成功！(ง •_•)ง');window.open('../talkInfo.aspx')</script>");
        }
        else
        {
            Response.Write("<script>window.alert('请登陆后再进行操作！(ง •_•)ง');</script>");
        }

    }
    protected void buttond(object sender, EventArgs e)
    {
        Session["name"] = loginlable.Text;
        if (loginlable.Text != ("请登陆！"))
        {

            Response.Write("<script>window.alert('登陆成功！(ง •_•)ง');window.open('Go://打开exe')</script>");
        }
        else
        {
            Response.Write("<script>window.alert('请登陆后再进行操作！(ง •_•)ง');</script>");
        }

    }
    /* protected void Button1_Click(object sender, EventArgs e)
     {
         string username = name.Text;
         string pwd = password.Text;

         string str = "Data Source=DESKTOP-U4I1D8J;Initial Catalog=student;Integrated Security=SSPI";

         SqlConnection connection1 = new SqlConnection(str);
         int count = 0;
         if(password.Text!=password1.Text)
         {
             Response.Write("<script>window.alert('两次密码内容不一致！');</script>");
             return;
         }

       else  try
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
     */


}