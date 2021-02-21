using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin_.nilnulCom
{
	static public class HttpX
	{

		

		public const string SCHEME = "http";
		public const string SCHEME_COLON = SCHEME + ":";


		public const string ORIGIN = SCHEME_COLON+ NilnulComX.SchemelessOrigin;


		public const string ROOT = ORIGIN + "/";

		public const string APP_SPEAR =ROOT+"app_";
		public const string APP_SHIELD = APP_SPEAR + "/";

	}
}