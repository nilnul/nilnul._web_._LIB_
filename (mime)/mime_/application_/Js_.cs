using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.web.mime.text;
using nilnul.web.mime.main.eg.Text;

namespace nilnul.web.mime_.application_
{
	/// <summary>
	/// both the master and the sub.
	/// </summary>
	public class Js_
	{


		 const string JAVASCRIPT = "javascript";
		 const string X_JAVASCRIPT = "x-javascript";


		static public string Create(string subtype)
		{
			return nilnul.web.Mime.Create(_mime.Main_.Application, subtype);
		}

		 static string _Javascript = Create(JAVASCRIPT);

		 static string _X_Javascript = Create(X_JAVASCRIPT);
		/// <summary>
		/// http://www.iana.org/assignments/media-types/media-types.xhtml#application
		/// text is obsoleted in favor of application
		/// http://www.rfc-editor.org/rfc/rfc4329.txt
		/// application/x-javascript is what you get with an .js file. 
		/// </summary>
		public static string Js = _X_Javascript;
	}


}
