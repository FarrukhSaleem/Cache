using System;
using System.Data;
using System.Data.SqlClient;

namespace Cache
{
	public partial class CacheApplicationData : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLoadData_Click(object sender, EventArgs e)
		{
			System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

			DateTime dtStartTime = DateTime.Now;
			if (Cache["ProductData"] == null)
			{
				DataSet DS = GetProductFromDB();
				GridView1.DataSource = DS;
				GridView1.DataBind();
				
				Cache["ProductData"] = DS;

				stringBuilder.Append(DS.Tables[0].Rows.Count.ToString() + " rows retrieved from Database. ");
			}
			else {
				DataSet DS = (DataSet)Cache["ProductData"];
				GridView1.DataSource = DS;
				GridView1.DataBind();

				stringBuilder.Append(DS.Tables[0].Rows.Count.ToString() + " rows retrieved from Cache. ");
			}
			DateTime dtEndTime = DateTime.Now;

			double Totaltime = (dtEndTime - dtStartTime).TotalSeconds;

			stringBuilder.Append("Total time taken is : " + Totaltime.ToString());
			lblMessage.Text = stringBuilder.ToString();
		}
		private DataSet GetProductFromDB() {
			string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
			SqlConnection con = new SqlConnection(CS);
			SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			DataSet DS = new DataSet();
			da.Fill(DS);
			return DS;
		}
	}
}