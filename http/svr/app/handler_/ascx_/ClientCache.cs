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
	public class ClientCache : IHttpHandler
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
			//var inRequestHeader = context?.Request?.Headers?[nilnul.web.http._request_._header_._fields_._field_.Key_.ACCEPT_LANGUAGE] ??"";
			//var cacheKey = context.Request.Url.LocalPath??"" + "//" + (inRequestHeader );


			//var r = context.Cache.Get(cacheKey);
			//if (r is null)
			//{

			///no cache is hard-coded here, as some .ascx, such those on client-side userToken shall not be cahced.
			///maybe client-side-only cache can be considered; if client-side wants fresh copy, it can append a timestamp to the url querystring
			using (var dummyPage = new _onPage.PageNoForm())
			{

				var ctr = dummyPage.LoadControl(context.Request.Url.LocalPath);

				dummyPage.Controls.Add(ctr);


				context.Server.Execute(dummyPage, context.Response.Output, true);
				
				context.Response.Cache.SetCacheability(HttpCacheability.Public);
				context.Response.Cache.SetExpires(DateTime.Now+TimeSpan.FromDays(30));
				//context.Response.Cache.SetMaxAge(TimeSpan.FromSeconds(7 * 24 * 3600));
				context.Response.Cache.SetValidUntilExpires(true);

				#region various cache settings

				//// Set the cache response expiration to 3600 seconds (use your own value here).
				//HttpContext.Current.Response.Cache.SetExpires(DateTime.UtcNow.AddSeconds(3600));

				//// Set both server and browser caching.
				//HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);

				//// Prevent browser's default max-age=0 header on first request
				//// from invalidating the server cache on each request.
				//HttpContext.Current.Response.Cache.SetValidUntilExpires(true);

				//// Set an HTTP ETag header on the page using a random GUID.
				//HttpContext.Current.Response.Cache.SetETag(System.Guid.NewGuid()
				//										   .ToString().Replace("-", ""));

				//// Set last modified time.
				//HttpContext.Current.Response.Cache.SetLastModified(DateTime.UtcNow);

				//// Now here is the critical piece that forces revalidation on each request!:
				//HttpContext.Current.Response.Cache.AppendCacheExtension(
				//	"must-revalidate, proxy-revalidate, max-age=0");
				/*Whenever you attempt to modify the caching headers emitted by .Net caching itself, .Net will always supersede what you're trying to do. The trick is to add new non-conflicting headers, not try to change what .Net is already emitting. Most importantly, you must append the max-age header. You must NOT use .SetMaxAge(), as this also sets the maximum age of the server cached copy of the page.*/
				#endregion

			}

		}
	}
}
/*you can define it per page like below

Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
Response.Cache.SetCacheability(HttpCacheability.Public);
Response.Cache.SetValidUntilExpires(true);
or you can do it in declaritive way by doing it in your aspx page like below

<%@ OutputCache Duration="60" VaryByParam="None" %>*/
