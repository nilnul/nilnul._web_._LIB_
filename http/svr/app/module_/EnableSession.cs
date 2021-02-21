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
	/// You register a custom HTTP modules in your application's Web.config file. When ASP.NET creates an instance of the HttpApplication class that represents your application, instances of any modules that have been registered are created.
	/// Web Api does not use session state (not by default, at least).
	/// </summary>
	public class EnableSession
	 : IHttpModule

	{
		public void Init(HttpApplication context)
		{
			context.BeginRequest += Context_BeginRequest;


			//throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">might be the module</param>
		/// <param name="e"></param>
		private void Context_BeginRequest(object sender, EventArgs e)
		{
			HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);


		}

		public void Dispose()
		{
			//throw new NotImplementedException();
		}

	}
}
