using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;

public partial class Parameters : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();

    string strFilePath, filename1, filename2, filename3, filename4, filename5, filename6, filename7, filename8, filename9, filename10, filename11, filename12, filename13, filename14, filename15, filename16;
    SortedList<DateTime, string> srtFileList1 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList2 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList3 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList4 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList5 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList6 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList7 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList8 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList9 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList10 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList11 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList12 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList13 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList14 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList15 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList16 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileDateTime1 = new SortedList<DateTime, string>();
    DirectoryInfo myDirInfo;

    protected void Page_Load(object sender, EventArgs e)
    {
        strFilePath = ConfigurationManager.AppSettings.Get("Parameters");

        myDirInfo = new DirectoryInfo(strFilePath);
        if (!IsPostBack)
        {
            checkFiles();
        }
       
    }

    private void checkFiles()
    {
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

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_01.csv"))
            {
                srtFileList1.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList1.Count == 0)
            {
                filename1 = "";
                lblPfname1.Text = filename1;
                lblimg1.Text = "Not Available";
            }
            else
            {
                filename1 = srtFileList1.Values[srtFileList1.Count - 1];
                if (File.Exists(strFilePath + filename1))
                {
                    lblPfname1.Text = filename1;
                    ImageButton1.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }


        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_02.csv"))
            {
                srtFileList2.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList2.Count == 0)
            {
                filename2 = "";
                lblPfname2.Text = filename2;
                lblimg2.Text = "Not Available";
            }
            else
            {
                filename2 = srtFileList2.Values[srtFileList2.Count - 1];
                if (File.Exists(strFilePath + filename2))
                {
                    lblPfname2.Text = filename2;
                    ImageButton2.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_03.csv"))
            {
                srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList3.Count == 0)
            {
                filename3 = "";
                lblPfname3.Text = filename3;
                lblimg3.Text = "Not Available";
            }
            else
            {
                filename3 = srtFileList3.Values[srtFileList3.Count - 1];
                if (File.Exists(strFilePath + filename3))
                {
                    lblPfname3.Text = filename3;
                    ImageButton3.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA00.xml"))
            {
                srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList4.Count == 0)
            {
                filename4 = "";
                lblPfname4.Text = filename4;
                lblimg4.Text = "Not Available";
            }
            else
            {
                filename4 = srtFileList4.Values[srtFileList4.Count - 1];
                if (File.Exists(strFilePath + filename4))
                {
                    lblPfname4.Text = filename4;
                    ImageButton4.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA01.xml"))
            {
                srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList5.Count == 0)
            {
                filename5 = "";
                lblPfname5.Text = filename5;
                lblimg5.Text = "Not Available";
            }
            else
            {
                filename5 = srtFileList5.Values[srtFileList5.Count - 1];
                if (File.Exists(strFilePath + filename5))
                {
                    lblPfname5.Text = filename5;
                    ImageButton5.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA02.xml"))
            {
                srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList6.Count == 0)
            {
                filename6 = "";
                lblPfname6.Text = filename6;
                lblimg6.Text = "Not Available";
            }
            else
            {
                filename6 = srtFileList6.Values[srtFileList6.Count - 1];
                if (File.Exists(strFilePath + filename6))
                {
                    lblPfname6.Text = filename6;
                    ImageButton6.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA03.xml"))
            {
                srtFileList7.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList7.Count == 0)
            {
                filename7 = "";
                lblPfname7.Text = filename7;
                lblimg7.Text = "Not Available";
            }
            else
            {
                filename7 = srtFileList7.Values[srtFileList7.Count - 1];
                if (File.Exists(strFilePath + filename7))
                {
                    lblPfname7.Text = filename7;
                    ImageButton7.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA04.xml"))
            {
                srtFileList8.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList8.Count == 0)
            {
                filename8 = "";
                lblPfname8.Text = filename8;
                lblimg8.Text = "Not Available";
            }
            else
            {
                filename8 = srtFileList8.Values[srtFileList8.Count - 1];
                if (File.Exists(strFilePath + filename8))
                {
                    lblPfname8.Text = filename8;
                    ImageButton8.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA05.xml"))
            {
                srtFileList9.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList9.Count == 0)
            {
                filename9 = "";
                lblPfname9.Text = filename9;
                lblimg9.Text = "Not Available";
            }
            else
            {
                filename9 = srtFileList9.Values[srtFileList9.Count - 1];
                if (File.Exists(strFilePath + filename9))
                {
                    lblPfname9.Text = filename9;
                    ImageButton9.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA06.xml"))
            {
                srtFileList10.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList10.Count == 0)
            {
                filename10 = "";
                lblPfname10.Text = filename10;
                lblimg10.Text = "Not Available";
            }
            else
            {
                filename10 = srtFileList10.Values[srtFileList10.Count - 1];
                if (File.Exists(strFilePath + filename10))
                {
                    lblPfname10.Text = filename10;
                    ImageButton10.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA07.xml"))
            {
                srtFileList13.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList13.Count == 0)
            {
                filename13 = "";
                lblPfname13.Text = filename13;
                lblimg13.Text = "Not Available";
            }
            else
            {
                filename13 = srtFileList13.Values[srtFileList13.Count - 1];
                if (File.Exists(strFilePath + filename13))
                {
                    lblPfname13.Text = filename13;
                    ImageButton13.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA08.xml"))
            {
                srtFileList14.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList14.Count == 0)
            {
                filename14 = "";
                lblPfname14.Text = filename14;
                lblimg14.Text = "Not Available";
            }
            else
            {
                filename14 = srtFileList14.Values[srtFileList14.Count - 1];
                if (File.Exists(strFilePath + filename14))
                {
                    lblPfname14.Text = filename14;
                    ImageButton14.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("Indicative_Margin_Percentages_" + "*.csv"))
            {
                srtFileList11.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList11.Count == 0)
            {
                filename11 = "";
                lblPfname11.Text = filename11;
                lblimg11.Text = "Not Available";
            }
            else
            {
                filename11 = srtFileList11.Values[srtFileList11.Count - 1];
                if (File.Exists(strFilePath + filename11))
                {
                    lblPfname11.Text = filename11;
                    ImageButton11.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }


        //----------------------------------------------------------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("OLD_BMS_RA00.xml"))
        //    {
        //        srtFileList15.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList15.Count == 0)
        //    {
        //        filename15 = "";
        //        lblPfname15.Text = filename15;
        //        lblimg15.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename15 = srtFileList15.Values[srtFileList15.Count - 1];
        //        if (File.Exists(strFilePath + filename15))
        //        {
        //            lblPfname15.Text = filename15;
        //            ImageButton15.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //----------------------------------------------------------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("OLD_BMS_RA08.xml"))
        //    {
        //        srtFileList16.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList16.Count == 0)
        //    {
        //        filename16 = "";
        //        lblPfname16.Text = filename16;
        //        lblimg16.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename16 = srtFileList16.Values[srtFileList16.Count - 1];
        //        if (File.Exists(strFilePath + filename16))
        //        {
        //            lblPfname16.Text = filename16;
        //            ImageButton16.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}
        //----------------------------------------------------------------------------------------

        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RPF_" + "*.xml"))
            {
                srtFileList12.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList12.Count == 0)
            {

                filename12 = "";
                lblPfname12.Text = filename12;
                lblimg12.Text = "Not Available";

                //filename13 = "";
                //lblPfname13.Text = filename13;
                //lblimg13.Text = "Not Available";
            }
            else
            {
                filename12 = srtFileList12.Values[srtFileList12.Count - 1];
                //filename13 = srtFileList12.Values[srtFileList12.Count - 2];

                if (File.Exists(strFilePath + filename12))
                {
                    lblPfname12.Text = filename12;
                    ImageButton12.Visible = true;
                }
                //else
                //{
                //    filename12 = "";
                //    lblPfname12.Text = filename12;
                //    lblimg12.Text = "Not Available";
                //}

                //if (File.Exists(strFilePath + filename13))
                //{
                //    lblPfname13.Text = filename13;
                //    ImageButton13.Visible = true;
                //}
                //else
                //{
                //    filename13 = "";
                //    lblPfname13.Text = filename13;
                //    lblimg13.Text = "Not Available";
                //}
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
        CommomFunction(logs.checkInputParam(lblPfname1.Text), ".csv");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname2.Text), ".csv");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname3.Text), ".csv");
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname4.Text), ".xml");
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname5.Text), ".xml");
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname6.Text), ".xml");
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname7.Text), ".xml");
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname8.Text), ".xml");
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname9.Text), ".xml");
    }

    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname10.Text), ".xml");
    }

    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname11.Text), ".csv");
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname12.Text), ".xml");
    }

       protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname13.Text), ".xml");
    }

    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname14.Text), ".xml");
    }

    //protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblPfname15.Text), ".xml");
    //}

    //protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblPfname16.Text), ".xml");
    //}
    
}
