using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace nilnul.web.svr.app_.api.attr_
{
	/// <summary>
	/// An attribute that captures the entire content body and stores it
	/// into the parameter of type string or byte[].
	/// </summary>
	/// <remarks>
	/// The parameter marked up with this attribute should be the only parameter as it reads the
	/// entire request body and assigns it to that parameter.    
	/// </remarks>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class NakedBodyAttribute : ParameterBindingAttribute
	{
		public override HttpParameterBinding GetBinding(HttpParameterDescriptor parameter)
		{
			if (parameter == null)
				throw new ArgumentException("Invalid parameter");

			return new controller.action.io.binding_.NakedBodyParameterBinding(parameter);
		}
	}
	/*To use the attribute is pretty easy. Simply create a method with a single string or byte[] parameter and mark it up with the [NakedBody] attribute:
[HttpPost]
public string PostRawBuffer([NakedBody] string raw)
{
    return raw;
}

[HttpPost]
public string PostBinaryBuffer([NakedBody] byte[] raw)
{
    return raw.Length + " bytes sent";
}*/
}
