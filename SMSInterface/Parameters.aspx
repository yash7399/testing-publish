<%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true" CodeFile="Parameters.aspx.cs" Inherits="Parameters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">NCDEX Parameters</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="96%" border="0" cellspacing="0" cellpadding="0" ID="Table3" align="center">
											<tr>
												<td class="mtitle" align="left">
													<br>
													<span class="mtitle">Parameters</span><br>
													<hr>
													<br>
												</td>
											</tr>
											<tr>
												<td bgcolor="#ffcc66">
													<TABLE id="Table1" cellSpacing="1" cellPadding="4" width="100%" border="0" class="tblcls">
														<TR>
															<TD class="toplink" bgColor="#fcf5dc">File Description</TD>
															<TD class="toplink" bgColor="#fcf5dc">File Name</TD>
															<TD class="toplink" bgColor="#fcf5dc">Download</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Daily Margin File 01</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblPfname1" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg1" runat="server">
																	<asp:ImageButton id="ImageButton1" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton1_Click"></asp:ImageButton></asp:Label>
																
															</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Daily Margin File 02</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname2" runat="server"></asp:label><a href="#"></a></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg2" runat="server">
																	<asp:ImageButton id="ImageButton2" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton2_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Daily Margin File 03</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname3" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg3" runat="server">
																	<asp:ImageButton id="ImageButton3" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton3_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
															   <asp:label id="lblPfname12" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															   <asp:Label id="lblimg12" runat="server">
																	<asp:ImageButton id="ImageButton12" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton12_Click" > 
                                                                    </asp:ImageButton></asp:Label></TD>
														</TR>
                                                      <%--  <TR>
															<TD class="bodytxt" bgColor="#ffffff">&nbsp;</TD>
															<TD class="bodytxt" bgColor="#ffffff">
															    <asp:label id="lblPfname13" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
                                                             <asp:Label id="lblimg13" runat="server">
															    <asp:ImageButton id="ImageButton13" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton13_Click"></asp:ImageButton>
                                                                    </asp:Label>
                                                                    </TD>
														</TR>--%>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname4" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg4" runat="server">
																	<asp:ImageButton id="ImageButton4" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton4_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname5" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg5" runat="server">
																	<asp:ImageButton id="ImageButton5" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton5_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname6" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg6" runat="server">
																	<asp:ImageButton id="ImageButton6" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton6_Click" style="height: 16px"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname7" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg7" runat="server">
																	<asp:ImageButton id="ImageButton7" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton7_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname8" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg8" runat="server">
																	<asp:ImageButton id="ImageButton8" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton8_Click"></asp:ImageButton></asp:Label>
																</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname9" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:Label id="lblimg9" runat="server">
																	<asp:ImageButton id="ImageButton9" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton9_Click"></asp:ImageButton></asp:Label>
															</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname10" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblimg10" runat="server">
																	<asp:ImageButton id="ImageButton10" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton10_Click"></asp:ImageButton></asp:Label>
															</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname13" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblimg13" runat="server">
																	<asp:ImageButton id="ImageButton13" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton13_Click"></asp:ImageButton></asp:Label>
															</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">BMS File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblPfname14" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblimg14" runat="server">
																	<asp:ImageButton id="ImageButton14" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton14_Click"></asp:ImageButton></asp:Label>
															</TD>
														</TR>
                                                        
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Indicative Margin <br />Percentages</TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:label id="lblPfname11" runat="server"></asp:label>
																&nbsp;</TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblimg11" runat="server">
																	<asp:ImageButton id="ImageButton11" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton11_Click"></asp:ImageButton></asp:Label>
															</TD>
														</TR>
                                                        <tr>
                                                            <TD class="bodytxt" bgColor="#ffffff" colspan="3"><a href= "Archives.aspx">Archival BMS Files</a></TD>
                                                        </tr>
													</TABLE>
												</td>
											</tr>
										</table>
										<br>
										<br>
										<br>
										<br>
										<br>
</asp:Content>

