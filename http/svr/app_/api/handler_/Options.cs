using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.web.svr.app_.api.handler_
{
	/// <summary>
	/// config.MessageHandlers.Add(new AllowOptionsHandler());
	/// </summary>
	public class AllowOptionsHandler : DelegatingHandler
	{
		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request
			,
			CancellationToken cancellationToken
		)
		{
			HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

			if (request.Method == HttpMethod.Options &&
				response.StatusCode == HttpStatusCode.MethodNotAllowed)
			{
				response = new HttpResponseMessage(HttpStatusCode.OK);
			}

			return response;
		}
	}



	/*

After encountering the same issue in a Web API 2 project (and being unable to use the standard CORS packages for reasons not worth going into here), I was able to resolve this by implementing a custom DelagatingHandler:
public class AllowOptionsHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);

        if (request.Method == HttpMethod.Options &&
            response.StatusCode == HttpStatusCode.MethodNotAllowed)
        {
            response = new HttpResponseMessage(HttpStatusCode.OK);
        }

        return response;
    }
}
For the Web API configuration:

config.MessageHandlers.Add(new AllowOptionsHandler());

Note that I also have the CORS headers enabled in Web.config, similar to some of the other answers posted here:
<system.webServer>
  <modules runAllManagedModulesForAllRequests="true">
    <remove name="WebDAVModule" />
  </modules>

  <httpProtocol>
    <customHeaders>
      <add name="Access-Control-Allow-Origin" value="*" />
      <add name="Access-Control-Allow-Headers" value="accept, cache-control, content-type, authorization" />
      <add name="Access-Control-Allow-Methods" value="GET, POST, PUT, DELETE, OPTIONS" />
    </customHeaders>
  </httpProtocol>

  <handlers>
    <remove name="ExtensionlessUrlHandler-Integrated-4.0" />
    <remove name="TRACEVerbHandler" />
    <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="*" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0" />
  </handlers>
</system.webServer>
Note that my project does not include MVC, only Web API 2.*/
}
