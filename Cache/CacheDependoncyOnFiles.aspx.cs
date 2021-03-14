using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cache
{
	public partial class CacheDependoncyOnFiles : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnGetData_Click(object sender, EventArgs e)
		{
			GridView1.DataSource = GetData();
			GridView1.DataBind();
		}
		private DataSet GetData()
		{
			DataSet DS = new DataSet();
			if (Cache["Countries"] == null)
			{				
				DS.ReadXml(Server.MapPath("~/Data/Countries.xml"));
				//Cache.Insert("Countries", DS, null, DateTime.Now.AddSeconds(20), System.Web.Caching.Cache.NoSlidingExpiration);

				Cache.Insert("Countries", DS, new System.Web.Caching.CacheDependency(Server.MapPath("~/Data/Countries.xml")) , DateTime.Now.AddSeconds(20), System.Web.Caching.Cache.NoSlidingExpiration);

				lblMessage.Text = DS.Tables[0].Rows.Count.ToString() + " row(s) retrieve from XML File.";
			}
			else {
				DS = (DataSet)Cache["Countries"];
				lblMessage.Text = DS.Tables[0].Rows.Count.ToString() + " row(s) retrieve from Cache";
			}			
			return DS;
		}
	}
}