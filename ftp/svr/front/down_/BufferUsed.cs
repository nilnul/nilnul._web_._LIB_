using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr.front.down_
{
	class BufferUsed
	{
		private void DownloadFile(string userName, string password, string ftpSourceFilePath, string localDestinationFilePath)
		{
			int bytesRead = 0;
			byte[] buffer = new byte[2048];

			FtpWebRequest request = CreateFtpWebRequest(ftpSourceFilePath, userName, password, true);
			request.Method = WebRequestMethods.Ftp.DownloadFile;

			Stream reader = request.GetResponse().GetResponseStream();
			FileStream fileStream = new FileStream(localDestinationFilePath, FileMode.Create);

			while (true)
			{
				bytesRead = reader.Read(buffer, 0, buffer.Length);

				if (bytesRead == 0)
					break;

				fileStream.Write(buffer, 0, bytesRead);
			}
			fileStream.Close();
		}

		private FtpWebRequest CreateFtpWebRequest(string ftpDirectoryPath, string userName, string password, bool keepAlive = false)
		{
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(ftpDirectoryPath));

			//Set proxy to null. Under current configuration if this option is not set then the proxy that is used will get an html response from the web content gateway (firewall monitoring system)
			request.Proxy = null;

			request.UsePassive = true;
			request.UseBinary = true;
			request.KeepAlive = keepAlive;

			request.Credentials = new NetworkCredential(userName, password);

			return request;
		}
	}
}
