using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cache
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
			SqlConnection con = new SqlConnection(CS);
			SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			DataSet DS = new DataSet();
			da.Fill(DS);
			GridView1.DataSource = DS;
			GridView1.DataBind();
			Label1.Text = DateTime.Now.ToString();
		}
	}
}