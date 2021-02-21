using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.svr.module_._pass
{
	public class Identity : IIdentity
	{
		public string AuthenticationType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool IsAuthenticated
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public string Name
		{
			get
			{

				throw new NotImplementedException();
			}
		}
	}
}
