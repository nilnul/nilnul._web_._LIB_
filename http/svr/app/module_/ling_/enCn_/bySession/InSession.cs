using System;
using System.Web;
using System.Web.SessionState;

namespace nilnul._web_._CTR_.lang.module
{
	/// <summary>
	/// manage the languages in the session.
	/// in session_start set the session.
	/// </summary>
	/// 
	[Obsolete()]
	public class InSession 
	{
		public const string USER_PREFER_CHINESE_KEY = nilnul.web.svr.module_.ling_.enCn_.BySession.USER_PREFER_CHINESE_KEY;

		static public bool UserPreferChinese(HttpSessionState session)
		{
			try
			{
				if (session[USER_PREFER_CHINESE_KEY] == null)
				{
					return false;
				}
				if ((
					session[USER_PREFER_CHINESE_KEY]
				).GetType() == typeof(bool))
				{
					return (bool)session[USER_PREFER_CHINESE_KEY];
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		static public bool UserPreferChinese(HttpContext context)
		{
			if (context==null)
			{
				return false;
			}
			if (context.Session==null)
			{
				return false;
			}
			return UserPreferChinese(context.Session);
		}

		static public bool UserPreferChinese()
		{
			if (HttpContext.Current == null)
			{
				return false;
			}

			return UserPreferChinese(HttpContext.Current);

		}

		public static string GetString_inUserPreferredLang()
		{
			return "";
		}

		public static string GetString_inUserPreferredLang(string x)
		{
			return x;
		}

		public static string GetString_inUserPreferredLang(
			string english,
			string chinese
		)
		{
			return UserPreferChinese() ? chinese : english;
		}

		public static string GetEnCn(
			string english,
			string chinese
		)
		{
			return UserPreferChinese() ? chinese : english;
		}

		
		
	}
}
