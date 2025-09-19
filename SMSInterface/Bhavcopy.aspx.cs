using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;


public partial class Bhavcopy : System.Web.UI.Page
{
    string strFilePath;
    // File fl;
    DirectoryInfo dr;
    FileInfo finfo;
    SortedList<DateTime, string> srtFileList1 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList6 = new SortedList<DateTime, string>();
    //SortedList<DateTime, string> srtFileList2 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList3 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList4 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList5 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileListnew = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileListnewp = new SortedList<DateTime, string>();

    //SortedList srtFileList1, srtFileList2, srtFileList3, srtFileList4, srtFileList5 ;
    DirectoryInfo myDirInfo;

    CommonFunctions logs = new CommonFunctions();

    protected void Page_Load(object sender, EventArgs e)
    {
        //string abc =Session["ID"].ToString();
        //string bcd = Session.SessionID.ToString(); 
        if (Session["ID"] != null)
        {
            if (Session["ID"].ToString() != Session.SessionID.ToString())
            {
                Session["ID"] = "";
                Session.Abandon();
                Response.Redirect("default.aspx");
            }
        }
        else
        {
            Session["ID"] = "";
            Session.Abandon();
            Response.Redirect("default.aspx");
        }

        strFilePath = ConfigurationManager.AppSettings.Get("BhavcocyFiles");
        myDirInfo = new DirectoryInfo(strFilePath);
        if (!IsPostBack)
        {
            checkFiles();
        }
    }

    private void checkFiles()
    {
        string filename1, filename6, filename3, filename4, filename5, filenamenew, filenamenewp; //filename2,
        //File fil;
        string month, day, year, strdate;
        DateTime dte;

        dte = DateTime.Today;
        day = dte.Day.ToString();
        month = dte.Month.ToString();
        year = dte.Year.ToString();

        if (day.Length < 2)
        {
            day = "0" + day;
        }

        if (month.Length < 2)
        {
            month = "0" + month;
        }

        //------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX_BC_" + "*"))
            {
                srtFileList1.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList1.Count == 0)
            {
                filename1 = "";
                lblfname1.Text = filename1;
                lblimg1.Text = "Not Available";
            }
            else
            {
                filename1 = srtFileList1.Values[srtFileList1.Count - 1];
                //= srtFileList1.GetByIndex(srtFileList1.Count - 1);
                if (File.Exists(strFilePath + filename1))
                {
                    lblfname1.Text = filename1;
                    ImageButton1.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //------------------------------------------------------------------------------TT 5290
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("Options_PB_Limits_*"))
            {
                srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList6.Count == 0)
            {
                filename6 = "";
                lblfname6.Text = filename6;
                lblimg6.Text = "Not Available";
            }
            else
            {
                filename6 = srtFileList6.Values[srtFileList6.Count - 1];
                //= srtFileList1.GetByIndex(srtFileList1.Count - 1);
                if (File.Exists(strFilePath + filename6))
                {
                    lblfname6.Text = filename6;
                    ImageButton6.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //------------------------------------------------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("*.ms"))
        //    {
        //        srtFileList2.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }

        //    if (srtFileList2.Count == 0)
        //    {
        //        filename2 = "";
        //        lblfname2.Text = filename2;
        //        lblimg2.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename2 = srtFileList2.Values[srtFileList2.Count - 1];

        //        if (File.Exists(strFilePath + filename2))
        //        {
        //            lblfname2.Text = filename2;
        //            ImageButton2.Visible = true;
        //        }
        //    }
        //}
        //catch(Exception ex)
        //{
        //logs.writeError(ex.ToString());
        //}

        //------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("*.md"))
            {
                srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }

            if (srtFileList3.Count == 0)
            {
                filename3 = "";
                lblfname3.Text = filename3;
                lblimg3.Text = "Not Available";
            }
            else
            {
                filename3 = srtFileList3.Values[srtFileList3.Count - 1];

                if (File.Exists(strFilePath + filename3))
                {
                    lblfname3.Text = filename3;
                    ImageButton3.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //------------------------------------------------------------------------------
        try
        {

            foreach (FileInfo f1 in myDirInfo.GetFiles("gen_rpt_mkt_watch.dat"))
            {
                srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }

            if (srtFileList4.Count == 0)
            {
                filename4 = "";
                lblfname4.Text = filename4;
                lblimg4.Text = "Not Available";
            }
            else
            {
                filename4 = srtFileList4.Values[srtFileList4.Count - 1];

                if (File.Exists(strFilePath + filename4))
                {
                    lblfname4.Text = filename4;
                    ImageButton4.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //------------------------------------------------------------------------------
        try
        {

            foreach (FileInfo f1 in myDirInfo.GetFiles("Provisional_BhavCopy_*" + ".xls"))
            {
                srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }

            if (srtFileList5.Count == 0)
            {
                filename5 = "";
                lblfname5.Text = filename5;
                lblimg5.Text = "Not Available";
            }
            else
            {
                filename5 = srtFileList5.Values[srtFileList5.Count - 1];

                if (File.Exists(strFilePath + filename5))
                {
                    lblfname5.Text = filename5;
                    ImageButton5.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        // Bhavcopy File (UDiFF) --- CR07114
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BhavCopy_NCD_CO_*_F_*" + ".csv"))
            //string[] allfiles = Directory.GetFileSystemEntries(strFilePath, "BhavCopy_NCD_CO_*_F_*" + ".csv", SearchOption.AllDirectories);
            {
                //Array.Reverse(allfiles);
               // srtFileListnew.Add(allfiles[0], fnam[4].ToString());
               srtFileListnew.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
              // srtFileListnew.Add(File.GetCreationTime(f1.FullName), f1.Name);
            }

            if (srtFileListnew.Count == 0)
            {
                filenamenew = "";
                lblfnamenew.Text = filenamenew;
                lblimgnew.Text = "Not Available";
            }
            else
            {
                filenamenew = srtFileListnew.Values[srtFileListnew.Count - 1];

                if (File.Exists(strFilePath + filenamenew))
                {
                    lblfnamenew.Text = filenamenew;
                    ImageButtonnew.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }


        // Provisional Bhavcopy File (UDiFF) --- CR07114
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BhavCopy_NCD_CO_*_P_*" + ".csv"))
            {
               srtFileListnewp.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                //srtFileListnewp.Add(File.GetCreationTime(f1.FullName), f1.Name);
            }

            if (srtFileListnewp.Count == 0)
            {
                filenamenewp = "";
                Label1.Text = filenamenewp;
                Label2.Text = "Not Available";
            }
            else
            {
                filenamenewp = srtFileListnewp.Values[srtFileListnewp.Count - 1];

                if (File.Exists(strFilePath + filenamenewp))
                {
                    Label1.Text = filenamenewp;
                    ImageButton2.Visible = true;
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
        CommomFunction(logs.checkInputParam(lblfname1.Text), ".dat");
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname6.Text), ".csv");
    }
    //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname2.Text), ".ms");
    //}

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname3.Text), ".md");
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname4.Text), ".dat");
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname5.Text), ".xls");
    }

    protected void ImageButtonnew_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfnamenew.Text), ".csv");
    }
    protected void ImageButtonnewp_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(Label1.Text), ".csv");
    }
}
