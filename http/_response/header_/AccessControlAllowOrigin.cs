using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.response.header_
{
	class AccessControlAllowOrigin
	{
		/*
		Access-Control-Allow-Origin: *
		 
		 */


		/*
		 I have found the answer for my question. Just add the following to your web.config file

<system.webServer>
    <httpProtocol>
        <customHeaders>
            <add name="Access-Control-Allow-Origin" value="*"/>
            <add name="Access-Control-Allow-Headers" value="Origin, X-Requested-With, Content-Type, Accept" />
        </customHeaders>
    </httpProtocol>
</system.webServer>
Also if you dont want it to be set up globally, then you can add it to your action method alone as below:

[WebMethod]
public string HelloWorld()
{
    HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
    return "Hell
		 */
	}
}
