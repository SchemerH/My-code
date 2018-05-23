using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forum_index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["id"] == null)
            {
                login.Text = "请登陆！";
            }
            else
            {
                login.Text = Session["id"].ToString();
                
                Session.Clear();
            }
            
        }

         
    }
   
}