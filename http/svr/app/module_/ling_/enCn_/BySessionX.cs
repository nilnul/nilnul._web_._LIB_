using System;
using System.Web;
using System.Web.SessionState;

namespace nilnul.web.http.svr.app.module_.ling_.enCn_
{
	/// <summary>
	/// </summary>
	static public class BySessionX
	{
		public const string USER_PREFER_CHINESE_KEY = nilnul.web.http.svr.app.module_.ling_.enCn_.BySession.USER_PREFER_CHINESE_KEY;

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

		public static string GetEnCn()
		{
			return "";
		}

		public static string GetEnCn(string x)
		{
			return x;
		}

		

		public static string GetEnCn(
			string english,
			string chinese
		)
		{
			return UserPreferChinese() ? chinese : english;
		}

		public static string GetCnEn(
			string chinese
		,

			string english
		)
		{
			return GetEnCn(english, chinese);
		}
		public static string GetCnEn(
				string chinese
			)
		{
			return chinese;
		}
		public static string GetCnEn(

			)
		{
			return "";
		}



	}
}
