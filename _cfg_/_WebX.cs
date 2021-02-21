using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._cfg_
{
	public class _WebX
	{
		static public Configuration CurrentWebCfg()
		{
			System.Configuration.Configuration configWeb = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("");
			return configWeb;

		}
	}
}
