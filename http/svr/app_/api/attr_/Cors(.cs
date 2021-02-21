using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace nilnul.web.svr.app_.api.attr_
{
	/*
		Custom CORS Policy Attribute One approach to enable a dynamic CORS policy is to develop a custom attribute class that can generate the policy from some data source.This custom attribute class can be used instead of the EnableCorsAttribute class provided by Web API.This approach is simple and retains the fine-grained feel of being able to apply an attribute on specific classes and methods(and not apply it on others), as needed.
To implement this approach, you simply build a custom attribute similar to the existing EnableCorsAttribute class. The main focus is the ICorsPolicyProvider interface, which is responsible for creating an instance of a CorsPolicy for any given request.Figure 5 contains an example.
Figure 5 A Custom CORS Policy Attribute
*/

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
			AllowMultiple = false)]
	public class EnableCorsForPaidCustomersAttribute :
  Attribute, ICorsPolicyProvider
	{
		public async Task<CorsPolicy> GetCorsPolicyAsync(
		  HttpRequestMessage request, CancellationToken cancellationToken)
		{
			CorsRequestContext corsRequestContext = request.GetCorsRequestContext();
			string originRequested = corsRequestContext.Origin;
			if (await IsOriginFromAPaidCustomer(originRequested))
			{
				// Grant CORS request
				CorsPolicy policy = new CorsPolicy
				{
					AllowAnyHeader = true,
					AllowAnyMethod = true,
				};
				policy.Origins.Add(originRequested);
				return policy;
			}
			else
			{
				// Reject CORS request
				return null;
			}
		}
		private async Task<bool> IsOriginFromAPaidCustomer(
		  string originRequested)
		{
			// Do database look up here to determine if origin should be allowed
			return true;
		}
	}
}
