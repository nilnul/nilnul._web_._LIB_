using nilnul.fs._address;
using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource._render._route.div
{
	public class Document
		: DivisionI
	{

		private Div _div;

		public Div div
		{
			get { return _div; }
			set { _div = value; }
		}
		private nilnul.fs._address.DocI _doc;

		public DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public IEnumerable<Denote> denotes => nilnul.obj.str.op_.unary_._TipX.Tip( _div.denotes, doc.denote);

		public Document(
			Div div,
			DocI doc

		)
		{
			_div = div;
			_doc = doc;
		}

		public Document(string div, string doc)
			: this(Div.Parse(div), new Doc(doc))
		{

		}

		public override string ToString()
		{
			return $"{_div}{_doc}";
		}

		static public Document Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);



			return new Document(

				Div.FroDsts(split.Take(split.Length - 1))
				,
				new nilnul.fs._address.Doc(split.Last())
			);

		}




	}
}
