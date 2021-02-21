using nilnul.web.svr.handler_.ascxRender_._onPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;


namespace nilnul.web.http.svr.app.handler_.ascx_
{
	/// <summary>
	/// </summary>
	public class AsJs : IHttpHandler
	{
		public bool IsReusable
		{
			get
			{
				return true;

			}
		}

		public void ProcessRequest(HttpContext context)
		{

			using (var dummyPage = new PageNoForm())
			{


				var ctr = dummyPage.LoadControl(context.Request.Url.LocalPath);

				dummyPage.Controls.Add(ctr);




				context.Server.Execute(dummyPage, context.Response.Output, true);
				context.Response.ContentType = nilnul.web.mime_.application_.Js_.Js;
				context.Response.Cache.SetCacheability(HttpCacheability.Public);
				context.Response.Cache.SetMaxAge(TimeSpan.FromSeconds(7 * 24 * 3600));
			}

		}
	}
}