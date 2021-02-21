using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.suffix_
{
	public class Country:SuffixA
	{

		private _suffix.Country _country;

		public _suffix.Country country
		{
			get { return _country; }
			set { _country = value; }
		}

		public Country(_suffix.Country country)
		{
			_country = country;
		}

		public override string ToString()
		{
			return _country.ToString();
		}

		static public Country Parse(string txt) {

			return new Country(
				_suffix.Country.Parse(txt)	
			);
		}

	}
}
