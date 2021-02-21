using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.Properties.settings._url.origin.app.co_
{
	public class ProdDebug :
		nilnul.obj.Duo<WebApp>
		
	{
		

		public ProdDebug(string denote):base(
			new WebApp(denote),
			new origin_.local.App(denote)
		)
		{

		}

		
	}
}
