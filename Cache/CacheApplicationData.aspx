<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheApplicationData.aspx.cs" Inherits="Cache.CacheApplicationData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<table style="border: 1px solid black">
				<tr>
					<td>
						<asp:Button ID="btnLoadData" runat="server" Text="Load Data" OnClick="btnLoadData_Click" />
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Remove Cache" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" EnableViewState="False">
							<FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
							<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
							<PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
							<RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
							<SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
							<SortedAscendingCellStyle BackColor="#FFF1D4" />
							<SortedAscendingHeaderStyle BackColor="#B95C30" />
							<SortedDescendingCellStyle BackColor="#F1E5CE" />
							<SortedDescendingHeaderStyle BackColor="#93451F" />
						</asp:GridView>
					</td>
				</tr>
				<tr>
					<td>
						<b><asp:Label ID="lblMessage" runat="server"></asp:Label>
						</b>
					</td>
				</tr>
				
			</table>
		</div>
	</form>
</body>
</html>
