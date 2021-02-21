using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained
{
	/// <summary>
	/// abc.com, where abc is the brand and com is the suffix.
	/// </summary>
	public class Domain:HostI1
	{
		private _domain.Brand _brand;

		public _domain.Brand brand
		{
			get { return _brand; }
			set { _brand = value; }
		}

		private _domain.SuffixI _suffix;

		public _domain.SuffixI suffix
		{
			get { return _suffix; }
			set { _suffix = value; }
		}

		public Domain(_domain.Brand brand, _domain.SuffixI suffix)
		{
			_brand = brand;
			_suffix = suffix;
		}

		public Domain(string brand, string suffix):this(
			_domain.Brand.Parse(brand)
			,
			_domain.SuffixA.Parse(suffix)
		)
		{

		}

		public override string ToString()
		{
			return $"{_brand}.{_suffix}";
		}



	}
}
