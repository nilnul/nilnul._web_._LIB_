using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr.front.file
{
	static public class _DelX
	{
		static public bool Del(Uri url, NetworkCredential cred)
		{
			if (url.Scheme != Uri.UriSchemeFtp)
			{
				return false;
			}
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);

			//If you need to use network credentials
			request.Credentials = cred;
			//additionally, if you want to use the current user's network credentials, just use:
			//System.Net.CredentialCache.DefaultNetworkCredentials

			request.Method = WebRequestMethods.Ftp.DeleteFile;
			FtpWebResponse response = (FtpWebResponse)request.GetResponse();
			Trace.WriteLine($"{nameof(Del)}Delete status: {0}", response.StatusDescription);
			response.Close();
			return true;
		}
		static public bool Del(string url, NetworkCredential cred)
		{
			return Del(new Uri(url), cred);
		}

		static public bool Del(string url, string name, string pass)
		{
			return Del((url), new NetworkCredential(name,pass));
		}

	}
}
