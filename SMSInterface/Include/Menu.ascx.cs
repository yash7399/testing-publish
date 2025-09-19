using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Include_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"].ToString() == Session.SessionID.ToString())
        {
            Button1.Visible = true;
        }
        else
        {
            Button1.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session.Abandon();
        Session.Clear();
        System.Web.Security.FormsAuthentication.SignOut();
        HttpContext.Current.User = null;
        //string abc = Session["ID"].ToString();
        //added by alok on 30/11/21
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();
        //added till here by alok on 30/11/21
        Response.Redirect("default.aspx", true);
    }
}
