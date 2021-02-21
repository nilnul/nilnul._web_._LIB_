using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.svr.module_._pass
{
	public class Principal : IPrincipal
	{
		public IIdentity Identity
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool IsInRole(string role)
		{
			throw new NotImplementedException();
		}
	}
}
