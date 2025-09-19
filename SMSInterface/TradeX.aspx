<%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true" CodeFile="TradeX.aspx.cs" Inherits="TradeX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="Table3" cellSpacing="0" cellPadding="0" width="96%" align="center" border="0">
											<tr>
												<td class="mtitle" align="left"><br>
													<span class="mtitle">TradeX</span><br>
													<hr>
													<br>
												</td>
											</tr>
											<tr>
												<td bgColor="#ffcc66">
                                                <!-- Content Starts -->
                                                    <TABLE id="Table1" cellSpacing="1" cellPadding="4" width="100%" border="0" class="tblcls">
														<TR>
															<TD class="toplink" bgColor="#fcf5dc">File Description</TD>
															<TD class="toplink" bgColor="#fcf5dc">File Name</TD>
															<TD class="toplink" bgColor="#fcf5dc">Download</TD>
														</TR>
                                                       <!-- <tr>
                                                            <TD colspan="3" bgColor="#fcf5dc" class="toplink">Help Documents</TD>
                                                        </tr>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Quick Guide</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname1" runat="server">NEXTRA_QuickGuide.pdf</asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg1" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton1" Visible="True" onclick="ImageButton1_Click"></asp:ImageButton>  
                                                                    </asp:label>
																</TD>
														</TR> -->
                                                       <%-- <tr>
                                                            <TD colspan="3" bgColor="#fcf5dc" class="toplink">Installer</TD>
                                                        </tr>--%>
                                                         <%-- Removed As per TT 5104--%>
                                                      <%-- <TR>
															<TD class="bodytxt" bgColor="#ffffff">TradeX-4.0.5 Build02</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname2" runat="server">Tradex_4.0.5.zip</asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg2" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton2" Visible="True" onclick="ImageButton2_Click1"></asp:ImageButton>  
                                                                   </asp:label> 
																</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">TradeX-4.0.5 Build03</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname3" runat="server">Tradex_4.0.5_build03.zip</asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg3" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton3" Visible="True" onclick="ImageButton3_Click"></asp:ImageButton>  
                                                                    </asp:label>
																</TD>
														</TR>--%>  <%-- Removed As per TT 5104--%>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS_Test_File</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lbltst1" runat="server">BMS_RA00_24052017.xml</asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
                                                                    <asp:label id="lbltst2" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButtonTst" Visible="True" onclick="ImageButtonTst_Click"></asp:ImageButton>  
                                                                    </asp:label>
																</TD>
														</TR>  
                                                       

                                                   
                                                        
                                                        
                                                    </TABLE>

                                                <!-- Content Ends -->
                                                </td>
											</tr>
										</table>
</asp:Content>

