using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._resource_
{
	public interface FragI
	{
		_url.Fragment frag { get; }

	}

	public abstract class Frag:FragI
	{
		private _url.Fragment _frag;

		public _url.Fragment frag
		{
			get { return _frag; }
			set { _frag= value; }
		}

		public Frag(_url.Fragment frag)
		{
			_frag= frag;
		}


	}
}
