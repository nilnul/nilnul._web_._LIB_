using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web
{
	static public class IriX
	{
		const string PORT_DEBUG = "12345";

#if DEBUG
		public const string HOST = "http://localhost:" + PORT_DEBUG;
#else
	public const string HOST = "http://nilnul.com";

#endif

		public const string _APPS_ABS= "_apps";
		public const string _APPS_ABS_SLASH = _APPS_ABS+"/";
		public const string SLASH__APPS_ABS= "/"+nilnul.web.CfgX._APPS_ABS;

		public const string SLASH__APPS_ABS_SLASH= "/"+nilnul.web.CfgX._APPS_ABS_SLASH ;

		public const string _APPS_ROOT= "_apps";
		public const string _APPS_ROOT_SLASH = _APPS_ROOT+"/";
		public const string SLASH__APPS_ROOT= "/"+nilnul.web.CfgX._APPS_ROOT;

		public const string SLASH__APPS_ROOT_SLASH= "/"+nilnul.web.CfgX._APPS_ROOT_SLASH ;


		public const string HOST_SLASH = HOST + "/";
		public const string APPS_BASE= HOST_SLASH+ _APPS_ROOT;
		public const string APPS_BASE_SLASH =APPS_BASE+"/";


		public const string APPS_PATH = HOST_SLASH + "_apps";
		public const string APPS_PATH_SLASH = APPS_PATH + "/";

		public const string COOKIE_Key_4_SESSION_KEY = "s";

		static public string CreateFullPath_ofPathSinceApps(string pathSinceApps) {

			return APPS_BASE_SLASH + pathSinceApps;

		}

		static public class RequestKeysInLowerCase
		{

			public const string ID = "id";
			public const string ID_onlyI = "i";


			public const string LANG="l";
			public const string DATA = "d";


		}




	}
}
