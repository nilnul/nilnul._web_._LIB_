using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.Properties.settings._url.origin_.local
{
	
	public class App:_url.origin.WebApp
	{

		public App(origin_.Local origin, string denote):base(origin, denote)
		{
			
		}
		public App(string scheme,  string denote):this(new origin_.Local(scheme), denote)
		{

		}

		public App(string denote):this( new origin_.Local(),denote)
		{

		}


		
	}
}
