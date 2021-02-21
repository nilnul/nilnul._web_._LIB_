using System;
using System.Web;
using System.Web.SessionState;

namespace nilnul.web.svr.module_.ling_.enCn_
{
	/// <summary>
	/// manage the languages in the session.
	/// in session_start set the session.
	/// </summary>
	public class ByRequest : IHttpModule
	{

		public const string USER_PREFER_CHINESE_KEY = "userPreferChinese";
		/// <summary>
		/// You will need to configure this module in the Web.config file of your
		/// web and register it with IIS before being able to use it. For more information
		/// see the following link: http://go.microsoft.com/?linkid=8101007
		/// </summary>
		public void Init(HttpApplication context)
		{
			// Below is an example of how you can handle LogRequest event and provide 
			// custom logging implementation for it
			//context.LogRequest += new EventHandler(OnLogRequest);

			context.PreRequestHandlerExecute += context_PreRequestHandlerExecute;

		}

		private void context_PreRequestHandlerExecute(object sender, EventArgs e)
		{
			var app = sender as HttpApplication;

			app.Context.Items[USER_PREFER_CHINESE_KEY] = _ling.PerRequest.PreferCnToEn(app.Request);

		}

		static public bool UserPreferChinese(HttpContext context)
		{
			try
			{
				return (bool)(context.Items[USER_PREFER_CHINESE_KEY] ?? false);

			}
			catch (Exception)
			{

				return false;
			}


		}
		static public bool UserPreferChinese()
		{
			if (HttpContext.Current==null)
			{
				return false;
			}

			return UserPreferChinese(HttpContext.Current);

		}


		public static string GetEnCn(
			string english,
			string chinese
		)
		{
			return UserPreferChinese() ? chinese : english;



		}


		public void Dispose()
		{
			//clean-up code here.
		}



	}
}