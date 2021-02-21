using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url
{
	/// <summary>
	/// shall be named Authority
	/// </summary>
	/// 
	[Obsolete()]
	public class Authority : AuthorityI
	{
		public const char Credential_End = '@';
		private _authority.Credential _credential;

		public _authority.Credential credential
		{
			get { return _credential; }
			set { _credential = value; }


		}

		private _authority.HostPort _hostPort;

		public _authority.HostPort hostPort
		{
			get { return _hostPort; }
			set { _hostPort = value; }
		}

		public Authority(_authority.Credential credential, _authority.HostPort authoritiy)
		{
			_credential = credential;
			_hostPort = authoritiy;
		}

		static public Authority Parse(string txt) {
			var splitted = txt.Split(Credential_End);

			if (splitted.Length==1)
			{
				return new Authority( null, _authority.HostPort.Parse(splitted[0]));
			}
			if (splitted.Length==2)
			{
				return new Authority(
					_authority.Credential.Parse(splitted[0])
					,
					_authority.HostPort.Parse(splitted[1])	
				);
			}

			throw new Exception();
		}

		

	}
}
