  <%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true" CodeFile="Archivess.aspx.cs" Inherits="Archivess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    NCDEX Archives
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div style="text-align:right;margin-right: 2%;margin-bottom:15px;">
        <asp:Button ID="btnBack" Text="Back" runat="server"  CssClass="button" Height="23" Width="65" 
            OnClick="btnBack_Click" Visible="false" />
    </div>
 
    <div style="margin-left: 2%;margin-bottom:15px;">
        <asp:Button ID="btnBhavcopy" Text="Bhavcopy" runat="server" CssClass="button" Height="23" Width="65" 
            OnClick="btnBhavcopy_Click" />
    </div>

    <asp:Panel ID="pnlBhavcopy" runat="server" Visible="False" style="margin-bottom:25px;">
        <table width="96%" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="mtitle" align="left">
                    <br />
                    <span class="mtitle">Bhavcopy</span><br />
                    <hr /><br />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ffcc66">
                    <table cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                        <tr>
                            <td class="toplink" bgcolor="#fcf5dc">&nbsp;File Name</td>
                            <td class="toplink" bgcolor="#fcf5dc">Download</td>
                        </tr>
                        <asp:PlaceHolder ID="phFiles" runat="server" />
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>

    

    <div style="margin-left: 2%;margin-bottom:15px;">
        <asp:Button ID="btnReports" Text="Reports" runat="server" CssClass="button" Height="23" Width="65" 
            OnClick="btnReports_Click" />
    </div>

    <asp:Panel ID="pnlReport" runat="server" Visible="False" style="margin-bottom:25px;" >
        <table width="96%" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="mtitle" align="left">
                    <br />
                    <span class="mtitle">Reports</span><br />
                    <hr /><br />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ffcc66">
                    <table cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                        <tr>
                            <td class="toplink" bgcolor="#fcf5dc">&nbsp;File Name</td>
                            <td class="toplink" bgcolor="#fcf5dc">Download</td>
                        </tr>
                        <asp:PlaceHolder ID="phReportFiles" runat="server" />
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>

    
      <div style="margin-left: 2%;margin-bottom:15px;">
        <asp:Button ID="btnParameter" Text="Parameter" runat="server" CssClass="button" Height="23" Width="65" 
            OnClick="btnParameter_Click" />
      </div>
       <asp:Panel ID="pnlParameter" runat="server" Visible="False" style="margin-bottom:25px;">
        <table width="96%" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="mtitle" align="left">
                    <br />
                    <span class="mtitle">Parameter</span><br />
                    <hr /><br />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ffcc66">
                    <table cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                        <tr>
                            <td class="toplink" bgcolor="#fcf5dc">&nbsp;File Name</td>
                            <td class="toplink" bgcolor="#fcf5dc">Download</td>
                        </tr>
                        <asp:PlaceHolder ID="phParameterFiles" runat="server" />
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
     
     <div style="margin-left: 2%;margin-bottom:15px;" >
        <asp:Button ID="btnNCDEXDOCS" Text="Ncdex Documents" runat="server" CssClass="button" Height="23" Width="115" 
            OnClick="btnNCDEXDOCS_Click" />
      </div>
     <asp:Panel ID="pnlNcdexDocs" runat="server" Visible="False" style="margin-bottom:25px;">
        <table width="96%" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="mtitle" align="left">
                    <br />
                    <span class="mtitle">Ncdex Documents</span><br />
                    <hr /><br />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ffcc66">
                    <table cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                        <tr>
                            <td class="toplink" bgcolor="#fcf5dc">&nbsp;File Name</td>
                            <td class="toplink" bgcolor="#fcf5dc">Download</td>
                        </tr>
                        <asp:PlaceHolder ID="phNcdexDocsFiles" runat="server" />
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
  
     <div style="margin-left: 2%;margin-bottom:15px;">
        <asp:Button ID="btnCommonBhavcopy" Text="Common Bhavcopy" runat="server" CssClass="button" Height="23" Width="115" 
            OnClick="btnCommonBhavcopy_Click" />
      </div>
     <asp:Panel ID="pnlCommonBhavcopy" runat="server" Visible="False" style="margin-bottom:25px;">
        <table width="96%" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="mtitle" align="left">
                    <br />
                    <span class="mtitle">Common Bhavcopy</span><br />
                    <hr /><br />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ffcc66">
                    <table cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                        <tr>
                            <td class="toplink" bgcolor="#fcf5dc">&nbsp;File Name</td>
                            <td class="toplink" bgcolor="#fcf5dc">Download</td>
                        </tr>
                        <asp:PlaceHolder ID="phCommonBhavcopyFiles" runat="server" />
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
    

</asp:Content>
