using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;

namespace nilnul.web._url._origin._authority._hostPort.host_
{
	[Obsolete()]
	public class NoPrefix:HostA
	{
		private _host.Brand _brand;

		public override _host.Brand brand
		{
			get { return _brand; }
			//set { _brand = value; }
		}

		private _host.SuffixI _suffix;

		public override _host.SuffixI suffix
		{
			get { return _suffix; }
		//	set { _suffix = value; }
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
			
			_host.Brand brand
			,
			_host.SuffixI suffix
		)
		{

			_brand = brand;
			_suffix = suffix;
		}

		public override string ToString()
		{
			return $"{_brand}.{_suffix}";
		}

		static public NoPrefix Parse(string brand, string suffix) {
			var brand1 = _host.Brand.Parse(brand);

			return new NoPrefix(
				 _host.Brand.Parse(brand)
				 ,
				 _host.SuffixA.Parse(suffix)
			);
		}
	}
}
