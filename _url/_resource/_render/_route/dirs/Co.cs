using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.dirs
{
	public class Co
	{
		public Dirs co(Dirs arg, Dirs arg1)
		{
			return new Dirs(arg.Concat(arg1));
			//throw new NotImplementedException();
		}
		public Dirs co(
			Dirs dirs, Dir doc
		)
		{
			return new Dirs(
				nilnul.obj.seq.convert_._AppendX.Append(dirs,
				  doc)
			);
			//throw new NotImplementedException();
		}
		static public Co Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Co>.Instance;
			}
		}
	}
}
