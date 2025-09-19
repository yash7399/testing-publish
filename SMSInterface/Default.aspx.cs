using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.WebPages;
//using ;


public partial class _Default : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();
    string UName, UPwd;
    private string _xmlconfigPath = string.Empty;
    private int Enablecaptcha = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        //added by alok on 30/11/21
        if (!IsPostBack)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now);
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetNoStore();
            //Response.Cache.SetCacheability(HttpCacheability.NoCache); //Cache-Control : no-cache, Pragma : no-cache
            //Response.Cache.SetExpires(DateTime.Now.AddDays(-1)); //Expires : date time
            //Response.Cache.SetNoStore(); //Cache-Control :  no-store
            Response.Cache.SetProxyMaxAge(new TimeSpan(0, 0, 0)); //Cache-Control: s-maxage=0
            Response.Cache.SetValidUntilExpires(false);
            Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);//Cache-Control:  must-revalidate
            Response.AddHeader("Content-Security-Policy", "default-src 'none'; script-src 'self' 'unsafe-inline' 'unsafe-eval'; img-src 'self' data:; style-src 'self' 'unsafe-inline' 'unsafe-eval'; connect-src 'self'; font-src 'self'; frame-ancestors 'none'; ");
            //Response.AddHeader("Referrer-Policy", "no-referrer");
            Response.AddHeader("X-Xss-Protection", "1; mode=block");
            TextBox1.Text = "";
        };
        Session["ID"] = "";
        UName = ConfigurationManager.AppSettings.Get("memUserName");
        UPwd = ConfigurationManager.AppSettings.Get("memPassword");

        Enablecaptcha = Convert.ToInt16(ConfigurationManager.AppSettings.Get("_Enablecaptcha"));
        if (Enablecaptcha != 1)
        {
            cmdResetCaptcha.Visible = false;
            trCapcha.Visible = false;
            Image2.Visible = false;
            TextBox1.Visible = false;
        }
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        //AntiForgeryToken.Text = AntiForgery.GetHtml().ToHtmlString();
    }
    public string Decrypt(string value)
    {
        String result = "";
        string[] array = value.Split('-');

        for (int i = 0; i < array.Length; i++)
        {
            int charvalue = Convert.ToInt32(array[i].ToString().Trim()) - 10;
            result += new String(new char[] { Convert.ToChar(charvalue) });
        }
        return result;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //if (cptc.IsValid)
        //{
        //string abc = Session["CaptchaVerify"].ToString().Trim();
        //string bcd = TextBox1.Text.Trim();
        if (Enablecaptcha == 1)
        {
            if (Session["CaptchaVerify"] != null)
            {
                if (Session["CaptchaVerify"].ToString().Trim() == TextBox1.Text.Trim())
                {
                    string Username, Userpwd;

                    Username = logs.checkInputParam(txtUsername.Text);
                    Userpwd = logs.checkInputParam(Decrypt(txtPassword.Text));//added by alok on 03/12/2021

                    if ((Username.ToUpper() != UName) || (Userpwd != UPwd))
                    {
                        lblError.Text = "Invalid Username / password";
                        lblError.Visible = true;

                        Session["ID"] = "";
                        Session.Abandon();
                    }
                    else
                    {
                        Session["ID"] = Session.SessionID.ToString();
                        Session["LoginTime"] = DateTime.Now.ToString();
                        lblError.Visible = false;
                        Response.Redirect("Bhavcopy.aspx");
                    }
                }
                else
                {
                    lblCaptchaMessage.Text = "Please enter correct code";
                    lblCaptchaMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblCaptchaMessage.Text = "Captcha Not Found";
                lblCaptchaMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        else
        {
            //if (Session["CaptchaVerify"] != null)
            // {
            //if (Session["CaptchaVerify"].ToString().Trim() == TextBox1.Text.Trim())
            //{
            string Username, Userpwd;

            Username = logs.checkInputParam(txtUsername.Text);
            Userpwd = logs.checkInputParam(Decrypt(txtPassword.Text));//added by alok on 03/12/2021

            if ((Username.ToUpper() != UName) || (Userpwd != UPwd))
            {
                lblError.Text = "Invalid Username / password";
                lblError.Visible = true;

                Session["ID"] = "";
                Session.Abandon();
            }
            else
            {
                Session["ID"] = Session.SessionID.ToString();
                Session["LoginTime"] = DateTime.Now.ToString();
                lblError.Visible = false;
                Response.Redirect("Bhavcopy.aspx");
            }
            // }
            //else
            //{
            //    lblCaptchaMessage.Text = "Please enter correct code";
            //    lblCaptchaMessage.ForeColor = System.Drawing.Color.Red;
            //}
            //}
        }
    }
    protected void imgCPTC_Click(object sender, ImageClickEventArgs e)
    {
        //cptc.ErrorMessage = "";
    }
    protected void ResetCaptcha_Btn_Click(object sender, EventArgs e)
    {
        Image2.ImageUrl = string.Format("~/Capcha.aspx?img={0}", Guid.NewGuid());
    }
}
