using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;


namespace nilnul.web.svr.handler_.ascxRender_
{
	/// <summary>
	/// </summary>
	public class OnPage: IHttpHandler
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

			using (var dummyPage = new _onPage.PageNoForm())
			{

				var ctr = dummyPage.LoadControl(context.Request.Url.LocalPath);

				dummyPage.Controls.Add(ctr);


				context.Server.Execute(dummyPage, context.Response.Output, true);
			}

		}
	}
}