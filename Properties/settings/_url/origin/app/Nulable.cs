using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.Properties.settings._url.origin.app
{
	public class Nulable : WebApp
	{
		public Nulable(string denote) : base(denote)
		{
		}

		public Nulable(Origin.App url, string denote) : base(url, denote)
		{
		}

		public Nulable(string scheme, string authority, string denote) : base(scheme, authority, denote)
		{
		}


		public string schemelessUrl_ofResource(string resourceInFolder) {

			return this.origin.href( this.stem + resourceInFolder );// this.schemelessShield + ;

		}



		public string resource_ofDecklessResource(string resourceInFolder) {
			
			return this.stem + resourceInFolder;
		}



	}
}
