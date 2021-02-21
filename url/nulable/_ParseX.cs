using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.url.nulable
{
	static public class _ParseX
	{
		static public Url3 Parse(string x) {
			try
			{
				return url._ParseX3.Parse(x);
			}
			catch (Exception)
			{
				return null;
				//throw;
			}
		}
	}
}
