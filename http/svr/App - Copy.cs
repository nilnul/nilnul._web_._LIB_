using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace nilnul.web.svr
{
	/// <summary>
	/// implemented GetVaryByCustomString of "l", which is the linguistics parameter submitted by browser. Session is not enabled/disabled here
	/// </summary>
	///
	[Obsolete(nameof(nilnul.web.http.svr.App))]
	public class App : System.Web.HttpApplication
	{
		public override string GetVaryByCustomString(HttpContext context,
string arg)
		{
			if (arg == null)
			{
				return base.GetVaryByCustomString(context, arg);

			}
			if (arg.ToLower() == "l")
			{

				return nilnul.web.svr.module_.ling_.enCn_.BySessionX.UserPreferChinese(context).ToString();// context.Request.Cookies["l"] == null ? "" : context.Request.Cookies["l"].Value;
			}
			return base.GetVaryByCustomString(context, arg);
		}

		//public static IHttpModule ModuleEnableSession = new http.svr.app.module_.EnableSession();

		//public override void Init()
		//{
		//	base.Init();
		//	ModuleEnableSession.Init(this);
		//}



	}
}
