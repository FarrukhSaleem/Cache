using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;
using System.Text;

namespace Cache
{
	public partial class CacheApplicationData : System.Web.UI.Page
	{
		StringBuilder stringBuilder = new StringBuilder();

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnLoadData_Click(object sender, EventArgs e)
		{
			

			DateTime dtStartTime = DateTime.Now;
			if (Cache["ProductData"] == null)
			{
				DataSet DS = GetProductFromDB();
				GridView1.DataSource = DS;
				GridView1.DataBind();

				//Cache["ProductData"] = DS;
				Cache.Add("ProductData", DS, null, System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, null);

				//Cache.Add("ProductData", DS, null, DateTime.Now.AddSeconds(10), System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, null);

				//Cache.Add("ProductData", DS, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(10), CacheItemPriority.Default, null);

				//Cache.Insert("ProductData", DS);

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

		protected void Button1_Click(object sender, EventArgs e)
		{
			Cache.Remove("ProductData");
			lblMessage.Text = "Cache data has been removed";
		}
	}
}