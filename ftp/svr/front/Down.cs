using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr.front
{
	static public class _DownX
	{
		
	

		static public void Download(  NetworkCredential cred, nilnul.web.UrlI4 url, nilnul.fs.address_.SpearI spear)
		{
			WebClient client = new WebClient();
			client.Credentials = cred;// new NetworkCredential("username", "password");
			client.DownloadFile(
				url.ToString()	//"ftp://ftp.example.com/remote/path/file.zip"
				, 
				spear.ToString()		//@"C:\local\path\file.zip"
			);
		}

		static public void Download(  NetworkCredential cred, string  url, string  spear)
		{
			Download(cred, nilnul.web.url._ParseX4.Parse(url), new nilnul.fs.address_.Spear(spear));
		}
		static public void Download(  string name, string pass, string  url, string  spear)
		{
			Download(new NetworkCredential(name,pass),url,spear);
		}


		/// <summary>
		/// If you need a greater control, that WebClient does not offer (like TLS/SSL encryption, etc), use FtpWebRequest.
		/// </summary>
		static  void downloadStreamly()
		{
			FtpWebRequest request =
	(FtpWebRequest)WebRequest.Create("ftp://ftp.example.com/remote/path/file.zip");
			request.Credentials = new NetworkCredential("username", "password");
			request.Method = WebRequestMethods.Ftp.DownloadFile;

			using (Stream ftpStream = request.GetResponse().GetResponseStream())
			using (Stream fileStream = File.Create(@"C:\local\path\file.zip"))
			{
				ftpStream.CopyTo(fileStream);
			}
		}

		static void downProgressively()
		{
			FtpWebRequest request =
	(FtpWebRequest)WebRequest.Create("ftp://ftp.example.com/remote/path/file.zip");
			request.Credentials = new NetworkCredential("username", "password");
			request.Method = WebRequestMethods.Ftp.DownloadFile;

			using (Stream ftpStream = request.GetResponse().GetResponseStream())
			using (Stream fileStream = File.Create(@"C:\local\path\file.zip"))
			{
				byte[] buffer = new byte[10240];
				int read;
				while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
				{
					fileStream.Write(buffer, 0, read);
					Console.WriteLine("Downloaded {0} bytes", fileStream.Position);
				}
			}

		}
	}
}
