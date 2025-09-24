using System;
using System.IO;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Archivess : System.Web.UI.Page
{
    CommonFunctions logs = new CommonFunctions();

    string strBhavcopyPath, strReportFilePath,strParametersFilePath,strCommonBhavCopyPath,strNcdexDocsPath;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        strBhavcopyPath = ConfigurationManager.AppSettings.Get("BhavcocyFiles");
        strReportFilePath = ConfigurationManager.AppSettings.Get("Reports");
        strParametersFilePath = ConfigurationManager.AppSettings.Get("Parameters");
        strNcdexDocsPath = ConfigurationManager.AppSettings.Get("NCDEXDOCS");
        strCommonBhavCopyPath = ConfigurationManager.AppSettings.Get("CommonBhavcopy");

        string activePanel = ViewState["ActivePanel"] as string;

        if (!IsPostBack)
        {
          
            pnlBhavcopy.Visible = false;
            pnlReport.Visible = false;
            pnlParameter.Visible = false;
            pnlCommonBhavcopy.Visible = false;
            pnlNcdexDocs.Visible = false;


            btnBack.Visible = false;

            btnBhavcopy.Visible = true;  // Bhavcopy
            btnReports.Visible = true;  // Reports
            btnParameter.Visible = true;  // Parameters
            btnNCDEXDOCS.Visible = true;  // Ncdex docs
            btnCommonBhavcopy.Visible = true;  // Common Bhavcopy

        }

        // Always bind files if a panel is active
        if (!string.IsNullOrEmpty(activePanel))
        {
            if (activePanel == "Bhavcopy")
                BindFiles(strBhavcopyPath, phFiles);
            else if (activePanel == "Report")
                BindFiles(strReportFilePath, phReportFiles);
            else if (activePanel == "Parameters")
                BindFiles(strParametersFilePath, phParameterFiles);
            else if (activePanel == "NCDEXDOCS")
                BindFiles(strNcdexDocsPath, phNcdexDocsFiles);
            else if (activePanel == "CommonBhavcopy")
                BindFiles(strCommonBhavCopyPath, phCommonBhavcopyFiles);
        }
        
    }

    protected void btnBhavcopy_Click(object sender, EventArgs e)
    {
        // Show Bhavcopy panel, hide everything else
        ViewState["ActivePanel"] = "Bhavcopy";

        pnlBhavcopy.Visible = true;

        pnlParameter.Visible = false;
        pnlReport.Visible = false;
        pnlCommonBhavcopy.Visible = false;
        pnlNcdexDocs.Visible = false;


        phReportFiles.Controls.Clear(); // Optional cleanup
        phParameterFiles.Controls.Clear(); // Optional cleanup
        phCommonBhavcopyFiles.Controls.Clear(); // optional cleanup
        phNcdexDocsFiles.Controls.Clear();  // optional cleanup


        BindFiles(strBhavcopyPath, phFiles);

        btnBack.Visible = true;

        btnBhavcopy.Visible = false;
        btnReports.Visible = false;
        btnParameter.Visible = false;
        btnNCDEXDOCS.Visible = false;
        btnCommonBhavcopy.Visible = false;
    }

    protected void btnReports_Click(object sender, EventArgs e)
    {
        // Show Reports panel, hide everything else
        ViewState["ActivePanel"] = "Report";

        pnlReport.Visible = true;

        pnlBhavcopy.Visible = false;
        pnlParameter.Visible = false;
        pnlCommonBhavcopy.Visible = false;
        pnlNcdexDocs.Visible = false;

        phFiles.Controls.Clear(); // Optional cleanup
        phParameterFiles.Controls.Clear(); // optional cleanup
        phCommonBhavcopyFiles.Controls.Clear(); // optional cleanup
        phNcdexDocsFiles.Controls.Clear();  // optional cleanup


        BindFiles(strReportFilePath, phReportFiles);

        btnBack.Visible = true;

        btnBhavcopy.Visible = false;
        btnReports.Visible = false;
        btnParameter.Visible = false;
        btnNCDEXDOCS.Visible = false;
        btnCommonBhavcopy.Visible = false;
    }
    protected void btnParameter_Click(object sender, EventArgs e)
    {
         
        ViewState["ActivePanel"] = "Parameters";

        pnlParameter.Visible = true;

        pnlReport.Visible = false;
        pnlBhavcopy.Visible = false;
        pnlCommonBhavcopy.Visible =false;
        pnlNcdexDocs.Visible = false;

       
        phFiles.Controls.Clear(); // Optional cleanup
        phReportFiles.Controls.Clear(); //  Optional cleanup
        phCommonBhavcopyFiles.Controls.Clear(); // optional cleanup
        phNcdexDocsFiles.Controls.Clear();  // optional cleanup



        BindFiles(strParametersFilePath,phParameterFiles);

        btnBack.Visible = true;

        btnBhavcopy.Visible = false;
        btnReports.Visible = false;
        btnParameter.Visible = false;
        btnNCDEXDOCS.Visible = false;
        btnCommonBhavcopy.Visible = false;

    }
    protected void btnNCDEXDOCS_Click(object sender, EventArgs e)
    {

        ViewState["ActivePanel"] = "NCDEXDOCS";

        pnlNcdexDocs.Visible = true;

        pnlParameter.Visible =false;
        pnlReport.Visible = false;
        pnlBhavcopy.Visible = false;
        pnlCommonBhavcopy.Visible = false;

        phFiles.Controls.Clear(); // Optional cleanup
        phReportFiles.Controls.Clear(); //  Optional cleanup
        phParameterFiles.Controls.Clear(); // optional cleanup
        phCommonBhavcopyFiles.Controls.Clear(); // optional cleanup

        BindFiles(strNcdexDocsPath, phNcdexDocsFiles);

        btnBack.Visible = true;

        btnBhavcopy.Visible = false;
        btnReports.Visible = false;
        btnParameter.Visible = false;
        btnNCDEXDOCS.Visible = false;
        btnCommonBhavcopy.Visible = false;


    }

    protected void btnCommonBhavcopy_Click(object sender, EventArgs e)
    {

        ViewState["ActivePanel"] = "CommonBhavcopy";

        pnlCommonBhavcopy.Visible = true;

        pnlNcdexDocs.Visible =false;
        pnlParameter.Visible = false;
        pnlReport.Visible = false;
        pnlBhavcopy.Visible = false;


        phFiles.Controls.Clear();  // Optional cleanup
        phReportFiles.Controls.Clear(); //  Optional cleanup
        phParameterFiles.Controls.Clear(); // optional cleanup
        phNcdexDocsFiles.Controls.Clear();  // optional cleanup


        BindFiles(strCommonBhavCopyPath, phCommonBhavcopyFiles);

        btnBack.Visible = true;

        btnBhavcopy.Visible = false;
        btnReports.Visible = false;
        btnParameter.Visible = false;
        btnNCDEXDOCS.Visible = false;
        btnCommonBhavcopy.Visible = false;


    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Reset to initial state
        pnlBhavcopy.Visible = false;
        pnlReport.Visible = false;
        pnlParameter.Visible = false;
        pnlCommonBhavcopy.Visible = false;
        pnlNcdexDocs.Visible = false;

        phFiles.Controls.Clear();
        phReportFiles.Controls.Clear();
        phParameterFiles.Controls.Clear();
        phCommonBhavcopyFiles.Controls.Clear();
        phNcdexDocsFiles.Controls.Clear();

        btnBack.Visible = false;
        btnBhavcopy.Visible = true;
        btnReports.Visible = true;
        btnParameter.Visible = true;
        btnNCDEXDOCS.Visible = true;
        btnCommonBhavcopy.Visible = true;
    }

    private void BindFiles(string folderPath, PlaceHolder ph)
    {
        try
        {
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
                return;

            FileInfo[] files = new DirectoryInfo(folderPath).GetFiles();
            if (files.Length == 0)
                return;

            ph.Controls.Clear();

            foreach (FileInfo f in files)
            {
                TableRow tr = new TableRow();

                // File Name cell
                TableCell tdName = new TableCell();
                tdName.CssClass = "bodytxt";
                tdName.Attributes["bgcolor"] = "#ffffff";
                tdName.Text = f.Name;
                tr.Cells.Add(tdName);

                // Download cell
                TableCell tdDownload = new TableCell();
                tdDownload.CssClass = "bodytxt";
                tdDownload.Attributes["bgcolor"] = "#ffffff";

                ImageButton imgBtn = new ImageButton();
                imgBtn.ImageUrl = "Images/download_file_icon.gif";
                imgBtn.CommandArgument = f.FullName;
                imgBtn.Click += Download_Click;

                tdDownload.Controls.Add(imgBtn);
                tr.Cells.Add(tdDownload);

                ph.Controls.Add(tr);
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
    }

    protected void Download_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton btn = (ImageButton)sender;
            string fullPath = logs.checkInputParam(btn.CommandArgument);

            if (File.Exists(fullPath))
            {
                string fileName = Path.GetFileName(fullPath);
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
                Response.ContentType = "application/octet-stream";
                Response.WriteFile(fullPath);
                Response.Flush();
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            else
            {
                logs.writeError("File not found: " + fullPath);
            }
        }
        catch (Exception ex)
        {
            logs.writeError(ex.ToString());
        }
    }
}
