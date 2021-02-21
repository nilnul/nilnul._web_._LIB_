using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_
{
	/// <summary>
	/// shall be named Authority
	/// </summary>
	/// 
	[Obsolete(nameof(_url.Authority1))]
	public class Authority : AuthorityI
	{
		public const char Credential_End = '@';
		private _authority_.Credential _credential;

		public _authority_.Credential credential
		{
			get { return _credential; }
			set { _credential = value; }


		}

		private _authority_.Socket _socket;

		public _authority_.Socket socket
		{
			get { return _socket; }
			set { _socket = value; }
		}

		public Authority(_authority_.Credential credential, _authority_.Socket authoritiy)
		{
			_credential = credential;
			_socket = authoritiy;
		}

		static public Authority Parse(string txt) {
			var splitted = txt.Split(Credential_End);

			if (splitted.Length==1)
			{
				return new Authority( null, _authority_.Socket.Parse(splitted[0]));
			}
			if (splitted.Length==2)
			{
				return new Authority(
					_authority_.Credential.Parse(splitted[0])
					,
					_authority_.Socket.Parse(splitted[1])	
				);
			}

			throw new FormatException();
		}




	}
}
