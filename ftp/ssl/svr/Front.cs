using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.ssl.svr
{
	class Front
	{

		private NetworkCredential _cred;

		public NetworkCredential cred
		{
			get { return _cred; }
			set { _cred = value; }
		}

		public Front(NetworkCredential cred)
		{
			_cred = cred;
		}

		public WebClient genClient()
		{
			return new WebClient()
			{
				Credentials = _cred
			};

		}

		 void upload()
		{
			FtpWebRequest request =
	(FtpWebRequest)WebRequest.Create("ftp://ftp.example.com/remote/path/file.zip");
			request.Credentials = new NetworkCredential("username", "password");
			request.EnableSsl = true;   //The key is the EnableSsl property.
			request.Method = WebRequestMethods.Ftp.UploadFile;

			using (Stream fileStream = File.OpenRead(@"C:\local\path\file.zip"))
			using (Stream ftpStream = request.GetRequestStream())
			{
				fileStream.CopyTo(ftpStream);
			}

		}

	}
}
