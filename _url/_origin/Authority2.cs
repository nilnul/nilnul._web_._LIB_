using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url._origin._authority;
using nilnul.web._url_;

namespace nilnul.web._url._origin
{
	/// <summary>
	/// shall be named Authority
	/// </summary>
	public class Authority2 : _url._origin.AuthorityI2
	{
		public const char Credential_End = '@';
		private _url._origin._authority.Credential1 _credential;

		public _url._origin._authority.Credential1 credential
		{
			get { return _credential; }
			set { _credential = value; }
		}

		private _url._origin._authority.Socket _socket;

		public _url._origin._authority.Socket socket
		{
			get { return _socket; }
			set { _socket = value; }
		}

		public Authority2(_url._origin._authority.Credential1 credential, _url._origin._authority.Socket authoritiy)
		{
			_credential = credential;
			_socket = authoritiy;
		}

		public Authority2(Socket socket)
		{
			this._socket = socket;
		}

		static public Authority2 Parse(string txt) {
			var splitted = txt.Split(Credential_End);

			if (splitted.Length==1)
			{
				return new Authority2( null, _url._origin._authority.Socket.Parse(splitted[0]));
			}
			if (splitted.Length==2)
			{
				return new Authority2(
					_url._origin._authority.Credential1.Parse(splitted[0])
					,
					_url._origin._authority.Socket.Parse(splitted[1])	
				);
			}

			throw new nilnul.exception_.ParseException($"{txt} is not authority");
		}

		public override string ToString()
		{
			return (
				(_credential ==null || _credential.isBothNull() )? "": $"{credential}@"  
			)+  $"{_socket}";
		}


	}
}
