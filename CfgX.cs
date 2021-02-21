using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web
{
	static public class CfgX
	{
		const string PORT_DEBUG = "12345";
#if DEBUG
		public const string HOST1 = "localhost";
		
		public const string TilHost = "http://localhost";
		public const string TilPort = TilHost + ":" + PORT_DEBUG;
		public const string HOST = "http://localhost:" + PORT_DEBUG;
		public const string DoubleSlash_Host = "//localhost:" + PORT_DEBUG;
		public const string PORT = "12345";
		public const string SOCKET = HOST1 + ":" + PORT;

		public const string SCHEME = "http";
		public const string ORIGIN = SCHEME + "://" + SOCKET;
		public const string ROOT = ORIGIN + "/";

#elif HBUE40
		public const string IP="218.197.83.40";
		public const string TilHost ="http://218.197.83.40" ; 
		public const string TilPort=TilHost ;
		public const string HOST = TilHost;
		public const string DoubleSlash_Host = "//"+IP;
#else

		public const string TilHost ="http://nilnul.com" ; 
		public const string TilPort=TilHost ;
			public const string SOCKET ="nilnul.com";
	public const string HOST = "http://nilnul.com";
		public const string HOST1 = "nilnul.com";
			public const string SCHEME = "http";
	public const string ORIGIN = SCHEME + "://" + SOCKET;
		public const string DoubleSlash_Host = "//nilnul.com";
		public const string ROOT = ORIGIN + "/";

#endif

		public const string TilPortSlash = TilPort + "/";
		public const string TilApps = TilPortSlash + "_apps";
		public const string TilAppsSlash = TilApps + "/";

		public const string APP_SUB = "app_";


		public const string ADDRESS__APP_SUB =ROOT+APP_SUB ;

		public const string CONTAINER__APP_SUB = ADDRESS__APP_SUB + "/";



		public const string UnderscoreApps = "_apps";

		public const string APP_Underscore = "app_";

		public const string APP_UNDERSCORE__DIR = APP_Underscore + "/";

		public const string APP_UNDERSCORE__ROUTE = "/" + APP_Underscore;

		public const string APP_UNDERSCORE__DECKED_DIV = APP_UNDERSCORE__ROUTE + "/";


		public const string Til_UnderscoreApps = TilPortSlash + UnderscoreApps;

		public const string Til_UnderscoreApps__Solidus = Til_UnderscoreApps + "/";

		public const string Til_AppUnderscore = TilPortSlash + APP_Underscore;

		public const string Til_AppUnderscore__Solidus = Til_AppUnderscore + "/";



		public const string _APPS_ABS = "_apps";
		public const string _APPS_ABS_SLASH = _APPS_ABS + "/";
		public const string SLASH__APPS_ABS = "/" + nilnul.web.CfgX._APPS_ABS;

		public const string SLASH__APPS_ABS_SLASH = "/" + nilnul.web.CfgX._APPS_ABS_SLASH;

		public const string _APPS_ROOT = "_apps";

		/// <summary>
		/// denote
		/// </summary>
		public const string APP__STEM = "app_";
		public const string APP_DIR = "app_";
		public const string APP__STEM_SinceRoot = "app_";

		public const string ROOT2APP_ = "/" + APP_DIR;
		public const string ROOT2APP_SLASH = ROOT2APP_ + "/";


		public const string _APPS_ROOT_SLASH = _APPS_ROOT + "/";
		public const string SLASH__APPS_ROOT = "/" + nilnul.web.CfgX._APPS_ROOT;

		public const string SLASH__APPS_ROOT_SLASH = "/" + nilnul.web.CfgX._APPS_ROOT_SLASH;


		public const string Root_APPS_SLASH = "/" + nilnul.web.CfgX._APPS_ROOT_SLASH;
		public const string Root_underscoreAPPS_SLASH = "/" + nilnul.web.CfgX._APPS_ROOT_SLASH;


		public const string Slash___APP__STEM = "/" + nilnul.web.CfgX.APP__STEM;

		public const string SLASH___APP__STEM___SLASH = Slash___APP__STEM + "/";

		public const string HOST_SLASH = HOST + "/";
		public const string APPS_BASE = HOST_SLASH + _APPS_ROOT;

		public const string DoubleSlash_Host_Slash = DoubleSlash_Host + "/";
		public const string _Apps_Dir_Name = "_apps";
		public const string DoubleSlash2Apps = DoubleSlash_Host_Slash + _Apps_Dir_Name;
		public const string DoubleSlash2UnderscoreApps = DoubleSlash_Host_Slash + _Apps_Dir_Name;

		public const string DoubleSlash2AppsSlash = DoubleSlash2Apps + "/";
		public const string DoubleSlash2UnderscoreAppsSlash = DoubleSlash2UnderscoreApps + "/";


		public const string APPS_BASE_SLASH = APPS_BASE + "/";

		public const string APPS_PATH = HOST_SLASH + "_apps";
		public const string APPS_PATH_SLASH = APPS_PATH + "/";

		public const string APPS_STEM_SinceRoot = "apps";

		public const string APPS_STEM_SINCE_ROOT__SOLIDUS = APPS_STEM_SinceRoot + "/";

		public const string ROOTED__APPS_STEM_SINCE_ROOT__SOLIDUS = "/" + APPS_STEM_SINCE_ROOT__SOLIDUS;

		public const string ROOTED_DIV4APP_UNDERSCORE = "/app_/";


		public const string COOKIE_Key_4_SESSION_KEY = "s";

		static public string CreateIriInApps(string sinceApps)
		{
			return APPS_BASE_SLASH + sinceApps;
		}

		static public string CreateIriSlashInApps(string sinceApps)
		{
			return APPS_BASE_SLASH + sinceApps + "/";
		}
		static public string CreateDoubleSlash2SinceAppsSlash(string sinceApps)
		{
			return DoubleSlash2AppsSlash + sinceApps + "/";
		}

		static public class Cookie
		{
			public const string SID_KEY = "s";

		}

		static public class RequestKeysInLowerCase
		{

			public const string ID = "id";
			public const string ID_onlyI = "i";


			public const string LANG = "l";
			public const string DATA = "d";

			public const string SESSION_ID = "s";


		}




	}
}
