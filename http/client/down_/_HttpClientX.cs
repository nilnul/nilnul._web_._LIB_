using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.client.down_
{
	/// <summary>
	/// with ext
	/// </summary>
	static public class _HttpClientX
	{
		static public string SpearTxt(string url)
		{
			return Task(url).Result;
		}

		/// <summary>
		/// return the filePath
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		static public async Task<string> Task(string url)
		{
			// Create a New HttpClient object and dispose it when done, so the app doesn't leak resources
			using (HttpClient client = new HttpClient())
			{
				// Call asynchronous network methods in a try/catch block to handle exceptions
				try
				{
					HttpResponseMessage response = await client.GetAsync(url);
					response.EnsureSuccessStatusCode();
					var headers = response.Headers;
					string ext = "";
					for (int i = 0; i < headers.Count(); i++)
					{
						var key = headers.ElementAt(i).Key;

						if (nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(nilnul.web.http._response.header_.ContentType.TXT, key))
						{
							var val = headers.ElementAt(i).Value.First();//[0];
							ext = nilnul.web.http._response.header_.contentType._ExtX.Ext(val);
						}
					}

					var tgt = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(
	nilnul.web.url.resource.render.route._TipX.Txt(url)
	, ext
);
					using (var fs = new FileStream(
	tgt.ToString(), FileMode.CreateNew))
					{
						await response.Content.CopyToAsync(fs);

					}
					return tgt;


				}
				catch (HttpRequestException e)
				{
					throw;
				}
			}
		}

	






	}
}

