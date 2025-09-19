using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;
using System.Net;

public partial class TradeX : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();
    string strFilePath, strFilePathTst;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"].ToString() != Session.SessionID.ToString())
        {
            Session["ID"] = "";
            Session.Abandon();
            Response.Redirect("default.aspx");
        }

        strFilePath = ConfigurationManager.AppSettings.Get("DownloadTradeX");
        strFilePathTst = ConfigurationManager.AppSettings.Get("Parameters");

        if (!IsPostBack)
        {
            if (File.Exists(strFilePathTst + lbltst1.Text))
            {
                ImageButtonTst.Visible = true;
            }
            else
            {
                lbltst2.Text = "Not Available";
                ImageButtonTst.Visible = false;
            }
        }
    }

    private void CommomFunction(string filename, string filytpe)
    {
        try
        {
            logs.writeToFile(filename);
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=" + filename);
            Response.WriteFile(strFilePath + filename);
            Response.ContentType = filytpe;
            Response.End();

        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname1.Text), ".pdf");
    }

    //protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname2.Text), ".zip");
    //}

    //protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname3.Text), ".zip");
    //}

    protected void ImageButtonTst_Click(object sender, ImageClickEventArgs e)
    {
        logs.writeToFile(lbltst1.Text);
        Response.Clear();
        Response.AddHeader("content-disposition", "attachment; filename=" + lbltst1.Text);
        Response.WriteFile(strFilePathTst + lbltst1.Text);
        Response.ContentType = ".xml";
        Response.End();

        //using (WebClient wc = new WebClient())  // Temp testing purpose
        //{
        //    logs.writeToFile(lbltst1.Text);
        //    Response.Clear();
        //    Response.AddHeader("content-disposition", "attachment; filename=" + lbltst1.Text);
        //    Response.WriteFile(strFilePathTst + lbltst1.Text);
        //    Response.ContentType = ".xml";
        //    Response.End();
        //}
    }
}