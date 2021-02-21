using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http._request_._head_.key_
{
	public class Authorization 
	{
		/// <summary>
		/// for c#v lt 5, we cannot use nameof
		/// </summary>
		public static string Name {
			get {
				return nameof(Authorization);
			}
		}
	}
}
