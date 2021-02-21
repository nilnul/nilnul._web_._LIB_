using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.suffix_
{
	public class MissionCountry: SuffixA
	{
		private _suffix.Mission _mission;

		public _suffix.Mission mission
		{
			get { return _mission; }
			set { _mission = value; }
		}

		private _suffix.Country _country;

		public _suffix.Country country
		{
			get { return _country; }
			set { _country = value; }
		}

		public MissionCountry(_suffix.Mission mission, _suffix.Country country)
		{
			_mission = mission;
			_country = country;
		}
		public override string ToString()
		{
			return $"{_mission}.{_country}";
		}

		public static MissionCountry  Parse(string v1, string v2)
		{
			return new MissionCountry(
				_suffix.Mission.Parse(v1)
				,
				_suffix.Country.Parse(v2)	
			);
			//throw new NotImplementedException();
		}

	}
}
