namespace nilnul.web.svr.module_._acc_.authenticate_
{
	using System;
	using System.Net.Http.Headers;
	using System.Security.Principal;
	using System.Threading;
	using System.Web;
	public class Bearer
		 : IHttpModule
	{
		private const string Realm = nilnul.acc.http.response.header.field_.WWW_Authenticate.Value_.Basic.Realm;

		public void Init(HttpApplication context)
		{
			// Register event handlers
			context.AuthenticateRequest += OnApplicationAuthenticateRequest;
			context.EndRequest += OnApplicationEndRequest;
		}

		private static void SetPrincipal(IPrincipal principal)
		{
			Thread.CurrentPrincipal = principal;
			if (HttpContext.Current != null)
			{
				HttpContext.Current.User = principal;
			}
		}

		public static void SetPrincipal(long login)
		{

			SetPrincipal(
				new _authenticate.Principal(

					login
				)

			);


		}





		public static void AuthenticateToken(string sid)
		{

			Guid guid;
			bool tried = Guid.TryParse(sid, out guid);

			if (tried)
			{
				AuthenticateToken(guid);


			}
			else
			{

			}

		}

		public static void AuthenticateToken(Guid sid)
		{


			var data = nilnul.pass_.login.Sid4NickLoginAcc.Exe(sid);

			if (data.login != null)
			{
				SetPrincipal(data.login.Value);
			}



		}

		private static void OnApplicationAuthenticateRequest(object sender, EventArgs e)
		{
			HttpRequest request = HttpContext.Current.Request;
			string authHeader = request.Headers[nilnul.pass.http.request.header.Keys.Authorization];
			if (authHeader != null)
			{
				AuthenticationHeaderValue authHeaderVal = AuthenticationHeaderValue.Parse(authHeader);

				if (authHeaderVal.Scheme.Equals(
					   "Bearer",
					   StringComparison.OrdinalIgnoreCase) &&
				   authHeaderVal.Parameter != null

			   )
				{

					AuthenticateToken(authHeaderVal.Parameter);



				}



			}
		}

		// If the request was unauthorized, add the WWW-Authenticate header 
		// to the response.
		private static void OnApplicationEndRequest(object sender, EventArgs e)
		{
			HttpResponse response = HttpContext.Current.Response;
			if (response.StatusCode == 401)
			{
				response.Headers.Add("WWW-Authenticate",
					string.Format("Basic realm=\"{0}\"", Realm));
			}
		}

		public void Dispose()
		{
		}
	}
}