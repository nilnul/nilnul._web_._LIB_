using nilnul.web._url_._authority_._credential_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url_._authority_
{
	[Obsolete()]
	public class Credential
	{
		private _url._origin._authority._credential.Acc _username;

		public _url._origin._authority._credential.Acc username
		{
			get { return _username; }
			set { _username = value; }
		}
		private _credential_.Key _password;

		public _credential_.Key password
		{
			get { return _password; }
			set { _password = value; }
		}

		public static implicit operator System.Net.NetworkCredential(Credential c) {
			return new System.Net.NetworkCredential(c.username, c.password);
		}


		public Credential(_url._origin._authority._credential.Acc username=null, Key password=null)
		{
			_username = username;
			_password = password;
		}

		public Credential(string username, string password):this(new _url._origin._authority._credential.Acc(username), new Key(password))
		{

		}

		public Credential(string username):this(new _url._origin._authority._credential.Acc(username))
		{

		}


		public bool isBothNull() {
			return _username == null && _password == null;
		}

		public override string ToString()
		{

			if (_username==null)
			{
				if (_password==null)
				{
					return "";
				}
				return $":{_password}";

			}
			if (_password==null)
			{
				return $"{_username}";

			}
			return $"{_username}:{_password}";
		}

		static public Credential Parse(string txt)
		{
			var splitted = txt.Split(':');

			if (splitted.Length==1)
			{
				return new Credential(
					new Acc(splitted[0])
						
				);
			}
			if (splitted.Length==2)
			{
				return new Credential(
					new Acc(splitted[0])
					,
					new Key(splitted[1])	
				);
			}

			throw new Exception();



		}

	}
}
