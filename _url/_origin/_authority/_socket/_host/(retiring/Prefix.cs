using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority._hostPort._host
{
	/// <summary>
	/// abc.asdfa.nilnul.com, where "abc.asdfa" is proprietories
	/// </summary>
	public class Prefix
	{
		public const char dot = '.';
		private IEnumerable<_prefix.Arc> _arcs;

		public IEnumerable<_prefix.Arc> arcs
		{
			get { return _arcs; }
			set { _arcs = value; }
		}

		public Prefix(params _prefix.Arc[] arcs):this(arcs as IEnumerable<_prefix.Arc>)
		{

		}
		public Prefix(IEnumerable<_prefix.Arc> arcs)
		{
			_arcs = arcs;
		}



		public override string ToString()
		{
			return string.Join("", _arcs.Select(
				arc=>arc.ToString()+dot)
			);
		}

		internal static Prefix Parse(IEnumerable<string> enumerable)
		{
			return new Prefix(
				enumerable.Select(t=>_prefix.Arc.Parse(t))	
			);
			throw new NotImplementedException();
		}
	}
}
