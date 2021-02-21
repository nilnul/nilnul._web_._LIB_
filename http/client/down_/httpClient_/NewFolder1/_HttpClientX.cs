using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.client.down_
{
	static public class _HttpClientX
	{
		public static void MethodName()
		{
			WebClient client = new WebClient();

			string resource
				;

			resource = "https://res.wx.qq.com/voice/getvoice?mediaid=MzA5ODc3MjM0Ml80MDIyNDY0MTk=";

			var tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);




			var fileName = "yangMi.flv";
			var downloadPath = System.IO.Path.Combine(tempFolder, fileName);

			client.DownloadFile(resource, downloadPath);
		}


		public async Task<ActionResult> GetAttachment(int FileID)
		{
			UriBuilder uriBuilder = new UriBuilder();
			uriBuilder.Scheme = "https";
			uriBuilder.Host = "api.example.com";

			var Path = "/files/download";
			uriBuilder.Path = Path;
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(uriBuilder.ToString());
				client.DefaultRequestHeaders.Accept.Clear();
				//client.DefaultRequestHeaders.Add("authorization", access_token); //if any
				//client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage response = await client.GetAsync(uriBuilder.ToString());

				if (response.IsSuccessStatusCode)
				{
					response.Headers[""];
					System.Net.Http.HttpContent content = response.Content;
					var contentStream = await content.ReadAsStreamAsync(); // get the actual content stream
					return File(contentStream, content_type, filename);
				}
				else
				{
					throw new FileNotFoundException();
				}
			}
		}
	}
}

