using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._sprig
{


	public class Stem
	{

		public const char SEPARATOR = '/';

		public bool beEmpty {
			get {
				return nilnul.obj.seq.Extensions.None(_dsts);
			}
		}
		public bool beFilled{
			get {
				return _dsts.Any();
			}
		}


		private IEnumerable<Dst> _dsts;

		public IEnumerable<Dst> dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}

		public Stem(IEnumerable<Dst> dsts)
		{
			_dsts = dsts;
		}

		public Stem(params Dst[] dsts):this(dsts as IEnumerable<Dst>)
		{

		}

		public override string ToString()
		{
			return nilnul.obj.str.to_._txt.Extensions.ToTxt(_dsts,SEPARATOR);
		}

		static public Stem Parse(string txt) {

			return new Stem(
				 txt.Split('/').Select(t=>Dst.Parse(t))	
			);
		}





	}
}
