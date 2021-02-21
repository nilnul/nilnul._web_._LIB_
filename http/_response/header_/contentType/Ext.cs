using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http._response.header_.contentType
{
	public static class _ExtX
	{
		public static string _AftDot(string value) {
			return value.Substring(value.LastIndexOf('/'));
		}

		public static string Ext(string value) {
			return $".{_AftDot(value)}";
		}
	}
}
