using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket._host.txt
{
	public class Be : nilnul.txt.BeI
	{
		/// <summary>
		/// can be "localhost", "domain.com", or ip address
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool be(string obj)
		{
			return Regex.IsMatch(obj, @"\A[^/\\:@?#&]+\z");
			//throw new NotImplementedException();
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
