using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.ssl.svr.front_
{
	/*You can use FtpWebRequest; however, this is fairly low level. There is a higher-level class WebClient, which requires much less code for many scenarios; however, it doesn't support FTP/SSL by default. Fortunately, you can make WebClient work with FTP/SSL by registering your own prefix:*/
	class RegPrefix
	{
		private void RegisterFtps()
		{
			WebRequest.RegisterPrefix("ftps", new FtpsWebRequestCreator());
		}



		private sealed class FtpsWebRequestCreator : IWebRequestCreate
		{
			public WebRequest Create(Uri uri)
			{
				FtpWebRequest webRequest = (FtpWebRequest)WebRequest.Create(uri.AbsoluteUri.Remove(3, 1)); // Removes the "s" in "ftps://".
				webRequest.EnableSsl = true;
				return webRequest;
			}
		}

		/*Once you do this, you can use WebClient almost like normal, except that your URIs start with "ftps://" instead of "ftp://". The one caveat is that you have to specify the method parameter, since there won't be a default one. E.g.*/

		public void upload(Uri uploadUri, string fileName, object state)
		{
			using (var webClient = new WebClient())
			{
				// Note here that the second parameter can't be null.
				webClient.UploadFileAsync(uploadUri, WebRequestMethods.Ftp.UploadFile, fileName, state);
			}
		}

		/*From the comments of a duplicate answer: To auto-accept any certificates the client may encounter, this works: ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true; – Sphinxxx Jan 16 '18 at 0:21 

@Sphinxxx Just be aware that blindly accepting any server certificate leaves you vulnerable to a man-in-the-middle attack. – Edward Brey Jan 16 '18 at 0:26 

Yes, it's not the most elegant solution. Do you have a safer alternative? – Sphinxxx Jan 16 '18 at 0:35 
1
Normally, you just ensure that the server has a SSL certificate that matches its host name, just as you would for any HTTPS traffic. If you can't do that, you can validate a self-signed certificate. – Edward Brey Jan 16 '18 at 0:42*/

	}
}
