<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Include_Menu" %>
<table borderColor="#990000" cellSpacing="0" cellPadding="1" width="243" border="0">
    <tr>
        <td>
            <div id="sidebar">
            <ul>
        		<li>
		    		<A href="Bhavcopy.aspx">Bhavcopy</A>
		    	</li>
				<li>
					<A href="Reports.aspx">Reports</A>
				</li>	
				<li>
					<A href="Parameters.aspx">Parameters</A>
				</li>	
				<li>
					<A href="Docs.aspx">NCDEX Docs</A>
				</li>
                <li>
                    <A href="Nextra.aspx">Nextra</A>
                </li>
               <%-- <li>
                    
                    <A href="TradeX.aspx">TradeXInstaller</A>
                </li> --%>
                 <%--<li>
                    <A href="Downloads/TradeX_Help_Ver_1.0.0.pdf" target="_blank">TradeX Help Doc </A>
                </li>--%>
			</ul>
			        <asp:button id="Button1" Text="Logout" runat="server" CssClass="button" Height="23" Width="55" onclick="Button1_Click"></asp:button>
			</div>
        </td>
    </tr>
</table>