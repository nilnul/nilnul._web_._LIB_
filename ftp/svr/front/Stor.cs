using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.ftp.svr.front
{
	public class Stor
	{
		private Front _front;

		public Front front
		{
			get { return _front; }
			set { _front = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="localFile"></param>
		/// <param name="hostStem"></param>
		/// <param name="targetDoc"></param>
		/// <exception cref="">
		/// The remote server returned an error: (550) File unavailable (e.g., file not found, no access).
		///		if the stem is not existant on server
		///			note: for some users the root of the user is not the web root, rather a subdirectory; in this case, the stem is based upon, not included in, the user directory.
		///				for example, for root ftp user, the hostStem shall be :
		///					someHost/someSubfolder/file.name
		///				for non-root user whose top directory is someSubfolder, the hostStem shall be:
		///					someHost/file.name
		///				with the first case (using root ftp user), we can achieve the second result.
		/// </exception>
		public void stor(
			 nilnul.fs.FileI localFile
			 ,
			 nilnul.web._url.hostRoute_.HostStem hostStem
			 ,
			 nilnul.fs._address.DocI targetDoc
			 
		)
		{

			using (WebClient client = _front.genClient())
			{

				client.UploadFile($"{nilnul.web._url._origin.Scheme1.Ftp.ToString()}{hostStem}{targetDoc}", "STOR", localFile.ToString());

			}
		}
	}
}
