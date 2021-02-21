using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority;
using nilnul.web._url._origin._authority;

namespace nilnul.web._url._origin.authority_
{
	public class NoCredential : AuthorityI2
	{
		public Socket socket { get ; set ; }
		public Credential1 credential { get => null; set => throw new NotImplementedException(); }
	}
}
