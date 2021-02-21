using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;
using nilnul.fs._address;
using nilnul.fs._address._dst;

namespace nilnul.web._url._resource._render._route
{
	/*extern alias obj;*/
	/// <summary>
	/// </summary>
	public class Dir

		: nilnul.obj.Box< nilnul.fs._address._dst.Denote> // it's different from dir in that in web, the "/" is different from "\"

	{
		
		
		[Obsolete()]
		public Dir(DstI dst) : this( new Denote(  dst.denote))
		{
		}

		public Dir(Denote val) : base(val)
		{
		}

		public nilnul.fs._address._dst.Denote name {
			get { return boxed; }
		}

		static public Dir Parse(string x)
		{
			nilnul.obj.vow_.True.Vow(
				x.EndsWith(
					_route._SeparatorX.Txt
				)
			);

			return new Dir(
				new Denote(
					x.Substring(0, x.Length - 1)
				)
			);
		}

		static public Dir CreateFroDst(string dst)
		{
			return new Dir(
				new Denote(dst)
			);
		}
		//[Obsolete()]
		//public DstI dst
		//{
		//	get { return new nilnul.fs._address.Dst( this.boxed); }
		//}



		public override string ToString()
		{
			return $"{this.boxed}{_route._SeparatorX.Txt}";
		}

		


	}
}
