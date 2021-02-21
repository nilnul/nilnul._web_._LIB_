using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.mime.to
{
	public class GetFileExtensionX
	{

		static public string GetFileExtension(string contentType) {

			if (StringComparer.InvariantCultureIgnoreCase.Equals( contentType, nilnul.web.Mime.Eg.Video_Mp4))
			{

					return "mp4";

			}

			var fileType = contentType.ToLower();



			
				switch (fileType)
				{
					case "image/jpeg":
						return  "jpg";
						break;
					case "image/gif":
						return  "gif";
						break;
					case "image/png":
						return "png";
						break;

					default:
						break;
				}







				return "";
		}
	}
}
