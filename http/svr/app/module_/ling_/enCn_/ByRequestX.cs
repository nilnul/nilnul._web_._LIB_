using System;
using System.Web;
using System.Web.SessionState;

namespace nilnul.web.svr.module_.ling_.enCn_
{
	/// <summary>
	/// </summary>
	static public class ByRequestX
	{


		public const string USER_PREFER_CHINESE_KEY = enCn_.ByRequest.USER_PREFER_CHINESE_KEY;



		static public bool UserPreferChinese(HttpContext context)
		{
			try
			{
				return (bool)(context?.Items?[USER_PREFER_CHINESE_KEY] ?? false);

			}
			catch (Exception)
			{

				return false;
			}


		}
		static public bool UserPreferChinese()
		{
			if (HttpContext.Current == null)
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

		public static string GetEnCn(
			string english
		)
		{
			return english;
		}
		public static string GetEnCn(
		)
		{
			return nilnul.Txt_.Empty;
		}



		public static string GetCnEn(
				string chinese
			,

				string english
			)
		{
			return UserPreferChinese() ? chinese : english;
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
			return nilnul.Txt_.Empty;
		}
	}
}