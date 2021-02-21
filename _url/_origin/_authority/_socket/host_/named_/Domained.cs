using nilnul.web._url._origin._authority._socket._host;
using nilnul.web._url._origin._authority._socket.host_.named_._domained;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_
{
	/// <summary>
	/// abc.wyt.nilnul.com.cn. excuding port.
	/// </summary>
	public class Domained : DomainedA
	{


		private Prefix _prefix;

		public  override Prefix prefix
		{
			 get { return _prefix; }
		//	set { _prefix = value; }
		}

		

		private Domain _domain;

		public override  Domain domain
		{
			get { return _domain; }
			//set { _suffix = value; }
		}

		

		public Domained(
			Prefix prefix
			,
			Domain brand
		)
		{

			_prefix = prefix;
			_domain = brand;
		}

		public Domained(string v, Domain domain1):this(
			Prefix.Parse(v),domain1	
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
