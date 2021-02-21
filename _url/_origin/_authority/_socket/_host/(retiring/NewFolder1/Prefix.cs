using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_._socket_._host_
{
	/// <summary>
	/// abc.asdfa.nilnul.com, where "abc.asdfa" is proprietories
	/// </summary>
	public class Prefix
	{
		public const char dot = '.';
		private IEnumerable<_prefix_.Arc> _arcs;

		public IEnumerable<_prefix_.Arc> arcs
		{
			get { return _arcs; }
			set { _arcs = value; }
		}

		public Prefix(params _prefix_.Arc[] arcs):this(arcs as IEnumerable<_prefix_.Arc>)
		{

		}
		public Prefix(IEnumerable<_prefix_.Arc> arcs)
		{
			_arcs = arcs;
		}



		public override string ToString()
		{
			return string.Join(".", _arcs);
		}

		public  string ToTxtEndWithDotIfNeed()
		{
			return string.Join("", _arcs.Select(
				arc=>arc.ToString()+dot)
			);
		}


		internal static Prefix Parse(IEnumerable<string> enumerable)
		{
			return new Prefix(
				enumerable.Select(t=>_prefix_.Arc.Parse(t))	
			);
			throw new NotImplementedException();
		}

		internal static Prefix CreateFroTxts(IEnumerable<string> enumerable)
		{
			return new Prefix(
				enumerable.Select(t=>_prefix_.Arc.Parse(t))	
			);
			throw new NotImplementedException();
		}


		public static Prefix Parse(string enumerable)
		{
			return CreateFroTxts( enumerable.Split(dot));
			

		}

	}
}
