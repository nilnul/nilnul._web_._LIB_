using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._url._origin._authority
{
	[Obsolete()]
	public class Credential
	{
		private Username _username;

		public Username username
		{
			get { return _username; }
			set { _username = value; }
		}
		private Password _password;

		public Password password
		{
			get { return _password; }
			set { _password = value; }
		}

		public Credential(Username username, Password password)
		{
			_username = username;
			_password = password;
		}
		public Credential(string username, string password):this(new Username(username), new Password(username))
		{

		}

		public override string ToString()
		{
			return $"{_username}:{_password}";
		}

		static public Credential Parse(string txt)
		{
			var splitted = txt.Split(':');

			if (splitted.Length==1)
			{
				return new Credential(
					new Username(splitted[0])
					,
					null	
				);
			}
			if (splitted.Length==2)
			{
				return new Credential(
					new Username(splitted[0])
					,
					new Password(splitted[1])	
				);
			}

			throw new Exception();



		}

	}
}
