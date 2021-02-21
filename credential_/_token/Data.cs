using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.credential_._token
{
	public class Data:CredentialI
	{
		private string _txt;

		public string txt
		{
			get { return _txt; }
			set { _txt = value; }
		}

		public Data(string txt)
		{
			_txt = txt;
		}

	}
}
