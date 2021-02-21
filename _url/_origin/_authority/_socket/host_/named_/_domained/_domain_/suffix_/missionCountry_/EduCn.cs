using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_._authority_._socket_._host_._domain_._suffix_;

namespace nilnul.web._url_._authority_._socket_._host_._domain_.suffix_.missionCountry_
{
	public class EduCn : MissionCountry
	{
		public EduCn() : base(_suffix_.Mission.CreateEdu(), _suffix_.Country.CreateCn())
		{

		}

		static public readonly EduCn Singleton = nilnul.obj.SingletonByDefault<EduCn>.Instance;

	}
}
