using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._frag.txt
{
	extern alias txt;
	public class Be : txt::nilnul.txt.BeI
	{
		static public readonly txt::nilnul.txt.be_.Exclude Exclude = new txt::nilnul.txt.be_.Exclude('#');
		public bool be(string obj)
		{
			return Exclude.be(obj);
			//throw new NotImplementedException();
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Be>.Instance;
			}
		}

	}
}
