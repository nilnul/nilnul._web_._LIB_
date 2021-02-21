using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.web._url_;
using nilnul.web._url_._authority_;

namespace nilnul.web._url
{
	/// <summary>
	/// shall be named Authority
	/// </summary>
	/// 
	[Obsolete()]
	public class Authority1 : _url_.AuthorityI
	{
		public const char Credential_End = '@';
		private _url_._authority_.Credential _credential;

		public _url_._authority_.Credential credential
		{
			get { return _credential; }
			set { _credential = value; }


		}

		private _url_._authority_.Socket _socket;

		public _url_._authority_.Socket socket
		{
			get { return _socket; }
			set { _socket = value; }
		}

		public Authority1(_url_._authority_.Credential credential, _url_._authority_.Socket authoritiy)
		{
			_credential = credential;
			_socket = authoritiy;
		}

		public Authority1(Socket socket)
		{
			this._socket = socket;
		}

		static public Authority1 Parse(string txt) {
			var splitted = txt.Split(Credential_End);

			if (splitted.Length==1)
			{
				return new Authority1( null, _url_._authority_.Socket.Parse(splitted[0]));
			}
			if (splitted.Length==2)
			{
				return new Authority1(
					_url_._authority_.Credential.Parse(splitted[0])
					,
					_url_._authority_.Socket.Parse(splitted[1])	
				);
			}

			throw new FormatException();
		}

		public override string ToString()
		{
			return (
				(_credential ==null || _credential.isBothNull() )? "": $"{credential}@"  
			)+  $"{_socket}";
		}


	}
}
