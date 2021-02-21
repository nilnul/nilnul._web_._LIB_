using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_._domain_.suffix_
{
	public class AbbrCountry: SuffixA
	{
		private _abbrCountry_.Abbr _abbr;

		public _abbrCountry_.Abbr abbr
		{
			get { return _abbr; }
			set { _abbr = value; }
		}

		private _suffix_.Country _country;

		public _suffix_.Country country
		{
			get { return _country; }
			set { _country = value; }
		}
		public AbbrCountry(_abbrCountry_.Abbr abbr, _suffix_.Country country)
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
				_abbrCountry_.Abbr.Parse(v1)
				,
				_suffix_.Country.Parse(v2)	
			);
			//throw new NotImplementedException();
		}
	}
}
