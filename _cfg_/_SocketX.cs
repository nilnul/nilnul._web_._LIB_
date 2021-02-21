using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._cfg_
{
	static public class SocketX
	{


#if DEBUG
		public const string HOST = "localhost";
		const string PORT = "12345";
		public const string SOCKET = HOST+":"+PORT;
#else
		public const string HOST = "nilnul.com";
		public const string SOCKET = HOST;
#endif
		public const string SchemelessOrigin = "//"+ HOST;

		public const string SchemelessRoot = SchemelessOrigin + "/";

		public const string SCHEME = "http";
		public const string SCHEME_COLON = SCHEME + ":";
		public const string ORIGIN = SCHEME_COLON+ SchemelessOrigin;

		public const string ROOT = ORIGIN + "/";
	}
}