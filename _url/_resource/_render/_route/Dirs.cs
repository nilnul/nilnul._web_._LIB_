using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._objs_;
using nilnul.obj.str_;
using nilnul.fs._address;

namespace nilnul.web._url._resource._render._route
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	public class Dirs
		:
		nilnul.objs_.enumerable_.enum2Arr_.BoxEnumerable<Dir>
	{


		public Dirs(IEnumerable<Dir> dirs) : base(dirs)
		{
		}


		public Dirs() : this(new Dir[0])
		{

		}

		public Dirs(IEnumerable<DstI> dsts)
			: this(dsts.Select(dst => new Dir(dst)))
		{


		}

		






	}
}
