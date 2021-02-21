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
			///no cache is hard-coded here, as some .ascx, such those on client-side userToken shall not be cahced.
			///maybe client-side-only cache can be considered; if client-side wants fresh copy, it can append a timestamp to the url querystring
			using (var dummyPage = new _onPage.PageNoForm())
			{

				var ctr = dummyPage.LoadControl(context.Request.Url.LocalPath);

				dummyPage.Controls.Add(ctr);
				

				context.Server.Execute(dummyPage, context.Response.Output, true);
			}

		}
	}
}