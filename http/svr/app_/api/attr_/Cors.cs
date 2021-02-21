using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.web.svr.app_.api.attr_
{

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
	public class CorsPolicyAttribute : Attribute, ICorsPolicyProvider
	{
		const string Origin = "Origin";
		private CorsPolicy _policy;

		public CorsPolicyAttribute()
		{
			// Create a CORS policy.
			_policy = new CorsPolicy
			{
				AllowAnyMethod = true,
				AllowAnyHeader = true
			};

			// Add allowed origins.
			_policy.Origins.Add("http://myclient.azurewebsites.net");
			_policy.Origins.Add("http://www.contoso.com");
		}

		//public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request)
		//{
		//	return Task.FromResult(_policy);
		//}

		public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var _policy = new CorsPolicy
			{
				AllowAnyMethod = true,
				AllowAnyHeader = true
			};

			var h = request.Headers.FirstOrDefault(x => nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x, Origin));
			// Add allowed origins.
			if ()
			{

			}
			_policy.Origins.Add(request.Headers.Where(nilnul.txt.eq_.CaseInsensitive x=>x.Key....e["Origin"]);
			_policy.Origins.Add("http://www.contoso.com");
			return Task.FromResult(_policy);
		}
	}
}
