using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_._domain_.suffix_
{
	public class Country:SuffixA
	{

		private _suffix_.Country _country;

		public _suffix_.Country country
		{
			get { return _country; }
			set { _country = value; }
		}

		public Country(_suffix_.Country country)
		{
			_country = country;
		}

		public override string ToString()
		{
			return _country.ToString();
		}

		static public Country Parse(string txt) {

			return new Country(
				_suffix_.Country.Parse(txt)	
			);
		}

	}
}
