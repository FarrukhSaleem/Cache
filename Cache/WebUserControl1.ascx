<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Cache.WebUserControl1" %>
<%@ OutputCache Duration="30" VaryByParam="none" %>
<table style="border: 1px solid black">
	<tr>
		<td style="background-color: gray; font-size: 12pt">Product User Control

		</td>
	</tr>
	<tr>
		<td>
			<asp:GridView ID="GridView1" runat="server"></asp:GridView>
		</td>
	</tr>
	<tr>
		<td>
			<b>User Control Server Time:<asp:Label ID="lblUCServerTime" runat="server"></asp:Label>
			</b>
		</td>
	</tr>
	<tr>
		<td>
			<b>User Control Client Time :
				<script type="text/javascript">
					document.write(Date());
				</script>
			</b>
		</td>
	</tr>
</table>