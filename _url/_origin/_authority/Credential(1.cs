using nilnul.web._url._origin._authority._credential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority
{
	public class Credential1
	{

		//public const string REGEX = @"";
		private _url._origin._authority._credential.Acc _username;

		public _url._origin._authority._credential.Acc username
		{
			get { return _username; }
			set { _username = value; }
		}
		private _credential.Key _password;

		public _credential.Key password
		{
			get { return _password; }
			set { _password = value; }
		}

		public static implicit operator System.Net.NetworkCredential(Credential1 c) {
			return new System.Net.NetworkCredential(c.username, c.password);
		}


		public Credential1(_url._origin._authority._credential.Acc username=null, Key password=null)
		{
			_username = username;
			_password = password;
		}
		public Credential1(string username, string password):this(new _url._origin._authority._credential.Acc(username), new Key(password))
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

		static public Credential1 Parse(string txt)
		{
			var splitted = txt.Split(':');

			if (splitted.Length==1)
			{
				return new Credential1(
					new Acc(splitted[0])
					//,
					//null	
				);
			}
			if (splitted.Length==2)
			{
				return new Credential1(
					new Acc(splitted[0])
					,
					new Key(splitted[1])	
				);
			}

			throw new nilnul.exception_.ParseException();



		}

	}
}
