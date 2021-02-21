using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.client.down_.httpClient_
{
	/// <summary>
	/// with ext
	/// </summary>
	static public class _IntoFolderX
	{
	

		static public async Task<nilnul.fs.Folder> Async_intoTmp(string url, string denote="downed")
		{
			nilnul.fs.folder_._TmpX.Ensure();
			var f=nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofBase(denote);
			await Async_intoFolder(url, f);
			return f;
			
		}

		static public async Task Async_intoFolder(string url, string tgt)
		{
			await Async_intoFolder(url,  nilnul.fs.folder._EnsureX.Folder_ofAddress(tgt));
		}


		static public async Task Async_intoFolder(string url, nilnul.fs.FolderI  folder)
		{
			//nilnul.fs.address_.spear.be_.newable.Vow.Singleton
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

					var tgt =  nilnul.fs.address_.spear_.ParentDoc.Create_ofContainerAsAddress(
						folder.ToString()
						,

						//new nilnul.fs._address.doc_.MainExt(
							nilnul.web.url.resource.render.route._TipX.Txt(url)+
							//,
							ext
						//).ToString()
					)
					;
					using (var fs = new FileStream(
	tgt.ToString(), FileMode.CreateNew))
					{
						await response.Content.CopyToAsync(fs);

					}
					return;


				}
				catch (HttpRequestException e)
				{
					throw;
				}
			}
		}

	}
}

