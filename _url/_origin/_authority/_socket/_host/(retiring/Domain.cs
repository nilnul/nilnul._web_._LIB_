using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_
{
	/// <summary>
	/// abc.com, where abc is the brand and com is the suffix.
	/// </summary>
	public class Domain
	{
		private _domain_.Brand _brand;

		public _domain_.Brand brand
		{
			get { return _brand; }
			set { _brand = value; }
		}

		private _domain_.SuffixI _suffix;

		public _domain_.SuffixI suffix
		{
			get { return _suffix; }
			set { _suffix = value; }
		}

		public Domain(_domain_.Brand brand, _domain_.SuffixI suffix)
		{
			_brand = brand;
			_suffix = suffix;
		}

		public Domain(string brand, string suffix):this( _domain_.Brand.Parse(brand), _domain_.SuffixA.Parse(suffix))
		{

		}

		public override string ToString()
		{
			return $"{_brand}.{_suffix}";
		}



	}
}
