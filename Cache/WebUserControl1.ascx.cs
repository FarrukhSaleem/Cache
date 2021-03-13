using System;
using System.Data;
using System.Data.SqlClient;

namespace Cache
{
	public partial class WebUserControl1 : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			lblUCServerTime.Text = DateTime.Now.ToString();
			string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
			SqlConnection con = new SqlConnection(CS);
			SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			DataSet DS = new DataSet();
			da.Fill(DS);
			GridView1.DataSource = DS;
			GridView1.DataBind();
		}
	}
}