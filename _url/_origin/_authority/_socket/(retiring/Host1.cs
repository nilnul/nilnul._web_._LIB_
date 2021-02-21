using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;

namespace nilnul.web._url._origin._authority._hostPort
{
	/// <summary>
	/// abc.wyt.nilnul.com.cn. excuding port.
	/// </summary>
	/// 
	[Obsolete()]
	public class Host1 : HostA
	{


		private _host.Prefix _prefix;

		public  override _host.Prefix prefix
		{
			 get { return _prefix; }
		//	set { _prefix = value; }
		}

		private _host.Brand _brand;

		public override _host.Brand brand
		{
			get { return _brand; }
			//set { _brand = value; }
		}

		private _host.SuffixI _suffix;

		public override  _host.SuffixI suffix
		{
			get { return _suffix; }
			//set { _suffix = value; }
		}

		

		public Host1(
			_host.Prefix prefix
			,
			_host.Brand brand
			,
			_host.SuffixI suffix
		)
		{

			_prefix = prefix;
			_brand = brand;
			_suffix = suffix;
		}

		public override string ToString()
		{
			if (_prefix.arcs.Any())
			{
				return $"{_prefix}.{_brand}.{_suffix}";

			}

			return $"{_brand}.{_suffix}";

		}







	}
}
