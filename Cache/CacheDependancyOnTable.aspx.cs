using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;

namespace Cache
{
	public partial class CacheDependancyOnTable : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
			SqlCacheDependencyAdmin.EnableNotifications(CS);
			SqlCacheDependencyAdmin.EnableTableForNotifications(CS,"tblProducts");
		}

		protected void btnGetData_Click(object sender, EventArgs e)
		{

			

			if (Cache["ProductData"] == null)
			{
				string CS = @"Data Source=DESKTOP-661ODQ1;Initial Catalog=ASPDOTNETDB;Integrated Security=True";
				string CS1 = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
				SqlConnection con = new SqlConnection(CS1);
				SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataSet DS = new DataSet();
				da.Fill(DS);

				//Cache.Insert("ProductData", DS, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(120), CacheItemPriority.Default, null);
				
				SqlCacheDependency sqlCacheDependency = new SqlCacheDependency("ASPDOTNETDB", "tblProducts");


				Cache.Insert("ProductData", DS, sqlCacheDependency, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(120), CacheItemPriority.Default, null);
				GridView1.DataSource = DS;
				GridView1.DataBind();
				lblMessage.Text = DS.Tables[0].Rows.Count.ToString() + " row(s) retrieve from the Database";

			}
			else
			{
				DataSet DS = new DataSet();
				DS = (DataSet)Cache["ProductData"];
				GridView1.DataSource = DS;
				GridView1.DataBind();
				lblMessage.Text = DS.Tables[0].Rows.Count.ToString() + " row(s) retrieve from the Cache";
			}
		}
	}
}