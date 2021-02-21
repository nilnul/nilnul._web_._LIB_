using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.client.down_.byDotnet_
{
	class HttpWebReq
	{
		public static void MethodName()
		{
			HttpWebRequest http = (HttpWebRequest)WebRequest.Create("http://example.com");
			WebResponse response = http.GetResponse();

			var stream = response.GetResponseStream();
			StreamReader sr = new StreamReader(stream);
			string content = sr.ReadToEnd();
		}
	}
}
