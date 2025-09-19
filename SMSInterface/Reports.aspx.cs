using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;

public partial class Reports : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();

    string strFilePath, filename, filename1, filename2;
    SortedList<DateTime, string> srtFileList = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList1 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList2 = new SortedList<DateTime, string>();
    DirectoryInfo myDirInfo;

    protected void Page_Load(object sender, EventArgs e)
    {
        strFilePath = ConfigurationManager.AppSettings.Get("Reports");
        myDirInfo = new DirectoryInfo(strFilePath);
        if (!IsPostBack)
        {
            checkFiles();
        }

    }

    private void checkFiles()
    {

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX_CN01_*"))
            {
                srtFileList.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList.Count == 0)
            {
                filename = "";
                lblfname.Text = filename;
                lblReport.Text = "Not Available";
            }
            else
            {
                filename = srtFileList.Values[srtFileList.Count - 1];
                if (File.Exists(strFilePath + filename))
                {
                    lblfname.Text = filename;
                    ImageButton1.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
        //---------------------------------------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX_DATA.csv"))
        //    {
        //        srtFileList1.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList1.Count == 0)
        //    {
        //        filename1 = "";
        //        lblfname1.Text = filename1;
        //        lblData.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename1 = srtFileList1.Values[srtFileList1.Count - 1];
        //        if (File.Exists(strFilePath + filename1))
        //        {
        //            lblfname1.Text = filename1;
        //            ImageButton2.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //----------------------------GCOR -------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX_GCOR_*"))
            {
                srtFileList2.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList2.Count == 0)
            {
                filename2 = "";
                lblfname2.Text = filename2;
                lblGCOR.Text = "Not Available";
            }
            else
            {
                filename2 = srtFileList2.Values[srtFileList2.Count - 1];
                if (File.Exists(strFilePath + filename2))
                {
                    lblfname2.Text = filename2;
                    ImageButton3.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
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
        CommomFunction(logs.checkInputParam(lblfname.Text), ".csv");
    }

    //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname1.Text), ".csv");
    //}

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname2.Text), ".csv");
    }
}
