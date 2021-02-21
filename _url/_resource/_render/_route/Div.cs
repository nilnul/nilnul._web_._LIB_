using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.Text.RegularExpressions;
using nilnul.fs._address._dst;

namespace nilnul.web._url._resource._render._route
{
	/*extern alias obj;*/
	public class Div
		: /*obj::*/nilnul.obj.Box<Dirs>
		,
		DivisionI

	{
		public Div(Dirs val) : base(val)
		{
		}
		public Div():this(new Dir[0])
		{

		}

		public Div(IEnumerable<Dir> enumerable)
		: this(new Dirs(enumerable))
		{
		}
		public Div(IEnumerable<DstI> enumerable)
		: this(new Dirs(enumerable))
		{
		}

		static public Div CreateEmpty(){ 
			return new Div( new Dirs());
		}

		public Dirs dirs
		{
			get
			{
				return boxed;
			}
		}

		public IEnumerable<Denote> denotes => boxed.Select(x=>x.name);

		public static string Phrase(Dirs dirs)
		{

			return nilnul.txts.accumulate_.join_.Empty.Singleton.accumulate(
				dirs.Select(x =>
					(x).ToString()
				)
			);
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return nilnul.txts.accumulate_.join_.Empty.Singleton.accumulate(
				dirs.Select(x =>
					(x).ToString()
				)
			);

		}
		static public Div Parse(string x)
		{

			var splitResult = Regex.Split(x, @"(?<=\/)").ToArray();
			nilnul.txt.be_.empty.Vow.Singleton.vow(
				splitResult.Last()
			);

			return new Div(
				(splitResult).Take(splitResult.Length - 1).Select(y => Dir.Parse(y))
			);
		}


		static public Div FroDsts(IEnumerable<string> dsts)
		{
			return new Div(
				new Dsts(dsts)
				//Dsts.CreateFroDsts(dsts)
			);
		}

		static public Div FroDsts(params string[] dsts)
		{
			return new Div(
				new Dsts(dsts)
			);
		}

		static public Div FroDirs(params Dir[] dsts)
		{
			return new Div(
				dsts
			);
		}
	}
}
