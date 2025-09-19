<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="Include/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>
<%@ Register Assembly="WebControlCaptcha" Namespace="WebControlCaptcha" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NCDEX Common Files</title>
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="-1" />
    <%--<meta http-equiv="CACHE-CONTROL" content="NO-CACHE">--%>
    <meta http-equiv="CACHE-CONTROL" content="No-Store" />
    <link href="CSS/NCDEX.CSS" type="text/css" rel="stylesheet" />
    <script type="text/javascript" language="javascript">
        history.forward();
        function ChangePassword(obj) {
            debugger;
            var result = Encrypt(document.getElementById("txtPassword").value);
            document.getElementById("txtPassword").value = result;
            return true;
        }

        function Encrypt(value) {
            var result = "";
            for (i = 0; i < value.length; i++) {
                if (i < value.length - 1) {
                    result += value.charCodeAt(i) + 10;
                    result += "-";
                }
                else {
                    result += value.charCodeAt(i) + 10;
                }
            }
            return result;
        }

    </script>

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
    <form id="Form1" method="post" runat="server" defaultbutton="Button1">
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
                                    <table class="tableborder" cellspacing="1" cellpadding="0" width="350" bgcolor="#f7f7f7"
                                        border="0">
                                        <tr>
                                            <td class="heading" align="center" width="36%">NCDEX Common Files<br>
                                                Member Login
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellspacing="3" cellpadding="0" width="100%" border="0">
                                                    <tr>
                                                        <td class="login" width="40%" align="left">User Name:
                                                        </td>
                                                        <td align="left" style="padding-left: 5px;">
                                                            <asp:TextBox ID="txtUsername" runat="server" Width="97px" MaxLength="8"
                                                                TabIndex="1"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="Login"
                                                                ErrorMessage="Enter UserName" ControlToValidate="txtUsername">*</asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="login" height="23" align="left">Password:
                                                        </td>
                                                        <td height="23" align="left" style="padding-left: 5px;">
                                                            <asp:TextBox ID="txtPassword" runat="server" Width="97px" TextMode="Password"
                                                                MaxLength="10" TabIndex="2"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="Login"
                                                                ErrorMessage="Enter Password" ControlToValidate="txtPassword">*</asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    <tr id="trCapcha" runat="server">
                                                        <td class="auto-style1" align="left" valign="top">Enter the code shown:
                                                        </td>
                                                        <td align="left" class="auto-style2">
                                                            <%-- <cc1:CaptchaControl ID="cptc" runat="server" Width="125" CaptchaMaxTimeout="150" 
                                                                        Font-Names="Arial" Font-Size="Small" Text="" CaptchaWidth="175" 
                                                                        TabIndex="3" CaptchaChars="ACDEFGHJKLNPQRTUVXYZ2346789" />
                                                            <br /> 
                                                                <asp:ImageButton ID="imgCPTC" runat="server" ImageUrl="~/Images/refresh.jpg" 
                                                                        BorderWidth="0" onclick="imgCPTC_Click" AlternateText="Refresh Code" 
                                                                        TabIndex="10" />--%>
                                                            <asp:Image ID="Image2" runat="server" Height="45px" ImageUrl="~/Capcha.aspx" Width="165px" />

                                                        </td>
                                                        <td width="15%">
                                                            <asp:ImageButton ID="cmdResetCaptcha" runat="server" ImageUrl="~/Images/Reset.gif" ToolTip="Reset Captcha"
                                                                ImageAlign="Top" CausesValidation="False" OnClick="ResetCaptcha_Btn_Click" /></td>

                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style1" align="left" valign="top"></td>
                                                        <td align="left" class="auto-style2">
                                                            <asp:TextBox runat="server" ID="TextBox1" Width="150" Font-Size="Small" MaxLength="15"></asp:TextBox>
                                                            <br />
                                                            <asp:Label runat="server" ID="lblCaptchaMessage"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <%-- <td width="15%">
                                                            <asp:Button ID="cmdResetCaptcha" TabIndex="3" runat="server" ForeColor="Black" Width="150" Font-Bold="True" 
                                                                Font-Names="Arial" Text="Captcha Reset" BackColor="Menu" BorderStyle="Double" ToolTip="Reset Captcha" OnClick="cmdSubmit0_Click" Height="25px"></asp:Button>
                                                        </td>--%>
                                                        <%-- <td width="15%">
                                                            <asp:Button ID="cmdResetCaptcha" TabIndex="3" runat="server" ImageUrl="~/Images/Reset.gif" ToolTip="Reset Captcha" OnClick="cmdSubmit0_Click" Height="25px"></asp:Button>
                                                        </td>--%>
                                                        <td></td>
                                                        <td align="left" width="10%" runat="server" id="trcmdResetCaptcha">
                                                            <asp:Button ID="Button1" runat="server" Width="45" Text="Login" OnClientClick="ChangePassword(this);" ValidationGroup="Login"
                                                                CssClass="button" OnClick="Button1_Click" Height="23" TabIndex="4"></asp:Button>
                                                        </td>
                                                        <td class="login" align="center" colspan="2">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="login" align="center" colspan="2">
                                                            <asp:Label ID="lblError" runat="server" Visible="False" ForeColor="Red"></asp:Label><br>
                                                            <%--<asp:ValidationSummary ID="ValidationSummary1" runat="server"></asp:ValidationSummary>--%>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
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
                <tr>
                    <td colspan="2" align="left">
                        <uc2:bottom ID="bottom1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
