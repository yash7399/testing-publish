using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;

public partial class Docs : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();

    string strFilePath, strFilePath2, filename1, filename2, filename3, filename4, filename5, filename6, filename7, filename8, filename9, filename10, filename11, filename12;
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
    DirectoryInfo myDirInfo;

    protected void Page_Load(object sender, EventArgs e)
    {
        strFilePath2 = ConfigurationManager.AppSettings.Get("NCDEXDocs");
        myDirInfo = new DirectoryInfo(strFilePath2);
        if (!IsPostBack)
        {
            checkFiles();
        }

        strFilePath = ConfigurationManager.AppSettings.Get("MockNCDEXDocs");
        myDirInfo = new DirectoryInfo(strFilePath);
        if (!IsPostBack)
        {
            checkFiles1();
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

        //------------------------- NCDEX.Zip File -----------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("*" + year + ".zip"))
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
                if (File.Exists(strFilePath2 + filename1))
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

        //------------------------- DDMMYYYY.Zip File -----------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX.zip"))
            {
                srtFileList2.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList2.Count == 0)
            {
                filename2 = "";
                lblfname2.Text = filename2;
                lblimg2.Text = "Not Available";
            }
            else
            {
                filename2 = srtFileList2.Values[srtFileList2.Count - 1];
                if (File.Exists(strFilePath2 + filename2))
                {
                    lblfname2.Text = filename2;
                    Imagebutton2.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }







        //------------------------- Password Reset for Trading Application, VPN, Extranet.doc--------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("Password Reset for Trading Application ,  VPN , Extranet.doc"))
        //    {
        //        srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList3.Count == 0)
        //    {
        //        filename3 = "";
        //        lblfname3.Text = filename3;
        //        lblimg3.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename3 = srtFileList3.Values[srtFileList3.Count - 1];
        //        if (File.Exists(strFilePath + filename3))
        //        {
        //            lblfname3.Text = filename3;
        //            Imagebutton3.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //------------------------- Physical Delivery Guide.pdf  -----------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("Physical*" + ".pdf"))
        //    {
        //        srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList4.Count == 0)
        //    {
        //        filename4 = "";
        //        lblfname4.Text = filename4;
        //        lblimg4.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename4 = srtFileList4.Values[srtFileList4.Count - 1];
        //        if (File.Exists(strFilePath + filename4))
        //        {
        //            lblfname4.Text = filename4;
        //            Imagebutton4.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //-------------------------yearly_hi_lo.DAT  -----------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("yearly_hi_lo.DAT"))
        //    {
        //        srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList5.Count == 0)
        //    {
        //        filename5 = "";
        //        lblfname5.Text = filename5;
        //        lblimg5.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename5 = srtFileList5.Values[srtFileList5.Count - 1];
        //        if (File.Exists(strFilePath + filename5))
        //        {
        //            lblfname5.Text = filename5;
        //            Imagebutton5.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //-------------------------CSG letter.pdf -------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("CSG letter.pdf"))
        //    {
        //        srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList6.Count == 0)
        //    {
        //        filename6 = "";
        //        lblfname6.Text = filename6;
        //        lblimg6.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename6 = srtFileList6.Values[srtFileList6.Count - 1];
        //        if (File.Exists(strFilePath + filename6))
        //        {
        //            lblfname6.Text = filename6;
        //            Imagebutton6.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}
        //------------------------- Forwards contract file   -----------------------------------
        //    try
        //    {
        //        string strFilenaming = ConfigurationManager.AppSettings.Get("ForwardContract");
        //        foreach (FileInfo f1 in myDirInfo.GetFiles(strFilenaming+"*" + ".csv"))
        //        {
        //            srtFileList7.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //        }
        //        if (srtFileList7.Count == 0)
        //        {
        //            filename7 = "";
        //            lblfname7.Text = filename7;
        //            lblimg7.Text = "Not Available";
        //        }
        //        else
        //        {
        //            filename7 = srtFileList7.Values[srtFileList7.Count - 1];
        //            if (File.Exists(strFilePath + filename7))
        //            {
        //                lblfname7.Text = filename7;
        //                Imagebutton7.Visible = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logs.writeError(ex.ToString());
        //    }

    }
    private void checkFiles1()
    {
        string month, day, year, strdate;
        DateTime dte;


        dte = DateTime.Today;
        //DateTime dt1 = DateTime.Now;
        string dt1 = DateTime.Now.ToString(("M/dd/yyyy")); //Current date 
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



        //------------------------- Forwards contract file   -----------------------------------
        try
        {
            string dt3 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_01.csv"))
            {
                //DateTime dt3 = File.GetLastWriteTime(f1.FullName);  // Last modified date of files.
                dt3 = File.GetLastWriteTime(f1.FullName).ToString(("M/dd/yyyy")); // converted into string 
                srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);

            }

            // if (srtFileList3.Count == 0)  // these condition is not exists.
            if (dt1 != dt3)
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


        //----------------------------------------------------------------------------------------
        try
        {
            string dt4 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_02.csv"))
            {
                srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt4 = File.GetLastWriteTime(f1.FullName).ToString(("M/dd/yyyy")); // converted into string 
            }

            //if (srtFileList4.Count == 0)
            if (dt1 != dt4)
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

        //----------------------------------------------------------------------------------------
        try
        {
            String dt5 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("DLYMGN_" + "*_03.csv"))
            {
                srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt5 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            // if (srtFileList5.Count == 0)
            if (dt1 != dt5)
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

        //----------------------------------------------------------------------------------------
        try
        {
            String dt6 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA00.xml"))
            {
                srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt6 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            //if (srtFileList6.Count == 0)
            if (dt1 != dt6)
            {
                filename6 = "";
                lblfname6.Text = filename6;
                lblimg6.Text = "Not Available";
            }
            else
            {
                filename6 = srtFileList6.Values[srtFileList6.Count - 1];
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

        //----------------------------------------------------------------------------------------
        try
        {
            String dt7 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA01.xml"))
            {
                srtFileList7.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt7 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            //if (srtFileList7.Count == 0)
            if (dt1 != dt7)
            {
                filename7 = "";
                lblfname7.Text = filename7;
                lblimg7.Text = "Not Available";
            }
            else
            {
                filename7 = srtFileList7.Values[srtFileList7.Count - 1];
                if (File.Exists(strFilePath + filename7))
                {
                    lblfname7.Text = filename7;
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
            String dt8 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA02.xml"))
            {
                srtFileList8.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt8 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            // if (srtFileList8.Count == 0)
            if (dt1 != dt8)
            {
                filename8 = "";
                lblfname8.Text = filename8;
                lblimg8.Text = "Not Available";
            }
            else
            {
                filename8 = srtFileList8.Values[srtFileList8.Count - 1];
                if (File.Exists(strFilePath + filename8))
                {
                    lblfname8.Text = filename8;
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
            string dt9 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA03.xml"))
            {
                srtFileList9.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt9 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            //if (srtFileList9.Count == 0)
            if (dt1 != dt9)
            {
                filename9 = "";
                lblfname9.Text = filename9;
                lblimg9.Text = "Not Available";
            }
            else
            {
                filename9 = srtFileList9.Values[srtFileList9.Count - 1];
                if (File.Exists(strFilePath + filename9))
                {
                    lblfname9.Text = filename9;
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
            string dt10 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA04.xml"))
            {
                srtFileList10.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt10 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            // if (srtFileList10.Count == 0)
            if (dt1 != dt10)
            {
                filename10 = "";
                lblfname10.Text = filename10;
                lblimg10.Text = "Not Available";
            }
            else
            {
                filename10 = srtFileList10.Values[srtFileList10.Count - 1];
                if (File.Exists(strFilePath + filename10))
                {
                    lblfname10.Text = filename10;
                    ImageButton10.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        try
        {
            String dt11 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("*" + year + ".zip"))
            {
                srtFileList11.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt11 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }
            // if (srtFileList11.Count == 0)
            if (dt1 != dt11)
            {
                filename11 = "";
                lblfname11.Text = filename11;
                lblimg11.Text = "Not Available";
            }
            else
            {
                filename11 = srtFileList11.Values[srtFileList11.Count - 1];
                if (File.Exists(strFilePath + filename11))
                {
                    lblfname11.Text = filename11;
                    ImageButton11.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

        //------------------------- DDMMYYYY.Zip File -----------------------------------------------------------------
        try
        {
            String dt12 = "";
            foreach (FileInfo f1 in myDirInfo.GetFiles("NCDEX.zip"))
            {
                srtFileList12.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
                dt12 = File.GetLastWriteTime(f1.FullName).ToString("M/dd/yyyy");
            }

            //if (srtFileList12.Count == 0)
            if (dt1 != dt12)
            {
                filename12 = "";
                lblfname12.Text = filename12;
                lblimg12.Text = "Not Available";
            }
            else
            {
                filename12 = srtFileList12.Values[srtFileList12.Count - 1];
                if (File.Exists(strFilePath + filename12))
                {
                    lblfname12.Text = filename12;
                    ImageButton12.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
        //------------------------- Password Reset for Trading Application, VPN, Extranet.doc--------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("Password Reset for Trading Application ,  VPN , Extranet.doc"))
        //    {
        //        srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList3.Count == 0)
        //    {
        //        filename3 = "";
        //        lblfname3.Text = filename3;
        //        lblimg3.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename3 = srtFileList3.Values[srtFileList3.Count - 1];
        //        if (File.Exists(strFilePath + filename3))
        //        {
        //            lblfname3.Text = filename3;
        //            Imagebutton3.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //------------------------- Physical Delivery Guide.pdf  -----------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("Physical*" + ".pdf"))
        //    {
        //        srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList4.Count == 0)
        //    {
        //        filename4 = "";
        //        lblfname4.Text = filename4;
        //        lblimg4.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename4 = srtFileList4.Values[srtFileList4.Count - 1];
        //        if (File.Exists(strFilePath + filename4))
        //        {
        //            lblfname4.Text = filename4;
        //            Imagebutton4.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //-------------------------yearly_hi_lo.DAT  -----------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("yearly_hi_lo.DAT"))
        //    {
        //        srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList5.Count == 0)
        //    {
        //        filename5 = "";
        //        lblfname5.Text = filename5;
        //        lblimg5.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename5 = srtFileList5.Values[srtFileList5.Count - 1];
        //        if (File.Exists(strFilePath + filename5))
        //        {
        //            lblfname5.Text = filename5;
        //            Imagebutton5.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}

        //-------------------------CSG letter.pdf -------------------------------------
        //try
        //{
        //    foreach (FileInfo f1 in myDirInfo.GetFiles("CSG letter.pdf"))
        //    {
        //        srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //    }
        //    if (srtFileList6.Count == 0)
        //    {
        //        filename6 = "";
        //        lblfname6.Text = filename6;
        //        lblimg6.Text = "Not Available";
        //    }
        //    else
        //    {
        //        filename6 = srtFileList6.Values[srtFileList6.Count - 1];
        //        if (File.Exists(strFilePath + filename6))
        //        {
        //            lblfname6.Text = filename6;
        //            Imagebutton6.Visible = true;
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    logs.writeError(ex.ToString());
        //}
        //------------------------- Forwards contract file   -----------------------------------
        //    try
        //    {
        //        string strFilenaming = ConfigurationManager.AppSettings.Get("ForwardContract");
        //        foreach (FileInfo f1 in myDirInfo.GetFiles(strFilenaming+"*" + ".csv"))
        //        {
        //            srtFileList7.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
        //        }
        //        if (srtFileList7.Count == 0)
        //        {
        //            filename7 = "";
        //            lblfname7.Text = filename7;
        //            lblimg7.Text = "Not Available";
        //        }
        //        else
        //        {
        //            filename7 = srtFileList7.Values[srtFileList7.Count - 1];
        //            if (File.Exists(strFilePath + filename7))
        //            {
        //                lblfname7.Text = filename7;
        //                Imagebutton7.Visible = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logs.writeError(ex.ToString());
        //    }

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
    private void CommomFunction1(string filename, string filytpe)
    {
        try
        {
            logs.writeToFile(filename);
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=" + filename);
            Response.WriteFile(strFilePath2 + filename);
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
        CommomFunction1(logs.checkInputParam(lblfname1.Text), ".zip");
    }

    protected void Imagebutton2_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction1(logs.checkInputParam(lblfname2.Text), ".zip");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname3.Text), ".zip");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname4.Text), ".zip");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname5.Text), ".zip");
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname6.Text), ".zip");
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname7.Text), ".zip");
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname8.Text), ".zip");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname9.Text), ".zip");
    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname10.Text), ".zip");
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname11.Text), ".zip");
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblfname12.Text), ".zip");
    }
    //protected void Imagebutton3_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname3.Text), ".doc");
    //}

    //protected void Imagebutton4_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname4.Text), ".pdf");
    //}

    //protected void Imagebutton5_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname5.Text), ".dat");
    //}

    //protected void Imagebutton6_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname6.Text), ".pdf");
    //}
    //protected void Imagebutton7_Click(object sender, ImageClickEventArgs e)
    //{
    //    CommomFunction(logs.checkInputParam(lblfname7.Text), ".csv");
    //}
}
