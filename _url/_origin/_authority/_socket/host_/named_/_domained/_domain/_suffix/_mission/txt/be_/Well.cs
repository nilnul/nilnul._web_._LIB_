using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._socket.host_.named_._domained._domain._suffix._mission.txt.be_
{
	public class Well : nilnul.txt.BeI
	{
		public nilnul.txt.set_.BothCasesOnStr Listed = new nilnul.txt.set_.BothCasesOnStr(
			"gov"
			,
			"edu",
			"com",
			"mil",
			"org",
			"net",
			"int"	
		);
		public nilnul.txt.set_.BothCasesOnStr Reserved = new nilnul.txt.set_.BothCasesOnStr(
			"example"
			,
			"invalid",
			"local",
			"localhost",
			"test"
		);
		public nilnul.txt.set_.BothCasesOnStr Infra = new nilnul.txt.set_.BothCasesOnStr(
			"arpa"
			
		);

		public nilnul.txt.set_.BothCasesOnStr Sponsored = new nilnul.txt.set_.BothCasesOnStr(
			"aero"
			,
			"asia"
			,
			"cat"
			,
			"coop"
			,
			"jobs"
			,
			"mobi"
			,
			"museum"
			,
			"post"
			,
			"tel"
			,
			"travel"
			,
			"xxx"
			
		);



		public bool be(string obj)
		{

			return Listed.contains(obj);

			//throw new NotImplementedException();
		}


		static public readonly Well Singleton = SingletonByDefault<Well>.Instance;
		public class En : nilnul.txt.be.En_beSingleton<Well>
		{
			public En(string s) : base(s)
			{
			}
		}

	}
}
