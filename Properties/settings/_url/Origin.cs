using System.Web;

namespace nilnul.web.Properties.settings._url
{
	public class Origin
	{
		//public const string AUTHORITY="nilnul.com";
		//public const string SCHEME = "http";

		public string authority;
		public string scheme;

		public Origin(string scheme, string authority)
		{
			this.scheme = scheme;
			this.authority = authority;
		}

		public Origin()
			: this(
				 nilnul.web.Properties.Settings.Default.scheme??((nilnul.web.Properties.Settings.Default.Properties[nameof(nilnul.web.Properties.Settings.Default.scheme)].DefaultValue) as string)
				 ,
				nilnul.web.Properties.Settings.Default.authority??((nilnul.web.Properties.Settings.Default.Properties[nameof(nilnul.web.Properties.Settings.Default.authority)].DefaultValue) as string)
			)
		{
		}

		public string schemelessOrigin => "//" + authority;

		public string schemelessOrigin0Empty
		{
			get
			{
				if (HttpContext.Current==null)
				{
					return schemelessOrigin;

				}
				if (
					HttpContext.Current.IsDebuggingEnabled
				)
				{
					return "";

				}
				else
				{
					return schemelessOrigin;
				}
			}
		}

		public string schemelessRoot => schemelessOrigin + "/";


		public string schemeColon => scheme + ":";
		public string origin => schemeColon + schemelessOrigin;

		public string root => origin + "/";


		public string appSpear => root + "app_";


		public string appShield => appSpear + "/";

		public string schemelessAppSpear => schemelessRoot + "app_";

		public string schemelessAppShield => schemelessAppSpear + "/";

		public static Origin Create4Http(string authority)
		{
			return new Origin("http", authority);
		}

		

		public static Origin Create4Debug()
		{
			return Create4Http(Settings.Default.authority__debug);
		}

		public static Origin Default => nilnul.obj_.Singleton<Origin>.Instance;

		public string href(string resource)
		{
			//if (Debugger.IsAttached)
			//{
			//	return 
			//}
#if DEBUG
			return  resource;

#else
			return this.schemelessOrigin+ resource;

#endif
		}

		/// <summary>
		/// origin with the rted:"/app_"
		/// </summary>
		public class App:Origin
		{
			public const string DENOTE = "app_";

			public App(string scheme, string authority) : base(scheme, authority)
			{
			}

			public App()
			{
			}

			public string spear => root + "app_";
			public string shield => spear + "/";
			

			public string schemelessSpear => schemelessRoot + "app_";
			public string schemelessShield => schemelessSpear + "/";

			public string sprig => $"/{DENOTE}";
			public string stem => $"{sprig}/";

			/// <summary>
			/// for use in client side. the scheme or the origin will be inferred from the base
			/// </summary>
			public string schemelessShield0Stem
			{
				get
				{
					if (HttpContext.Current==null) //in design mode for example
					{
						return $"{schemelessShield}";
					}
					if (
						HttpContext.Current.IsDebuggingEnabled
					)
					{
						return $"{stem}";
					}
					else
					{
						return $"{schemelessShield}";
					}
				}
			}

			static public App Singleton
			{
				get
				{
					return nilnul.obj_.Singleton<App>.Instance;
				}
			}
		}
	}
}