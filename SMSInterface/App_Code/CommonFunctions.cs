using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;
using System.IO;
using Microsoft.VisualBasic;

/// <summary>
/// Summary description for CommonFunctions
/// </summary>
public class CommonFunctions
{
    string strFileName, strErrorFileName;
    public CommonFunctions()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void writeToFile(string str)
    {
        StreamWriter objwriter;
        string url, ClientIPAdd, strUserAgent;

        string strPath;
        DateTime logDt = DateTime.Now;
        string strDate;
        strDate = logDt.ToString("ddMMyyyy");

        try
        {
            strPath = ConfigurationManager.AppSettings.Get("DownloadLog_Path");
            strFileName = strPath + strDate + ".log";
 
            url = HttpContext.Current.Request.UrlReferrer.ToString();
            ClientIPAdd = HttpContext.Current.Request.UserHostAddress.ToString(); // IP Address
            strUserAgent = HttpContext.Current.Request.UserAgent.ToString(); // Browser Details

            objwriter = new StreamWriter(strFileName, true, System.Text.Encoding.ASCII);
            //objwriter.WriteLine("URL :- " + url + "  Client IP :- " + ClientIPAdd + " and downloaded file is :- " + str + " At:- " + DateTime.Now.ToString());

            objwriter.WriteLine("URL :- " + url + "  Client IP :- " + ClientIPAdd + " and downloaded file is :- " + str + " At:- " + DateTime.Now.ToString() + " UserAgent:- " + strUserAgent + ".");

            //string strUserAgent1= string.Empty, strUserAgent2= string.Empty;
            //strUserAgent1 = HttpContext.Current.Request.Browser.Browser.ToString();
            //strUserAgent2 = HttpContext.Current.Request.Browser.Version.ToString();
            //objwriter.WriteLine("URL :- " + url + "  Client IP :- " + ClientIPAdd + " and downloaded file is :- " + str + " At:- " + DateTime.Now.ToString() + " UserAgent:- " + strUserAgent + " Browser:- " + strUserAgent1 + " Browser Version:- " + strUserAgent2 + ".");
            //objwriter.WriteLine(strUserAgent1);
            //objwriter.WriteLine(strUserAgent2);

            objwriter.Close();

        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }

    }

    public void writeError(string err)
    {
        StreamWriter objwriter1;
        string urlstr, ClientIPAdd_str;

        string strPathError;
        DateTime logDtError = DateTime.Now;
        string strDateError;
        strDateError = logDtError.ToString("ddMMyyyy");

        try
        {
            //strErrorFileName = ConfigurationManager.AppSettings.Get("ErrorLog");
            strPathError = ConfigurationManager.AppSettings.Get("ErrorLog_Path");
            strErrorFileName = strPathError + strDateError + "_Error.log";
            
            urlstr = HttpContext.Current.Request.CurrentExecutionFilePath.ToString();
            ClientIPAdd_str = HttpContext.Current.Request.UserHostAddress.ToString(); // IP Address

            if(!File.Exists(strErrorFileName))
            {
                File.Create(strErrorFileName);
            }
           
            objwriter1 = new StreamWriter(strErrorFileName, true);
            objwriter1.WriteLine("URL : - " + urlstr + "  Client IP : - " + ClientIPAdd_str + " Time :- " + DateTime.Now.ToString());
            objwriter1.WriteLine("Error : - " + err);
            objwriter1.WriteLine("--------------------------------------------");
            objwriter1.Close();

        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    
    }

    public string checkInputParam(string strKey)
    {
        int i, cnt;
        string strvalid, str;
        char[] Char_Array = new char[]{','};

        str = " " + strKey;
        cnt = 0;
        strvalid = ConfigurationManager.AppSettings.Get("ValidateKey");
        string[] Array_key = strvalid.Split(Char_Array);
        
        for(i = 0; i < Array_key.Length - 1; i++)
        {
            if(str.ToUpper().IndexOf(Array_key[i].ToUpper(),0)>0)
            {
                str = str.ToUpper().Replace(Array_key[i].ToUpper(),"");
                cnt = cnt +1;
            }
        }

        str = str.Remove(0,1);


        if(cnt >0 )
        {
            writeError(strKey);
        }

        return str;
    }

    #region "Old function - log about file download"
    //public void writeToFile_Old(string str)
    //{
    //    StreamWriter objwriter;
    //    string url, ClientIPAdd;
    //    try
    //    {
    //        strFileName = ConfigurationManager.AppSettings.Get("DownloadLog");
    //        url = HttpContext.Current.Request.UrlReferrer.ToString();
    //        ClientIPAdd = HttpContext.Current.Request.UserHostAddress.ToString(); // IP Address
    //        //HttpContext.Current.Request.RawUrl.ToString()
    //        if(!File.Exists(strFileName))
    //        {
    //            File.Create(strFileName);
    //        }
    //        objwriter = new StreamWriter(strFileName, true);
    //        objwriter.WriteLine("URL : - " + url + "  Client IP : - " + ClientIPAdd + " and downloaded file is :- " + str + " At:- " + DateTime.Now.ToString());
    //        objwriter.WriteLine("--------------------------------------------");
    //        objwriter.Close();

    //    }
    //    catch(Exception ex)
    //    {
    //        ex.Message.ToString();
    //    }
    //}
    #endregion
}
