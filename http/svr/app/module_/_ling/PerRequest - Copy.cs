using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace nilnul.web.svr.module_._ling
{
	[Obsolete(nameof(nilnul.web.http.svr.app.module_._ling.PerRequest))]
	public class PerRequest
	{


		public static string GetString_inUserPreferredLang()
		{
			return "";
		}

		public static string GetString_inUserPreferredLang(string x)
		{
			return x;
		}

		public static string GetEnZh(
			string english,
			string chinese
		)
		{

			
			return PreferCnToEn() ? chinese : english;

		}

		public static string GetEnZh(
			string english
		)
		{

			
			return  english;

		}



		public static string GetZhEn(
				string chinese,
		string english
		)
		{
			return PreferCnToEn() ? chinese : english;

		}


		#region Prefer

		static public Dictionary<string, double> Prefer(HttpRequest request)
		{

			var r = new Dictionary<string, double>();

			foreach (var item in Prefer_perBrowser(request))
			{

				r.Add(item.Key, item.Value);

			}

			foreach (var item in Prefer_perCookie(request))
			{
				if (r.ContainsKey(item.Key))
				{
					r[item.Key] = Math.Max(
						r[item.Key],
						item.Value * 10
					);

				}
				else
				{
					r.Add(item.Key, item.Value * 10);
				}

			}

			foreach (var item in Prefer_perQueryStr(request))
			{
				var newQ = item.Value * 100;

				if (r.ContainsKey(item.Key))
				{
					if (newQ > r[item.Key])
					{
						r[item.Key] = newQ;
					}

				}
				else
				{
					r.Add(item.Key, newQ);
				}

			}


			return r;
			throw new NotImplementedException();

		}


		static public Dictionary<string, double> Prefer_perBrowser(HttpRequest request)
		{

			var r = new Dictionary<string, double>();

			if (request.UserLanguages == null)
			{
				return r;
			}

			for (int i = 0; i < request.UserLanguages.Length; i++)
			{

				var langPrefer = request.UserLanguages[i].Split(';');
				if (langPrefer.Length == 1)
				{
					SetMin(r,langPrefer[0].ToLower(), 1);

				}
				else if (langPrefer.Length == 2)
				{

					double qValParsed;

					var qKeyVal = langPrefer[1].Split('=');

					if (qKeyVal.Length == 1)
					{
						if (qKeyVal[0].Trim().ToLower() == "q")
						{
							SetMin(r,langPrefer[0], 1);        //the bigger, the prefer.

						}

					}
					else if (qKeyVal.Length == 2)
					{

						if (qKeyVal[0].Trim().ToLower() == "q")
						{
							var parseSuccess = double.TryParse(qKeyVal[1], out qValParsed);
							if (parseSuccess)
							{
								SetMax(r,langPrefer[0], qValParsed);


							}

						}
					}


				}



			}

			return r;


			throw new NotImplementedException();

		}

		static public void SetMin(Dictionary<string, double> r, string key, double min) {

			if (r.ContainsKey(key))
			{
				r[key] = Math.Min(r[key], min);
			}
			else
			{
				r.Add(key, min);

			}

		}

		static public void SetMax(Dictionary<string, double> r, string key, double newVal) {

			if (r.ContainsKey(key))
			{
				r[key] = Math.Max(r[key], newVal);
			}
			else
			{
				r.Add(key, newVal);

			}

		}


		static public Dictionary<string, double> Prefer_perQueryStr(HttpRequest request)
		{

			var r = new Dictionary<string, double>();

			var queryString = request.QueryString.GetValues(nilnul.web.CfgX.RequestKeysInLowerCase.LANG);
			if (queryString == null)
			{
				return r;

			}



			for (int i = 0; i < queryString.Length; i++)
			{

				///en , zh

				var langPreferS = queryString[i].Split(',');

				for (int j = 0; j < langPreferS.Length; j++)
				{

					// en; , zh;
					var langPrefer = langPreferS[j].Split(';');

					if (langPrefer.Length == 1)
					{
						SetMin(r, langPrefer[0], 1);

						

					}



					else if (langPrefer.Length == 2)
					{

						double qValParsed;
						//en; , zh;q=3 
						var qVal = langPrefer[1].Split('=');
						if (qVal.Length == 1)

						{
							//en; q
							if (qVal[0].Trim().ToLower() == "q")
							{

								SetMin(r, langPrefer[0], 1);

							}

						}
						else if (qVal.Length == 2)
						{
							//en;q=3
							if (qVal[0].Trim().ToLower() == "q")
							{
								var parseSuccess = double.TryParse(qVal[1], out qValParsed);
								if (parseSuccess)
								{
									SetMax(r,langPrefer[0], qValParsed);


								}

							}
						}


					}

				}




			}


			return r;


			throw new NotImplementedException();

		}


		static public Dictionary<string, double> Prefer_perCookie(HttpRequest request)
		{

			var r = new Dictionary<string, double>();

			var queryString = request.Cookies[nilnul.web.CfgX.RequestKeysInLowerCase.LANG];

			if (queryString == null)
			{
				return r;

			}

			var langPreferS = queryString.Value.Split(',');

			for (int j = 0; j < langPreferS.Length; j++)
			{

				var langPrefer = langPreferS[j].Split(';');

				if (langPrefer.Length == 1)
				{
					SetMin(r,langPrefer[0], 1);

				}

				else if (langPrefer.Length == 2)
				{

					double qValParsed;

					var qVal = langPrefer[1].Split('=');
					if (qVal.Length == 1)
					{
						if (qVal[0].Trim().ToLower() == "q")
						{
							SetMin(r,langPrefer[0], 1);

						}

					}
					else if (qVal.Length == 2)
					{

						if (qVal[0].Trim().ToLower() == "q")
						{
							var parseSuccess = double.TryParse(qVal[1], out qValParsed);
							if (parseSuccess)
							{
								SetMax(r,langPrefer[0], qValParsed);


							}

						}
					}


				}

			}

			return r;
			throw new NotImplementedException();

		}

		#endregion

		#region PreferCnToEn

		static public bool PreferCnToEn()
		{


			if (HttpContext.Current?.Request==null /*Design time error avoided*/)
			{
				
				return false;
			}
		

			return PreferCnToEn(HttpContext.Current.Request);

		}
		static public bool PreferCnToEn(HttpContext context)
		{

			return PreferCnToEn(context.Request);

		}

		static public bool PreferCnToEn(HttpRequest request)
		{

#if Release_PreferChinese || HBUE40
			return true;


#endif
			if (request == null)
			{
				return false;
			}


			var dict = Prefer(request);

			var english = dict.Where(c => c.Key == ("en") || c.Key == "eng" || c.Key.StartsWith("en-")).Select(c => c.Value);

			double englishPrefer = 0;

			if (english.Any())
			{
				englishPrefer = english.Max();
			}


			var chinese = dict.Where(c => c.Key == ("chi") || c.Key == "zho" || c.Key == "cn" || c.Key == "zh" || c.Key.StartsWith("zh-")).Select(c => c.Value);
			double chinesePrefer = 0;
			if (chinese.Any())
			{
				chinesePrefer = chinese.Max();


			}

			return chinesePrefer >= englishPrefer;

		}

		#endregion

		#region Prefer2txt

		static public string Prefer2txt(HttpRequest request)
		{
			if (request==null)
			{
				return "";
			}

			return Prefer(request).Aggregate(
				"",
				(a, c) => string.Format("{0};q={1},", c.Key, c.Value)
			);


			throw new NotImplementedException();

		}
		static public string Prefer2txt(HttpContext context)
		{
			if (HttpContext.Current?.Request==null)
			{
				return "";
			}

			return Prefer2txt(context.Request);

		}
		static public string Prefer2txt()
		{
			if (HttpContext.Current==null)
			{
				return "";
			}
			return Prefer2txt(HttpContext.Current);


			throw new NotImplementedException();

		}
		#endregion



	}
}
