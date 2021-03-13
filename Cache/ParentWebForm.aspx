<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParentWebForm.aspx.cs" Inherits="Cache.ParentWebForm" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div style="font-family:Arial">
			<table style="border: 1px solid black">
				<tr>
					<td>
						<b>
							Page Server Time : <asp:Label ID="lblPageServerTime" runat="server" ></asp:Label>
						</b>
					</td>
				</tr>
				<tr>
					<td>
						Page Client Time : <script type ="text/javascript">
											   document.write(Date());

						                   </script>
					</td>
				</tr>
				<tr>
					<uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
				</tr>
			</table>
		</div>
	</form>
</body>
</html>
