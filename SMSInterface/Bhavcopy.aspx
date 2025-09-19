<%@ Page Title="" Language="C#" MasterPageFile="~/NCDEXcommon.master" AutoEventWireup="true" CodeFile="Bhavcopy.aspx.cs" Inherits="Bhavcopy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">NCDEX Bhavcopy
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	<table id="Table3" cellSpacing="0" cellPadding="0" width="96%" align="center" border="0">
											<tr>
												<td class="mtitle" align="left"><br>
													<span class="mtitle">Bhavcopy</span><br>
													<hr>
													<br>
												</td>
											</tr>
											<tr>
												<td bgColor="#ffcc66">
													<TABLE id="Table1" cellSpacing="2" cellPadding="4" width="100%" border="0" class="tblcls">
														<TR>
															<TD class="toplink" bgColor="#fcf5dc">File Description</TD>
															<TD class="toplink" bgColor="#fcf5dc">File Name</TD>
															<TD class="toplink" bgColor="#fcf5dc">Download</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BhavCopy File</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname1" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg1" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton1" Visible="false" onclick="ImageButton1_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">Option Price Band File</TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblfname6" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff"><asp:label id="lblimg6" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton6" Visible="false" onclick="ImageButton6_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>
														<%--<TR>
															<TD class="bodytxt" bgColor="#ffffff">Market Statistics Report</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblfname2" runat="server"></asp:label>&nbsp;
															</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:Label id="lblimg2" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    id="ImageButton2" Visible="False" onclick="ImageButton2_Click"></asp:ImageButton>
                                                                    </asp:Label>
																</TD>
														</TR>--%>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BhavCopy File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblfname3" runat="server"></asp:label></TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblimg3" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton3" Visible="False" onclick="ImageButton3_Click"></asp:ImageButton>
																</asp:label>
															</TD>
														</TR>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">BhavCopy File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblfname4" runat="server"></asp:label>
															</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblimg4" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton4" Visible="False" onclick="ImageButton4_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>


                                                        <%--<TR style="display:none">--%> <%--To hide row CR07114--%>
														<TR>
															<TD class="bodytxt" bgColor="#ffffff">Provisional BhavCopy File</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblfname5" runat="server"></asp:label>
															</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblimg5" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton5" Visible="False" onclick="ImageButton5_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>
                                                        <TR>
															<TD class="bodytxt" bgColor="#ffffff">Bhavcopy File (UDIFF)</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblfnamenew" runat="server"></asp:label>
															</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="lblimgnew" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButtonnew" Visible="False" onclick="ImageButtonnew_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>
                                                          <TR>
															<TD class="bodytxt" bgColor="#ffffff">Provisional Bhavcopy File (UDIFF)</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="Label1" runat="server"></asp:label>
															</TD>
															<TD class="bodytxt" bgColor="#ffffff">
																<asp:label id="Label2" runat="server">
																	<asp:ImageButton runat="server" ImageUrl="Images/download_file_icon.gif" 
                                                                    ID="ImageButton2" Visible="False" onclick="ImageButtonnewp_Click"></asp:ImageButton>
                                                                    </asp:label>
																</TD>
														</TR>
													</TABLE>
												</td>
											</tr>
										</table>
										&nbsp;
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>
										<br>
</asp:Content>

