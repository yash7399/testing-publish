<%@ Page Language="C#" AutoEventWireup="true" CodeFile="404ErrorPage.aspx.cs" Inherits="_404ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NCDEX Common Files</title>
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="-1" />
    <%--<meta http-equiv="CACHE-CONTROL" content="NO-CACHE">--%>
    <meta http-equiv="CACHE-CONTROL" content="No-Store" />
    <link href="CSS/NCDEX.CSS" type="text/css" rel="stylesheet" />
    
    <style type="text/css">
        #lblCaptchaMessage {
            color: red !important;
        }

        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            font-weight: normal;
            padding: 3px;
            text-decoration: none;
            color: #000000;
            height: 23px;
        }

        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body bgcolor="#ffffff" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <%--<div id="AntiForgeryToken" runat="server">--%>

    <%-- </div>--%>
    <form id="Form1" runat="server">
        <asp:Literal ID="AntiForgeryToken" runat="server" />
        <%--  <%= System.Web.Helpers.AntiForgery.GetHtml() %>  --%>
        <div align="center">
            <table cellspacing="0" cellpadding="0" width="776" border="0">
                <tr>
                    <td style="width: 236px" valign="top" width="242"><a href="http://www.ncdex.com/">
                        <img height="90" src="Images/logonew.gif" border="0"></a>
                    </td>
                    <td class="Tophead" valign="top" align="center" width="69%">
                        <br>
                        NCDEX Common Files
                    </td>
                </tr>
                <!-- Body content starts here -->
                <tr>
                    <td valign="top" colspan="2">
                        <table bordercolor="#990000" cellspacing="0" cellpadding="0" width="100%" border="1">
                            <tr>
                                <td valign="middle" align="center">
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <!-- Login screen for member starts here -->
                                    <asp:Label ID="lblErrorMsg" runat="server" Text="An error has occurred... kindly connect with Admin" Font-Bold="True" ForeColor="Red"></asp:Label>
                                    <!-- Login screen for memebr ends here -->
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <!-- Body content Ends here -->
               
            </table>
        </div>
    </form>
</body>
</html>
