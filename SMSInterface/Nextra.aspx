<%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true"
    CodeFile="Nextra.aspx.cs" Inherits="Nextra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table id="Table3" cellspacing="0" cellpadding="0" width="96%" align="center" border="0">
        <tr>
            <td class="mtitle" align="left">
                <br>
                <span class="mtitle">Nextra</span><br>
                <hr>
                <br>
            </td>
        </tr>
        <tr>
            <td bgcolor="#ffcc66">
                <!-- Content Starts -->
                <table id="Table1" cellspacing="1" cellpadding="4" width="100%" border="0" class="tblcls">
                    <tr>
                        <td class="toplink" bgcolor="#fcf5dc">
                            File Description
                        </td>
                        <td class="toplink" bgcolor="#fcf5dc">
                            File Name
                        </td>
                        <td class="toplink" bgcolor="#fcf5dc">
                            Download
                        </td>
                    </tr>
                  <%-- START TT 26144 and 6171 --%>
                    <tr>
                        <td colspan="3" bgcolor="#fcf5dc" class="toplink">
                            NEXTRA 3.19
                        </td>
                    </tr>
                     
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname11" runat="server">Nextra_3.19.1.100.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg11" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton11"
                                    Visible="True" OnClick="ImageButton11_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                      
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Online Trade<br />Backup - INET
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname12" runat="server">nextra_online_trade_backup_1.9.0.0_For_INET.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg12" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton12"
                                    Visible="True" OnClick="ImageButton12_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                     <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Online Trade<br />Backup - LAN
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname13" runat="server">nextra_Online_Trade_backup_1.9.0.0_For_LAN.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg13" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton13"
                                    Visible="True" OnClick="ImageButton13_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                    
                    <%-- END TT 26144 and 6171 --%>
                   

                     <tr>
                        <td colspan="3" bgcolor="#fcf5dc" class="toplink">
                            Primary
                        </td>
                    </tr>
                     
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nest File Uploader<br /> - INET 
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname14" runat="server">nest_file_uploader_2.2.125.0_INET_blade_ncdex.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg14" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton14"
                                    Visible="True" OnClick="ImageButton14_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                     <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nest File Uploader<br /> - LAN
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname15" runat="server">nest_file_uploader_2.2.125.0_LAN_blade_ncdex.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg15" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton15"
                                    Visible="True" OnClick="ImageButton15_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                     <tr> <!-- style="display:none;" -->
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname16" runat="server">NEXTRA_3.15.1.4.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg16" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton16"
                                    Visible="True" OnClick="ImageButton16_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Online Trade<br /> Backup - INET
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname17" runat="server">nextra_online_trade_backup.1.7.1.0_For_INET.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg17" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton17"
                                    Visible="True" OnClick="ImageButton17_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Online Trade<br /> Backup - LAN
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname18" runat="server">nextra_online_trade_backup.1.7.1.0_For_LAN.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg18" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton18"
                                    Visible="True" OnClick="ImageButton18_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                     <tr>
                        <td colspan="3" bgcolor="#fcf5dc" class="toplink">
                            Help Documents
                        </td>
                    </tr>
                     <%-- Removed As per TT 5104--%>
                   <%-- <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Quick Guide
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname1" runat="server">NEXTRA_QuickGuide.pdf</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg1" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton1"
                                    Visible="True" OnClick="ImageButton1_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Complete Guide
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname2" runat="server">NEXTRA_Helpdoc.pdf</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg2" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton2"
                                    Visible="True" OnClick="ImageButton2_Click1"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Rules in RMS
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname3" runat="server">NEXTRA_RMS_Rules_Helpdoc.pdf</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg3" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton3"
                                    Visible="True" OnClick="ImageButton3_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>--%>
                     <%-- Removed END As per TT 5104--%>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff" style="height: 39px">
                            Nextra File Uploader<br /> Help Doc
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff" style="height: 39px">
                            <asp:Label ID="lblfname4" runat="server">NEXTRA_Fileuploader_Helpdoc.pdf</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff" style="height: 39px">
                            <asp:Label ID="lblimg4" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton4"
                                    Visible="True" OnClick="ImageButton4_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                   
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nextra Training manual
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            E-book on Nextra_version final_print.pdf
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/E-book on Nextra_version final_print.pdf" target="_blank">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" bgcolor="#fcf5dc" class="toplink">
                            Supporting Documents
                        </td>
                    </tr>
                     
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Nest File Uploader
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname19" runat="server">Document.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg19" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton19"
                                    Visible="True" OnClick="ImageButton19_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NAP FILE - 64 bit
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname20" runat="server">nextra.nap_x64.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg20" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton20"
                                    Visible="True" OnClick="ImageButton20_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NAP FILE - 32 bit
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname21" runat="server">nextra.nap_x32.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg21" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton21"
                                    Visible="True" OnClick="ImageButton21_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                    <%-- TT Start 06068 --%>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            FU
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname22" runat="server">FU.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg22" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton22"
                                    Visible="True" OnClick="ImageButton22_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname23" runat="server">NEXTRA.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg23" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton23"
                                    Visible="True" OnClick="ImageButton23_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            OLTB
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname24" runat="server">OLTB.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg24" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton24"
                                    Visible="True" OnClick="ImageButton24_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    
                    <%-- TT End 06068 --%>

                    <%-- --%>
                    <%-- <TR>
															<TD class="bodytxt" bgColor="#ffffff">Course Document - <br />NT Retail NCDEX doc</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname5" runat="server">Course Document - NT Retail NCDEX.pdf</asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg5" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton5" Visible="True" onclick="ImageButton5_Click"></asp:ImageButton>  
                                                                   </asp:label>
																</TD>
														</TR>--%>
                    <%--<tr>
                        <td colspan="3" bgcolor="#ffffff" class="toplink">
                            &nbsp;
                        </td>
                    </tr>--%>
                   <%-- <tr>
                        <td colspan="3" bgcolor="#fcf5dc" class="toplink">
                            Installer
                        </td>
                    </tr>--%>
                   <%-- <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA-CORPMANAGER <br />-VSAT&LL
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname6" runat="server">NEXTRA_6.0.5.0_VSAT.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg6" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton6"
                                    Visible="True" OnClick="ImageButton6_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA-CORPMANAGER <br />-Internet 
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname7" runat="server">NEXTRA_6.0.5.0_INTERNET.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg7" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton7"
                                    Visible="True" OnClick="ImageButton7_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>--%>
                     <%-- Removed As per TT 5104--%>
                   <%-- <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            File Uploader – VSAT/Leased Line
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname8" runat="server">nest_file_uploader_2.2.97.0_lan_Ncdex.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg8" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton8"
                                    Visible="True" OnClick="ImageButton8_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            File Uploader – Internet
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblfname9" runat="server">nest_file_uploader_2.2.97.0_INET_Ncdex.zip</asp:Label>
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <asp:Label ID="lblimg9" runat="server">
                                <asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" ID="ImageButton9"
                                    Visible="True" OnClick="ImageButton9_Click"></asp:ImageButton>
                            </asp:Label>
                        </td>
                    </tr>
                    <!--  HTML changes -->
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA Launcher - DR Mock
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA_Launcher_3.11.6.3.zip
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/NEXTRA_Launcher_3.11.6.3.zip?ver=1.0">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>--%>
                     <%-- Removed As per TT 5104--%>

                   <%-- <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Corporate Manager– VSAT/<br>
                            LeasedLine
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA_CM_6.0.2.0_VSAT_LeasedLine.zip
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/NEXTRA_CM_6.0.2.0_VSAT_LeasedLine.zip">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Corporate Manager – Internet
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA_CM_6.0.2.0 _Internet.zip
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/NEXTRA_CM_6.0.2.0 _Internet.zip">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Drop Copy – VSAT/Leased Line
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA_DC_1.2.0.0_VSAT_LeasedLine.exe.zip
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/NEXTRA_DC_1.2.0.0_VSAT_LeasedLine.exe.zip">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td class="bodytxt" bgcolor="#ffffff">
                            Drop Copy – Internet
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            NEXTRA_DC_1.2.0.0_Internet.exe.zip
                        </td>
                        <td class="bodytxt" bgcolor="#ffffff">
                            <a href="Downloads/NEXTRA_DC_1.2.0.0_Internet.exe.zip">
                                <img src="Images/download_file_icon.gif" border="0" /></a>
                        </td>
                    </tr>--%>
                </table>
                <!-- Content Ends -->
            </td>
        </tr>
    </table>
    &nbsp;
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
