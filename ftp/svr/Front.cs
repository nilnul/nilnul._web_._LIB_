using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr
{
	public class Front
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
		public void upload()
		{
			WebClient client = new WebClient();
			client.Credentials = new NetworkCredential("username", "password");
			client.UploadFile("ftp://ftp.example.com/remote/path/file.zip", @"C:\local\path\file.zip");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="localFilePath">@"C:\local\path\file.zip"</param>
		void uploadStreamly(string localFilePath)
		{
			FtpWebRequest request =
	(FtpWebRequest)WebRequest.Create("ftp://ftp.example.com/remote/path/file.zip");
			request.Credentials = cred;
			request.Method = WebRequestMethods.Ftp.UploadFile;

			using (Stream fileStream = File.OpenRead(localFilePath))
			using (Stream ftpStream = request.GetRequestStream())
			{
				fileStream.CopyTo(ftpStream);
			}

		}

		void uploadProgressively()
		{
			FtpWebRequest request =
	(FtpWebRequest)WebRequest.Create("ftp://ftp.example.com/remote/path/file.zip");
			request.Credentials = this._cred;
			request.Method = WebRequestMethods.Ftp.UploadFile;

			using (Stream fileStream = File.OpenRead(@"C:\local\path\file.zip"))
			using (Stream ftpStream = request.GetRequestStream())
			{
				byte[] buffer = new byte[10240];
				int read;
				while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
				{
					ftpStream.Write(buffer, 0, read);
					Console.WriteLine("Uploaded {0} bytes", fileStream.Position);
				}
			}
		}

		
	}
}
