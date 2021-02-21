using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace nilnul.web.aspNet
{

	static public class HtmlWriterX
	{
		public static void WriteBeginComment(this HtmlTextWriter writer)
		{
			writer.Write(HtmlTextWriter.TagLeftChar);
			writer.Write("!--");
		}

		public static void WriteEndComment(this HtmlTextWriter writer)
		{
			writer.Write("--");
			writer.Write(HtmlTextWriter.TagRightChar);
		}

		public static void WriteComment(this HtmlTextWriter writer, string comment)
		{
			if (
				comment.StartsWith(">") ||
				comment.StartsWith("->") ||
				comment.Contains("--") ||
				comment.EndsWith("-"))
			{
				throw new ArgumentException(
					"text does not meet HTML5 specification",
					"comment");
			}

			writer.WriteBeginComment();
			writer.Write(comment);
			writer.WriteEndComment();
		}
	}
}
