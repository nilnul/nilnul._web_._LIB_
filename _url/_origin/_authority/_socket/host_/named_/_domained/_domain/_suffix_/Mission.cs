using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_._domain_._suffix_
{
	/// <summary>
	/// .com, net, org, mil, gov, edu
	/// </summary>
	public class Mission : _mission.txt.be_.Well.En
	{
		public Mission(string s) : base(s)
		{
		}



		public static Mission Parse(string v)
		{
			return new Mission(v);

			//throw new NotImplementedException();
		}

		public static Mission CreateEdu() { return new Mission("edu"); }


	}
}
