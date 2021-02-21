using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr.front.file
{
	static public class _ExistX
	{
		static public bool Exist(nilnul.web.UrlI4 url, NetworkCredential cred)
		{
			//string url = "ftp://ftp.example.com/remote/path/file.txt";

			var  request = (FtpWebRequest)WebRequest.Create(url.ToString());
			request.Credentials = cred;// new NetworkCredential("username", "password");
			request.Method = WebRequestMethods.Ftp.GetDateTimestamp;// WebRequestMethods.Ftp.GetFileSize;
			/*Because
			request.Method = WebRequestMethods.Ftp.GetFileSize
may fails in some case (550: SIZE not allowed in ASCII mode), you can just check Timestamp instead.*/

			request.UseBinary = true;
			try
			{
				request.GetResponse();
				return true;
			}
			catch (WebException e)
			{
				FtpWebResponse response = (FtpWebResponse)e.Response;
				if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
				{
					Trace.WriteLine("Does not exist");
					return false;
				}
				else
				{
					Trace.WriteLine("Error: " + e.Message);
					throw;
				}
			}
		}
		static public bool Exist(string url, NetworkCredential cred)
		{
			return Exist(  nilnul.web.url._ParseX4.Parse(url), cred);
		}

		static public bool Exist(string url, string name, string pass)
		{
			return Exist(  (url), new NetworkCredential(name,pass) );
		}

	}
}
