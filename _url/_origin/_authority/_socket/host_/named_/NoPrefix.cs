using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url._origin._authority._socket.host_.named_._domained;

namespace nilnul.web._url._origin._authority._socket.host_.named_
{
	public class NoPrefix:DomainedA
	{
		private Domain _domain;

		public override Domain domain
		{
			get { return _domain; }
			//set { _brand = value; }
		}

		

		

		public override Prefix prefix
		{
			get
			{
				return new Prefix();

				//throw new NotImplementedException();
			}
		}

		

		public NoPrefix(
			
			Domain brand
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
				new Domain(brand,suffix)
				 
			);
		}
	}
}
