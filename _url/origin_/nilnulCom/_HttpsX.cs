using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url.origin_.nilnulCom
{
	static public class HttpsX
	{

		public const string SCHEME = "https";
		public const string SCHEME_COLON = SCHEME + ":";


		public const string ORIGIN = SCHEME_COLON+ NilnulComX.SchemelessOrigin;

		public const string ROOT = ORIGIN + "/";
	}
}