using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace nilnul.web.svr.app_.api.cors
{
	/*
	  https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
		The attribute-based approach described earlier provides an implicit association from a request to a policy. A custom policy provider factory approach is different from the attribute approach because it requires your implementation to provide the logic to match the incoming request to a policy. This approach is more coarse-grained, as it’s essentially a centralized approach for obtaining a CORS policy.
Figure 6 shows an example of what a custom policy provider factory might look like.The main focus in this example is the implementation of the ICorsPolicyProviderFactory interface and its GetCorsPolicyProvider method.
Figure 6 A Custom Policy Provider Factory
*/

	public class DynamicPolicyProviderFactory : ICorsPolicyProviderFactory
	{
		public ICorsPolicyProvider GetCorsPolicyProvider(
		  HttpRequestMessage request)
		{
			System.Web.Http.Routing.IHttpRouteData route = request.GetRouteData();
			string controller = (string)route.Values["controller"];
			CorsRequestContext corsRequestContext = request.GetCorsRequestContext();
			string originRequested = corsRequestContext.Origin;
			CorsPolicy policy = GetPolicyForControllerAndOrigin(
				  controller, originRequested);
			return new CustomPolicyProvider(policy);
		}
		private CorsPolicy GetPolicyForControllerAndOrigin(
		 string controller, string originRequested)
		{
			// Do database lookup to determine if the controller is allowed for
			// the origin and create CorsPolicy if it is (otherwise return null)
			CorsPolicy policy = new CorsPolicy();
			policy.Origins.Add(originRequested);
			policy.Methods.Add("GET");
			return policy;
		}
	}
	public class CustomPolicyProvider : ICorsPolicyProvider
	{
		private CorsPolicy policy;
		public CustomPolicyProvider(CorsPolicy policy)
		{
			this.policy = policy;
		}
		public Task<CorsPolicy> GetCorsPolicyAsync(
		  HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return Task.FromResult(this.policy);
		}
	}
	/*
		The main difference in this approach is that it’s entirely up to the implementation to determine the policy from the incoming request.In Figure 6, the controller and origin could be used to query a database for the policy values.Again, this approach is the most flexible, but it potentially requires more work to determine the policy from the request.
		To use the custom policy provider factory, you must register it with Web API via the SetCorsPolicyProviderFactory extension method in the Web API configuration:

public static class WebApiConfig
		{
			public static void Register(HttpConfiguration config)
			{
				// Other configuration omitted
				config.EnableCors();
				config.SetCorsPolicyProviderFactory(
				  new DynamicPolicyProviderFactory());
			}
		}
		*/
}
