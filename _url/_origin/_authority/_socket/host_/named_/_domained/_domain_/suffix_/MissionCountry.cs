using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_._domain_.suffix_
{
	public class MissionCountry: SuffixA
	{
		private _suffix_.Mission _mission;

		public _suffix_.Mission mission
		{
			get { return _mission; }
			set { _mission = value; }
		}

		private _suffix_.Country _country;

		public _suffix_.Country country
		{
			get { return _country; }
			set { _country = value; }
		}

		public MissionCountry(_suffix_.Mission mission, _suffix_.Country country)
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
				_suffix_.Mission.Parse(v1)
				,
				_suffix_.Country.Parse(v2)	
			);
			//throw new NotImplementedException();
		}

	}
}
