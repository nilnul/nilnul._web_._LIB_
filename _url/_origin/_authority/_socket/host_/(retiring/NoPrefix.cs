using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;

namespace nilnul.web._url_._authority_._socket_.host_
{
	[Obsolete()]
	public class NoPrefix:HostA
	{
		private _host_.Domain _domain;

		public override _host_.Domain domain
		{
			get { return _domain; }
			//set { _brand = value; }
		}

		

		

		public override _host_.Prefix prefix
		{
			get
			{
				return new _host_.Prefix();

				//throw new NotImplementedException();
			}
		}

		

		public NoPrefix(
			
			_host_.Domain brand
		)
		{

			_domain = brand;
		}

		public override string ToString()
		{
			return $"{_domain}";
		}

		static public NoPrefix Parse(string brand, string suffix) {

			return new NoPrefix(
				new _host_.Domain(brand,suffix)
				 
			);
		}
	}
}
