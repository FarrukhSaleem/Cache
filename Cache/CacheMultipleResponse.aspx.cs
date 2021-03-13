using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cache
{
	public partial class CacheMultipleResponse : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) {
				PopulateGrid(DropDownList1.SelectedValue);
			}
		}
		private void PopulateGrid(string productname) {
			string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
			SqlConnection con = new SqlConnection(CS);
			SqlDataAdapter da = new SqlDataAdapter("spGetProductDetails", con);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter.ParameterName = "@productName";
			sqlParameter.Value = productname;

			da.SelectCommand.Parameters.Add(sqlParameter);

			DataSet DS = new DataSet();
			da.Fill(DS);
			GridView1.DataSource = DS;
			GridView1.DataBind();
			lblServerTime.Text = DateTime.Now.ToString();
		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateGrid(DropDownList1.SelectedValue);
		}
	}
}