using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	/// <summary>
	/// this can be any char
	/// </summary>
	public class Fragment : _frag.txt.be.vow.En
	{
		public Fragment(string val) : base(val)
		{
		}

		public override string ToString()
		{
			var r = base.ToString();

			return string.IsNullOrEmpty(r)?"": $"#{ r}";
		}
	}
}
