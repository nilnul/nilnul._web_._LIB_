using System.Linq;
using System.Web;
using nilnul;

namespace nilnul.web.Properties.settings._url.origin
{
	public class _AppX
	{
		public const string DENOTE = "app_";

		public static string Sprig => $"/{DENOTE}";
		public static string Stem => $"{Sprig}/";

	}
	/// <summary>
	/// origin, such as http://nilnul.com, with a denote for an app, such as "nilnul.web", together makes http://nilnul.com/app_/nilnul.web
	/// </summary>
	/// <remarks>
	/// alias: 
	///		denoted
	/// </remarks>
	public class WebApp
	{
		private string _denote;

		public string denote
		{
			get => _denote;
			set => _denote = value;
		}

		private Origin.App _origin;

		public Origin.App origin
		{
			get => _origin;
			set => _origin = value;
		}


		public WebApp(Origin.App url, string denote)
		{
			_origin = url;
			_denote = denote;
		}
		public WebApp(string scheme, string authority, string denote) : this(new Origin.App(scheme, authority), denote)
		{

		}

		public WebApp(string denote) : this(new Origin.App(), denote)
		{

		}


		public string spear => $"{ _origin.appShield}{_denote}";

		public string sprig => $"{_AppX.Stem}{_denote}";
		public string stem => nilnul.web._url._resource._render.route_._StemX.OvSprig(sprig);

		public string dir => $"{ denote}/";

		public string shield => $"{ spear}/";

		public string schemelessSpear => $"{ _origin.schemelessAppShield}{_denote}";

		public string schemelessShield => schemelessSpear + "/";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="resourceInApp"></param>
		/// <returns></returns>
		public string url(string resourceInApp)
		{
			//note: HttpContext.Current may be null, in , say design mode;
			if (HttpContext.Current?.Request?.Url == null)
			{
				return $"{shield}{resourceInApp}";

			}

			Url3 url = nilnul.web.url._ParseX3.Parse(HttpContext.Current.Request.Url.ToString());

			System.Collections.Generic.IEnumerable<nilnul.fs._address._dst.Denote> app = url.resource.render.route.division.denotes;
			if (
				HttpContext.Current.IsDebuggingEnabled //|| Debugger.IsAttached
			)
			{

				if (app.Count() >= 2)
				{
					if (app.First() == Origin.App.DENOTE)
					{
						var prjName = app.ElementAt(1);
						if (prjName == denote
							||
							nilnul.dev.prj.name.re_.equiv_.SameSln.Singleton.re(prjName, denote)
						//app.ElementAt(2).ToString().StartsWith(denote)	//nilnul._prj_.WEB._DEMO_ for nilnu._prj1_._WEB_ 
						///todo here we need to compare the initial letters before firstCaplitalLetter
						// or split at "." and get the initial lowercase ones
						)
						{
							return $"{HttpContext.Current.Request.Url.Scheme}://{HttpContext.Current.Request.Url.Authority}{stem}{resourceInApp}";
						}
					}
				}
			}

			return $"{shield}{resourceInApp}";
		}

		/// <summary>
		/// for use in rendering .ascx in the same solution
		/// </summary>
		/// <param name="resourceInApp"></param>
		/// <returns></returns>
		public string preRt
		{
			get
			{

				//note: HttpContext.Current may be null, in , say design mode;
				if (HttpContext.Current?.Request?.Url == null)
				{
					return $"";

				}

				Url3 url = nilnul.web.url._ParseX3.Parse(HttpContext.Current.Request.Url.ToString());

				System.Collections.Generic.IEnumerable<fs._address._dst.Denote> app = url.resource.render.route.division.denotes;
				if (
					HttpContext.Current.IsDebuggingEnabled //|| Debugger.IsAttached
				)
				{

					if (app.Count() >= 2)
					{
						if (app.First() == Origin.App.DENOTE)
						{
							var prjName = app.ElementAt(1);
							if (prjName == denote
								||
								nilnul.dev.prj.name.re_.equiv_.SameSln.Singleton.re(prjName, denote)
							//app.ElementAt(2).ToString().StartsWith(denote)	//nilnul._prj_.WEB._DEMO_ for nilnu._prj1_._WEB_ 
							///todo here we need to compare the initial letters before firstCaplitalLetter
							// or split at "." and get the initial lowercase ones
							)
							{
								return $"";
							}
						}
					}
				}

				return $"{origin.schemelessOrigin}";
			}

		}

	}
}
