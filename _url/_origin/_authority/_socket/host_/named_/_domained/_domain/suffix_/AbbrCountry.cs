using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.suffix_
{
	public class AbbrCountry: SuffixA
	{
		private _abbrCountry.Abbr _abbr;

		public _abbrCountry.Abbr abbr
		{
			get { return _abbr; }
			set { _abbr = value; }
		}

		private _suffix.Country _country;

		public _suffix.Country country
		{
			get { return _country; }
			set { _country = value; }
		}
		public AbbrCountry(_abbrCountry.Abbr abbr, _suffix.Country country)
		{
			_abbr = abbr;
			_country = country;
		}

		public override string ToString()
		{
			return $"{_abbr}.{_country}";
		}

		public static AbbrCountry Parse(string v1, string v2)
		{

			return new AbbrCountry(
				_abbrCountry.Abbr.Parse(v1)
				,
				_suffix.Country.Parse(v2)	
			);
			//throw new NotImplementedException();
		}
	}
}
