using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebPages;



public partial class NCDEXcommon : System.Web.UI.MasterPage
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    string requestCookie = string.Empty;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //string Sid;        
        try
        {
           // Sid = Session["ID"].ToString();
          /*  if (Session["ID"].ToString() != Session.SessionID.ToString())
            {
                Session["ID"] = "";
                Session.Abandon();
                Response.Redirect("default.aspx");
                Response.Cache.SetCacheability(HttpCacheability.NoCache); //Cache-Control : no-cache, Pragma : no-cache
                Response.Cache.SetExpires(DateTime.Now.AddDays(-1)); //Expires : date time
                Response.Cache.SetNoStore(); //Cache-Control :  no-store
                Response.Cache.SetProxyMaxAge(new TimeSpan(0, 0, 0)); //Cache-Control: s-maxage=0
                Response.Cache.SetValidUntilExpires(false);
                Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);//Cache-Control:  must-revalidate
                Response.AddHeader("Content-Security-Policy", "default-src 'none'; script-src 'self' 'unsafe-inline' 'unsafe-eval'; img-src 'self' data:; style-src 'self' 'unsafe-inline' 'unsafe-eval'; connect-src 'self'; font-src 'self'; frame-ancestors 'none'; ");
                //Response.AddHeader("Referrer-Policy", "no-referrer");
                Response.AddHeader("X-Xss-Protection", "1; mode=block");
                //Response.AddHeader("X-Content-Type-Options", "nosniff");
                //Response.AddHeader("Strict-Transport-Security", "max-age=31536000; includeSubDomains"); 
            }  */      
        }
        catch (Exception ex)
        {
           // Sid = null;
          //  Response.Redirect("default.aspx");
        }       
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        //AntiForgeryToken.Text = AntiForgery.GetHtml().ToHtmlString();
    }
}
