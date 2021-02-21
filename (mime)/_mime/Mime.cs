using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.web.mime.text;

namespace nilnul.web._mime
{
	[Obsolete("nilnul.web.Mime")]
	public class Mime
	{
		private const string _SEP = "/";

		static public string Gen(string type, string subtype)
		{
			return string.Format("{0}/{1}", type, subtype);

		}


		public const string APPLICATION = "application";


		public class Application
		{
			public const string JAVASCRIPT = "javascript";
			public const string X_JAVASCRIPT = "x-javascript";


			static public string Gen(string subtype)
			{
				return Mime.Gen(Mime.APPLICATION,subtype);

			}

			public static string Js  =  Gen( Application.JAVASCRIPT);

			public static string XJs  =  Gen( Application.X_JAVASCRIPT);



		}


		/// <summary>
		/// http://www.iana.org/assignments/media-types/media-types.xhtml#application
		/// text is obsoleted in favor of application
		/// http://www.rfc-editor.org/rfc/rfc4329.txt
		/// application/x-javascript is what you get with an .js file. 
		/// </summary>

		public static string Js  =  Application.XJs;





	}
}
