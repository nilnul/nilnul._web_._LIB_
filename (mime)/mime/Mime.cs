using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.web.mime.text;

namespace nilnul.web.mime
{
	[Obsolete("nilnul.web")]
    public class Mime
    {
	    private const string _SEP="/";

		static public string Gen(string type, string subtype)
		{
			return string.Format("{0}/{1}", type, subtype);

		}
		static public class Instances
		{
			public static string TextPlain = Gen(Text.STR, Text.Subs.PLAIN);

			public static string ApplicationJson = Gen(Application.STR, Application.Subs.JSON);

			public static string ImageSvgXml=Gen("image", main.eg.image.Sub.Instances.SVG_plus_XML);

			public static string ImageGif = Gen("image","gif");

			public static string TextCss = Gen("text", "css");
			public static string Application_OctetStreamExe = Gen( Application.STR, "octet-stream");

			public const string APPLICATION_SLASH_XHTML_PLUS_XML = "application/xhtml+xml";
			public static string Application_OctetStream = Gen(Application.STR, Application.Subs.OctetStream);

		}

		

	

    }
}
