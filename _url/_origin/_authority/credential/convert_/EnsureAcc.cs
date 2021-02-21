using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority.credential.convert_
{
	static public class _EnsureAccX
	{
		static public _url._origin._authority.Credential1 Op(_url._origin._authority.Credential1 credential, _credential.Acc acc) {
			if (credential.username == null)
			{
				return new _url._origin._authority.Credential1(acc, credential.password);

			}
			else return credential;
		}
	}
}
