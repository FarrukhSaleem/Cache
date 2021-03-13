using System;
using System.Web;

namespace Cache
{
	public partial class CacheThroughCode : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));
			Response.Cache.VaryByParams["none"] = true;
			Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
			lblServerTime.Text = "This Page is Cached by the server @" + DateTime.Now.ToString();
		}
	}
}