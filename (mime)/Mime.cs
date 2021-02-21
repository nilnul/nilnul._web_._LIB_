using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.web.mime.text;
using nilnul.web.mime.main.eg.Text;

namespace nilnul.web
{
	/// <summary>
	/// both the master and the sub.
	/// </summary>
	public class Mime
	{
		private const string _SEP = "/";

		static public string Create(string type, string subtype)
		{
			return string.Format("{0}/{1}", type, subtype);

		}

		[Obsolete(nameof(Create))]
		static public string Gen(string type, string subtype)
		{
			return string.Format("{0}/{1}", type, subtype);

		}

		[Obsolete("Mime_")]
		static public class Eg
		{
			public static string TextPlain = Gen(Text.STR, Text.Subs.PLAIN);

			public static string ApplicationJson = Gen(nilnul.web.mime.main.eg.Application.STR, nilnul.web.mime.main.eg.Application.Subs.JSON);

			public static string ImageSvgXml = Gen("image", nilnul.web.mime.main.eg.image.Sub.Instances.SVG_plus_XML);

			public static string ImageGif = Gen("image", "gif");

			public static string TextCss = Gen("text", "css");
			public static string Application_OctetStreamExe = Gen(nilnul.web.mime.main.eg.Application.STR, "octet-stream");

			public const string APPLICATION_SLASH_XHTML_PLUS_XML = "application/xhtml+xml";
			public static string Application_OctetStream = Gen(nilnul.web.mime.main.eg.Application.STR, nilnul.web.mime.main.eg.Application.Subs.OctetStream);

			public static string Video_Mp4 = Gen(nilnul.web.mime.main.eg.Video.Txt, nilnul.web.mime.main.eg.Video.Subs.MP4);

		}


		[Obsolete("mime.main.eg")]
		public class Application
		{

			public const string APPLICATION = "application";

			public const string JAVASCRIPT = "javascript";
			public const string X_JAVASCRIPT = "x-javascript";


			static public string Gen(string subtype)
			{
				return Mime.Gen(APPLICATION,subtype);

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
