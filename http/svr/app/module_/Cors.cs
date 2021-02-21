using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace nilnul.web.http.svr.app.module_
{
	/// <summary>
	/// </summary>
	public class Cors
	 : IHttpModule

	{
		public void Init(HttpApplication context)
		{
			context.BeginRequest += Context_BeginRequest;


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">might be the module</param>
		/// <param name="e"></param>
		private void Context_BeginRequest(object sender, EventArgs e)
		{

			var res = HttpContext.Current.Response;
			var req = HttpContext.Current.Request;
			var t = req.Headers["Origin"];
			if (t != null)
			{
				res.AppendHeader("Access-Control-Allow-Origin", t);
			}
			else
			{
				res.AppendHeader("Access-Control-Allow-Origin", req.Url.Authority);

			}
			res.AppendHeader("Access-Control-Allow-Credentials", "true");

			res.AppendHeader("Access-Control-Allow-Headers", "Content-Type, X-CSRF-Token, X-Requested-With, Accept, Accept-Version, Content-Length, Content-MD5, Date, X-Api-Version, X-File-Name, cache-control,Authorization");

			res.AppendHeader("Access-Control-Allow-Methods", "POST,GET,PUT,PATCH,DELETE,OPTIONS");
			HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000"); /*Access-Control-Max-Age，它表明了这个询问结果的有效期，后面浏览器在有效期内也可以不必再次询问”*/


			// ==== Respond to the OPTIONS verb =====
			if (req.HttpMethod == "OPTIONS")
			{
				res.StatusCode = 200;
				res.End();
			}

		}

		public void Dispose()
		{
			//throw new NotImplementedException();
		}

	}
}
