using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority._hostPort._host;
using nilnul.web._url_._authority_._socket_._host_;

namespace nilnul.web._url_._authority_._socket_
{
	/// <summary>
	/// abc.wyt.nilnul.com.cn. excuding port.
	/// </summary>
	public class Host : HostA
	{


		private _host_.Prefix _prefix;

		public  override _host_.Prefix prefix
		{
			 get { return _prefix; }
		//	set { _prefix = value; }
		}

		

		private _host_.Domain _domain;

		public override  _host_.Domain domain
		{
			get { return _domain; }
			//set { _suffix = value; }
		}

		

		public Host(
			_host_.Prefix prefix
			,
			_host_.Domain brand
		)
		{

			_prefix = prefix;
			_domain = brand;
		}

		public Host(string v, Domain domain1):this(
			_host_.Prefix.Parse(v),domain1	
		)
		{
		}

		public override string ToString()
		{
			if (_prefix.arcs.Any())
			{
				return $"{_prefix}.{_domain}";

			}

			return $"{_domain}";

		}







	}
}
