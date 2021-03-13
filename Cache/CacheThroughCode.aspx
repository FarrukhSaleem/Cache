<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheThroughCode.aspx.cs" Inherits="Cache.CacheThroughCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			Server Time :  <asp:Label ID="lblServerTime" runat="server" ></asp:Label>
		<br />
			Client Time : <script type="text/javascript">
							  document.write(Date());
						  </script>
		</div>
	</form>
</body>
</html>
