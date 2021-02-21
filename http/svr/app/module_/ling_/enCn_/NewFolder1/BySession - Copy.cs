using System;
using System.Diagnostics;
using System.Web;
using System.Web.SessionState;

namespace nilnul.web.svr.module_.ling_.enCn_
{
	/// <summary>
	/// make session_start to execute, and get lingInfo from client cred/token
	/// 
	/// </summary>
	/// <remarks>
	///manage the languages in the session.
	/// in session_start set the session.
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.web.http.svr.app.module_.ling_.enCn_.BySession))]
	public class BySession : IHttpModule
	{


		public const string USER_PREFER_CHINESE_KEY = "userPreferChinese";
		/// <summary>
		/// You will need to configure this module in the Web.config file of your
		/// web and register it with IIS before being able to use it. For more information
		/// see the following link: http://go.microsoft.com/?linkid=8101007
		/// </summary>
		#region IHttpModule Members

		public void Dispose()
		{
			//clean-up code here.
		}

		public void Init(HttpApplication app)
		{
			// Below is an example of how you can handle LogRequest event and provide 
			// custom logging implementation for it

			//context.PreRequestHandlerExecute += context_PreRequestHandlerExecute;
			//context.LogRequest += new EventHandler(OnLogRequest);

			IHttpModule module = app.Modules["Session"];
			///Clarification: "Session" is the name given to the SessionStateModule			when it is registered in the root web.config.
			/// This works by relying on the fact that there's a module in the application's HttpModuleCollection called Session - a fairly safe bet unless you're really messing with the httpModules definition in the .NET Framework's web.config file. Note, however, it could break if a new version of the framework comes along and names the module differently, but it hasn't changed in any of the framework versions that have been released to date.
			if (module.GetType() == typeof(SessionStateModule))
			{
				SessionStateModule stateModule = (SessionStateModule)module;
				stateModule.Start += (Session_Start);
			}
		}

		private void Session_Start(object sender, EventArgs e)
		{
			///sender is sessionStateModule

			///var context = sender as HttpApplication;
			var context = HttpContext.Current;
			if (context is null)
			{
				Trace.TraceError( $"context is null");
				return;
			}
			if (context.Session is null)
			{
				Trace.TraceError( $"context.Session is null");
				return;
			}

			if (context.Request is null)
			{
				Trace.TraceError( $"context.Request is null");
				return;
			}


			context.Session[USER_PREFER_CHINESE_KEY] =_ling.PerRequest.PreferCnToEn(context.Request);	//However, it can process only one request at a time. Thus, member variables can be used to store per-request data.   http://msdn.microsoft.com/en-us/library/vstudio/system.web.httpapplication(v=vs.100).aspx

			return;
		}

		#endregion

		//public void OnLogRequest(Object source, EventArgs e)
		//{
		//	//custom logging logic can go here
		//}
	}
}
