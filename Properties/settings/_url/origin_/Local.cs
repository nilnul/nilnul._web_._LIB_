using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.Properties.settings._url.origin_
{
	public class Local : Origin.App
	{
		public Local():this(Settings.Default.scheme)
		{
		}

		public Local(string scheme) : base(scheme, Settings.Default.authority__debug)
		{
		}
	}
}
