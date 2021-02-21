using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web._credential
{
	public struct Slots
	{
		public string username;
		public string password;

		public Slots(
			string username
			,
			string password	
		)
		{
			this.username = username;
			this.password = password;

		}
	}
}
