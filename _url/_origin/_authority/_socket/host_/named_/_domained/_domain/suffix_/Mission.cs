using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.suffix_
{
	public class Mission:SuffixA
	{
		private _suffix.Mission _mission;

		public _suffix.Mission mission
		{
			get { return _mission; }
			set { _mission = value; }
		}

		public Mission(_suffix.Mission mission)
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
				_suffix.Mission.Parse(v)	
			);
			//throw new NotImplementedException();
		}
	}
}
