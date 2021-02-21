using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.client.down_
{
	static public class _WebClientX
	{
		public static nilnul.fs.address_.SpearI Spear(string url)
		{
			WebClient client = new WebClient();


			var tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


			//var downloadPath = System.IO.Path.Combine(tempFolder, fileName);
			client.OpenRead(url);


			var headers=client.ResponseHeaders;

			string ext="";
			for (int i = 0; i < headers.Count; i++)
			{
				var key = headers.GetKey(i);

				if ( nilnul.txt.eq_.CaseInsensitive.Singleton.Equals( nilnul.web.http._response.header_.ContentType.TXT, key))
				{
					var val = headers.GetValues(i)[0];
					ext = nilnul.web.http._response.header_.contentType._ExtX.Ext(val);
				}
			}

			var tgt = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.Spear(
				nilnul.web.url.resource.render.route._TipX.Txt(url)
				, ext
			);

			client.DownloadFile(url, tgt.ToString());
			return tgt;

		

		}


	}
}

