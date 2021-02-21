using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_._domain_.suffix_
{
	public class Mission:SuffixA
	{
		private _suffix_.Mission _mission;

		public _suffix_.Mission mission
		{
			get { return _mission; }
			set { _mission = value; }
		}

		public Mission(_suffix_.Mission mission)
		{
			_mission = mission;
		}

		public override string ToString()
		{
			return _mission.ToString();
		}

		public static new Mission Parse(string v)
		{
			return new Mission(
				_suffix_.Mission.Parse(v)	
			);
			//throw new NotImplementedException();
		}
	}
}
