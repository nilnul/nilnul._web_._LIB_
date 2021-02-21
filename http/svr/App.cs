using nilnul.obj.seq.be_;
using nilnul.web.http.svr._app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;
/// below it seems this decorate the webApp where this dll is embedded
//[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]

namespace nilnul.web.http.svr
{
	namespace _app
	{
		public class PreApp
		{
			public static void Start()
			{
				/// if the type is alread registered, the exception is thrown.
				/// if this is registered, and later the IIS defaulted Session is added, excetion is thrown ---we met such exception. don't count on this as this will not have any effect.
				if (HttpContext.Current is null)
				{
					try
					{
						HttpApplication.RegisterModule(
															typeof(System.Web.SessionState.SessionStateModule)
													);
					}
					catch (Exception)
					{

						//  ;
					}

					return;
				}
				if (HttpContext.Current.ApplicationInstance.Modules.AllKeys.None(x => x == "Session"))
				{
					try
					{
						HttpApplication.RegisterModule(
																typeof(System.Web.SessionState.SessionStateModule)
														);
					}
					catch (Exception)
					{


					}


				}

				// Your startup code here

			}
		}

	}

	/// <summary>
	/// implemented GetVaryByCustomString of "l", which is the linguistics parameter submitted by browser.
	/// session module is ensured.
	/// and session is enabled.
	/// and moduleLing is hookied
	/// and cors is enabled.
	/// </summary>
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

		public static IHttpModule ModuleEnableSession = new http.svr.app.module_.EnableSession();

		public static IHttpModule ModuleLing = new nilnul.web.http.svr.app.module_.ling_.enCn_.BySession();

		public static IHttpModule ModuleCors = new nilnul.web.http.svr.app.module_.Cors();

		public override void Init()
		{

			//DynamicModuleUtility
			base.Init();
			//RegisterModule
			//RegisterModule(typeof(http.svr.app.module_.EnableSession));
			//ensureSession();
			ModuleEnableSession.Init(this);
			ModuleLing.Init(this);
			ModuleCors.Init(this);

			if (Modules.AllKeys.None(x => x == "Session"))
			{

				new System.Web.SessionState.SessionStateModule().Init(this);

			}

			/*ISessionIDModule idModule;
			HttpApplication app = HttpContext.Current.ApplicationInstance;
			idModule = SessionStateUtility.GetSessionIDModule(app);
			*/

		}

		void ensureSession()
		{
			//var s = new System.Web.SessionState.SessionStateModule();


			//inisde the sessionStateMoudule's Init, a SessionIdManager is new-ed and assigned to property; the property may be private. So we cannot replace it.

			/*ISessionIDModule idModule;
			HttpApplication app = Httpcontext.Current.ApplicationInstance;
			idModule = SessionStateUtility.GetSessionIDModule(app);
			*/

			if (this.Modules.AllKeys.None(x => x == "Session"))
			{

				///below will throw excetion: Register must happen before ApplicationInitialization.
				RegisterModule(
					typeof(System.Web.SessionState.SessionStateModule)
				);
				//DynamicModuleUtility

			}


		}


	}
}

/*In ASP.NET 4, we added the concept of a PreApplicationStart method that an assembly can use to execute code early on in the appdomain without any configuration. Phil Haack covered it a while back in this post. It’s pretty simple to use. You just define a class that looks like:

public class PreApplicationStartCode {
    public static void Start() {
        // Your startup code here
    }
}
And then you add an assembly level attribute pointing to it:

[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]
With the release of MVC3 and ASP.NET Web Pages, we added another little gem: a RegisterModule() API that lets you dynamically register an IHttpModule without touching config. Sadly, the method is hidden so deep that it is hard to find by accident (it’ll get cleaned up in the next framework version).

By combining the two techniques, you have everything you need to register a module dynamically, e.g.

public class PreApplicationStartCode {
    public static void Start() {
        // Register our module
        Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(MyModule));
    }
}
I warned you it was well hidden! :)

Update: in recent versions of the framework, the method is much easier to find. Just call HttpApplication.RegisterModule.

The module type that you pass in to that is just a standard IHttpModule, e.g. here is a basic module that writes to the response on every request:

class MyModule : IHttpModule {
    public void Init(HttpApplication context) {
        context.BeginRequest += (sender, e) => {
            var response = ((HttpApplication)sender).Response;
            response.Write("MyModule.BeginRequest");
        };
    }

    public void Dispose() { }
}
The beauty of this is that it allows you to create fully encapsulated assemblies that you can just drop into a web app’s bin folder and have them light up without having to add any ugly registration to the app.

And yes, all this works fine in partial trust!*/



/*[assembly: PreApplicationStartMethod(typeof(MyNamespace.PreApplicationStartCode), "Start")]
When the application starts, the System.Web.Hosting.HostingEnvironment.Intialize() method calls System.Web.Compilation.BuildManager.CallPreStartInitMethods() (all of that is internal, of course) and magic happens - your application startup logic runs.*/



/*using Microsoft.Web.Infrastructure.DynamicModuleHelper;

[assembly:PreApplicationStartMethod(typeof(MyAppStart), "Start")]

public class CoolModule : IHttpModule
{
    // implementation not important 
    // imagine something cool here
}

public static class MyAppStart
{
    public static void Start()
    {
        DynamicModuleUtility.RegisterModule(typeof(CoolModule));
    }
}*/
