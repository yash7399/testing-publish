<%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">NCDEX Reports
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="96%" border="0" cellspacing="0" cellpadding="0" ID="Table3" align="center">
											<tr>
												<td class="mtitle" align="left">
													<br>
													<span class="mtitle">Reports</span><br>
													<hr>
													<br>
												</td>
											</tr>
											<tr>
												<td bgcolor="#ffcc66">
													<TABLE id="Table1" cellSpacing="1" cellPadding="4" width="100%" border="0" class="tblcls">
														<TR>
															<TD class="toplink" bgColor="#fcf5dc">File Description</TD>
															<TD class="toplink" bgColor="#fcf5dc">&nbsp;File Name</TD>
															<TD class="toplink" bgColor="#fcf5dc">Download</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">
																Contract File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:Label id="lblfname" runat="server"></asp:Label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:Label id="lblReport" runat="server">
																<asp:ImageButton id="ImageButton1" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton1_Click"></asp:ImageButton>
                                                                    </asp:Label>
																</TD>
														</TR>
														<%--<TR>
															<TD class="bodytxt" bgColor="#ffffff">
																Data File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:Label id="lblfname1" runat="server"></asp:Label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblData" runat="server">
																<asp:ImageButton id="ImageButton2" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" onclick="ImageButton2_Click"></asp:ImageButton>
                                                                    </asp:Label>
																</TD>
														</TR>--%>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">
																GCOR File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:Label id="lblfname2" runat="server"></asp:Label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
															<asp:Label id="lblGCOR" runat="server">
																<asp:ImageButton id="ImageButton3" runat="server" 
                                                                    ImageUrl="Images/download_file_icon.gif" Visible="False" 
                                                                    onclick="ImageButton3_Click"></asp:ImageButton>
                                                                   </asp:Label>
															    </TD>
														</TR>
													</TABLE>
												</td>
											</tr>
										</table>
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>

</asp:Content>

