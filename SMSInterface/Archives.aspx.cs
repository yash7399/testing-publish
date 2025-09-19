using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Configuration;

public partial class Archives : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();
    string strFilePath, filename1, filename2, filename3, filename4, filename5, filename6, filename7, filename8, filename9, filename15, filename16;
    DirectoryInfo myDirInfo;
    //SortedList<string, string> srtFileList = new SortedList<string, string>();
    SortedList<DateTime, string> srtFileList = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList1 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList2 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList3 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList4 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList5 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList6 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList7 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList8 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList15 = new SortedList<DateTime, string>();
    SortedList<DateTime, string> srtFileList16 = new SortedList<DateTime, string>();

    protected void Page_Load(object sender, EventArgs e)
    {
        strFilePath = ConfigurationManager.AppSettings.Get("Parameters") + "History\\";
        myDirInfo = new DirectoryInfo(strFilePath);
        BindParamtersArchives();
    }

    public void BindParamtersArchives()
    {
        try
        {
            //foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA" + "*.xml"))
            //{
            //    //srtFileList.Add(File.GetLastWriteTime(f1.FullName), f1.Name);

            //    srtFileList.Add( Path.GetFileName(f1.FullName), f1.Name);
            //}
            //if (srtFileList.Count == 0)
            //{

            //    filename1 = "";
            //    lblPfname1.Text = filename1;
            //    lblimg1.Text = "Not Available";

            
            //    lblPfname2.Text = filename1;
            //    lblimg2.Text = "Not Available";
               

            //    lblPfname3.Text = filename1;
            //    lblimg3.Text = "Not Available";

            //    lblPfname4.Text = filename1;
            //    lblimg4.Text = "Not Available";
             

            //    lblPfname5.Text = filename1;
            //    lblimg5.Text = "Not Available";
         
            //    lblPfname6.Text = filename1;
            //    lblimg6.Text = "Not Available";

             
            //    lblPfname7.Text = filename1;
            //    lblimg7.Text = "Not Available";

            //    lblPfname8.Text = filename1;
            //    lblimg8.Text = "Not Available";

            //    lblPfname9.Text = filename1;
            //    lblimg9.Text = "Not Available";
            //}
            //else 
            //{
              

            //    if (File.Exists(strFilePath + srtFileList.Values[0]))
            //    {
            //        lblPfname1.Text = srtFileList.Values[0];
            //        ImageButton1.Visible = true;
            //    }
            //    if (File.Exists(strFilePath + srtFileList.Values[1]))
            //    {
            //        lblPfname2.Text = srtFileList.Values[1];
            //        ImageButton2.Visible = true;
            //    }
            //    if (File.Exists(strFilePath + srtFileList.Values[2]))
            //    {
            //        lblPfname3.Text = srtFileList.Values[2];
            //        ImageButton3.Visible = true;
            //    }
            //    if (File.Exists(strFilePath + srtFileList.Values[3]))
            //    {
            //        lblPfname4.Text = srtFileList.Values[3];
            //        ImageButton4.Visible = true;
            //    }
            //    if (File.Exists(strFilePath + srtFileList.Values[4]))
            //    {
            //        lblPfname5.Text = srtFileList.Values[4];
            //        ImageButton5.Visible = true;
            //    }
            //    if (File.Exists(strFilePath + srtFileList.Values[5]))
            //    {
            //        lblPfname6.Text = srtFileList.Values[5];
            //        ImageButton6.Visible = true;
            //    }

            //    if (File.Exists(strFilePath + srtFileList.Values[6]))
            //    {
            //        lblPfname7.Text = srtFileList.Values[6];
            //        ImageButton7.Visible = true;
            //    }

            //    if (File.Exists(strFilePath + srtFileList.Values[7]))
            //    {
            //        lblPfname8.Text = srtFileList.Values[7];
            //        ImageButton8.Visible = true;
            //    }

            //    if (File.Exists(strFilePath + srtFileList.Values[8]))
            //    {
            //        lblPfname9.Text = srtFileList.Values[8];
            //        ImageButton9.Visible = true;
            //    }
            //}
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA00.xml"))
            {
                srtFileList.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList.Count == 0)
            {
                filename1 = "";
                lblPfname1.Text = filename1;
                lblimg1.Text = "Not Available";
            }
            else
            {
                filename1 = srtFileList.Values[srtFileList.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA01.xml"))
            {
                srtFileList1.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList1.Count == 0)
            {
                filename2 = "";
                lblPfname2.Text = filename2;
                lblimg2.Text = "Not Available";
            }
            else
            {
                filename2 = srtFileList1.Values[srtFileList1.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA02.xml"))
            {
                srtFileList2.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList2.Count == 0)
            {
                filename3 = "";
                lblPfname3.Text = filename3;
                lblimg3.Text = "Not Available";
            }
            else
            {
                filename3 = srtFileList2.Values[srtFileList2.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA03.xml"))
            {
                srtFileList3.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList3.Count == 0)
            {
                filename4 = "";
                lblPfname4.Text = filename4;
                lblimg4.Text = "Not Available";
            }
            else
            {
                filename4 = srtFileList3.Values[srtFileList3.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA04.xml"))
            {
                srtFileList4.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList4.Count == 0)
            {
                filename5 = "";
                lblPfname5.Text = filename5;
                lblimg5.Text = "Not Available";
            }
            else
            {
                filename5 = srtFileList4.Values[srtFileList4.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA05.xml"))
            {
                srtFileList5.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList5.Count == 0)
            {
                filename6 = "";
                lblPfname6.Text = filename6;
                lblimg6.Text = "Not Available";
            }
            else
            {
                filename6 = srtFileList5.Values[srtFileList5.Count - 1];
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
        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA06.xml"))
            {
                srtFileList6.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList6.Count == 0)
            {
                filename7 = "";
                lblPfname7.Text = filename7;
                lblimg7.Text = "Not Available";
            }
            else
            {
                filename7 = srtFileList6.Values[srtFileList6.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA07.xml"))
            {
                srtFileList7.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList7.Count == 0)
            {
                filename8 = "";
                lblPfname8.Text = filename8;
                lblimg8.Text = "Not Available";
            }
            else
            {
                filename8 = srtFileList7.Values[srtFileList7.Count - 1];
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

        //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("BMS_RA08.xml"))
            {
                srtFileList8.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList8.Count == 0)
            {
                filename9 = "";
                lblPfname9.Text = filename9;
                lblimg9.Text = "Not Available";
            }
            else
            {
                filename9 = srtFileList8.Values[srtFileList8.Count - 1];
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
       //  ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("OLD_BMS_RA00.xml"))
            {
                srtFileList15.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList15.Count == 0)
            {
                filename15 = "";
                lblPfname15.Text = filename15;
                lblimg15.Text = "Not Available";
            }
            else
            {
                filename15 = srtFileList15.Values[srtFileList15.Count - 1];
                if (File.Exists(strFilePath + filename15))
                {
                    lblPfname15.Text = filename15;
                    ImageButton15.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }

       // ----------------------------------------------------------------------------------------
        try
        {
            foreach (FileInfo f1 in myDirInfo.GetFiles("OLD_BMS_RA08.xml"))
            {
                srtFileList16.Add(File.GetLastWriteTime(f1.FullName), f1.Name);
            }
            if (srtFileList16.Count == 0)
            {
                filename16 = "";
                lblPfname16.Text = filename16;
                lblimg16.Text = "Not Available";
            }
            else
            {
                filename16 = srtFileList16.Values[srtFileList16.Count - 1];
                if (File.Exists(strFilePath + filename16))
                {
                    lblPfname16.Text = filename16;
                    ImageButton16.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname1.Text), ".xml");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname2.Text), ".xml");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname3.Text), ".xml");
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

    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname15.Text), ".xml");
    }

    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        CommomFunction(logs.checkInputParam(lblPfname16.Text), ".xml");
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

}