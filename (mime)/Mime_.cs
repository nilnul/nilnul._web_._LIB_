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
	public class Mime_
	{
		
			public static string TextPlain = Mime.Create(Text.STR, Text.Subs.PLAIN);

			public static string ApplicationJson = Mime.Create(nilnul.web.mime.main.eg.Application.STR, nilnul.web.mime.main.eg.Application.Subs.JSON);

			public static string ImageSvgXml = Mime.Create("image", nilnul.web.mime.main.eg.image.Sub.Instances.SVG_plus_XML);

			public static string ImageGif = Mime.Create("image", "gif");

			public static string TextCss = Mime.Create("text", "css");
			public static string Application_OctetStreamExe = Mime.Create(nilnul.web.mime.main.eg.Application.STR, "octet-stream");

			public const string APPLICATION_SLASH_XHTML_PLUS_XML = "application/xhtml+xml";
			public static string Application_OctetStream = Mime.Create(nilnul.web.mime.main.eg.Application.STR, nilnul.web.mime.main.eg.Application.Subs.OctetStream);

			public static string Video_Mp4 = Mime.Create(nilnul.web.mime.main.eg.Video.Txt, nilnul.web.mime.main.eg.Video.Subs.MP4);

			public static string TextCsv = Mime.Create("text", "csv");



		
	}
}
