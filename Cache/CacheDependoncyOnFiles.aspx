<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheDependoncyOnFiles.aspx.cs" Inherits="Cache.CacheDependoncyOnFiles" %>

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
			<asp:Button ID="btnGetData" runat="server" Text="Get Data" OnClick="btnGetData_Click" />
		</td>
	</tr>
	<tr>
		<td style="background-color: gray; font-size: 12pt">Product User Control

		</td>
	</tr>
	<tr>
		<td>
			<asp:GridView ID="GridView1" runat="server" EnableViewState="False"></asp:GridView>
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
