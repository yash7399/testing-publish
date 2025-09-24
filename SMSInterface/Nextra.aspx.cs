using System; 
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;
using System.Web.Services;

public partial class Nextra : System.Web.UI.Page
{

    CommonFunctions logs = new CommonFunctions();
    string strFilePath;
    string strFilePathDR;
    string strFilePath1;
    string strFilePath2;
    string strFilePath3;
   
    SortedList<DateTime, string> srtFileNextra319Main = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileNextra319INET = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileNextra319LAN = new SortedList<DateTime, string>();

    SortedList<DateTime, string> srtFileNextraSprtDocs64 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileNextraSprtDocs32 = new SortedList<DateTime, string>();

    SortedList<DateTime, string> srtFileNextraSprtDocsFU = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileNextraSprtDocsNEXTRA = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileNextraSprtDocsOLTB = new SortedList<DateTime, string>();

    DirectoryInfo myDirInfo, myDirInfo319;

     protected void Page_Load(object sender, EventArgs e)
    {
       /*   if (Session["ID"].ToString() != Session.SessionID.ToString())
        {
            Session["ID"] = "";
            Session.Abandon();
            Response.Redirect("default.aspx");
        } */

          strFilePath = ConfigurationManager.AppSettings.Get("WebsiteDownload") + "NEXTRA319\\Installable\\";
          //strFilePath = ConfigurationManager.AppSettings.Get("NEXTRADownloadMain");
          strFilePathDR = ConfigurationManager.AppSettings.Get("WebsiteDownload") + "DR\\";
          strFilePath1 = ConfigurationManager.AppSettings.Get("WebsiteDownload") + "PRIMARY\\";
          strFilePath2 = ConfigurationManager.AppSettings.Get("WebsiteDownload") + "HelpDocs\\";
          strFilePath3 = ConfigurationManager.AppSettings.Get("WebsiteDownload") + "Supporting Documents\\";
        
        
        if (!IsPostBack)
        {
            myDirInfo319 = new DirectoryInfo(strFilePath);
            myDirInfo = new DirectoryInfo(strFilePath3);
            checkFiles();
        }
    }

    private void checkFiles()
    {
        //string filename1, filename2, filename3, filename4, filename5, filename6;
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

        //--------------------------------------- TT 26144 and 6171 Start -------------------------------------------------

        try
        {
            foreach (FileInfo f1 in myDirInfo319.GetFiles(lblfname11.Text))
            {
                srtFileNextra319Main.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextra319Main.Count == 0)
            {
                lblimg11.Text = "Not Available";
            }
            else
            {
                ImageButton11.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }


        try
        {
            foreach (FileInfo f1 in myDirInfo319.GetFiles(lblfname12.Text))
            {
                srtFileNextra319INET.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextra319INET.Count == 0)
            {
                lblimg12.Text = "Not Available";
            }
            else
            {
                ImageButton12.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        try
        {
            foreach (FileInfo f1 in myDirInfo319.GetFiles(lblfname13.Text))
            {
                srtFileNextra319LAN.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextra319LAN.Count == 0)
            {
                lblimg13.Text = "Not Available";
            }
            else
            {
                ImageButton13.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //-------------------------------------- TT 26144 and 6171 end -------------------------------------

        //--------------------------------------- TT 05827 -------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles(lblfname20.Text))
            {
                srtFileNextraSprtDocs64.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextraSprtDocs64.Count == 0)
            {
                lblimg20.Text = "Not Available";
            }
            else
            {
                ImageButton20.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------------

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles(lblfname21.Text))
            {
                srtFileNextraSprtDocs32.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextraSprtDocs32.Count == 0)
            {
                lblimg21.Text = "Not Available";
            }
            else
            {
                ImageButton21.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }


        //----------------------------------------------------------------------------------------

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles(lblfname22.Text))
            {
                srtFileNextraSprtDocsFU.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextraSprtDocsFU.Count == 0)
            {
                lblimg22.Text = "Not Available";
            }
            else
            {
                ImageButton22.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles(lblfname23.Text))
            {
                srtFileNextraSprtDocsNEXTRA.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextraSprtDocsNEXTRA.Count == 0)
            {
                lblimg23.Text = "Not Available";
            }
            else
            {
                ImageButton23.Visible = true;
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles(lblfname24.Text))
            {
                srtFileNextraSprtDocsOLTB.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileNextraSprtDocsOLTB.Count == 0)
            {
                lblimg24.Text = "Not Available";
            }
            else
            {
                ImageButton24.Visible = true;
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


            if (filename == lblfname11.Text || filename == lblfname12.Text || filename == lblfname13.Text)

            {
                Response.WriteFile(strFilePath + filename);
                Response.ContentType = filytpe;
                Response.End();
            }


            else if (filename == lblfname14.Text || filename == lblfname15.Text || filename == lblfname16.Text || filename == lblfname17.Text || filename == lblfname18.Text)
            {
               
                Response.WriteFile(strFilePath1 + filename);
                Response.ContentType = filytpe;
                Response.End();
            }

            else if (filename == lblfname4.Text)
            {

                Response.WriteFile(strFilePath2 + filename);
                Response.ContentType = filytpe;
                Response.End();
            }

            else if (filename == lblfname19.Text || filename == lblfname20.Text || filename == lblfname21.Text || filename == lblfname22.Text || filename == lblfname23.Text || filename == lblfname24.Text)
            {

                Response.WriteFile(strFilePath3 + filename);
                Response.ContentType = filytpe;
                Response.End();
            }
           
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname4.Text), ".pdf");
    }


    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname11.Text), ".zip");
    }

    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname12.Text), ".zip");
    }

    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname13.Text), ".zip");
    }

    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname14.Text), ".zip");
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname15.Text), ".zip");
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname16.Text), ".zip");
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname17.Text), ".zip");
    }
    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname18.Text), ".zip");
    }

    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname19.Text), ".zip");
    }

    protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname20.Text), ".zip");
    }

    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname21.Text), ".zip");
    }


    protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname22.Text), ".zip");
    }

    protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname23.Text), ".zip");
    }

    protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname24.Text), ".zip");
    }
    
    
    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname1.Text), ".pdf");
    //}

    //protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname2.Text), ".pdf");
    //}

    //protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname3.Text), ".pdf");
    //}


    //protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname6.Text), ".zip");
    //}
    //protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname7.Text), ".zip");
    //}
    //protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname8.Text), ".zip");
    //}
    //protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname9.Text), ".zip");
    //}
}