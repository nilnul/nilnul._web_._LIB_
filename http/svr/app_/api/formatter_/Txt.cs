using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.web.svr.app_.api.formatter_
{
	public class PlainTextFormatter : MediaTypeFormatter
	{
		public PlainTextFormatter()
		{
			SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
		}

		public override bool CanReadType(Type type)
		{
			return type == typeof(string);
		}

		public override bool CanWriteType(Type type)
		{
			return type == typeof(string);
		}

		public override async Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
		{
			StreamReader streamReader = new StreamReader(readStream);
			return await streamReader.ReadToEndAsync();
		}

		public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext, CancellationToken cancellationToken)
		{
			StreamWriter streamReader = new StreamWriter(writeStream);
			await streamReader.WriteAsync((string)value);
		}
	}
	//Please note I intentionally do not dispose StreamReader/StreamWriter, as this will dispose underlying streams and break Web Api flow.
	//		//To make use of it, register while building HttpConfiguration:
	//protected HttpConfiguration CreateHttpConfiguration()
	//		{
	//			HttpConfiguration httpConfiguration = new HttpConfiguration();
	//    ...
	//    httpConfiguration.Formatters.Add(new PlainTextFormatter());
	//    ...
	//    return httpConfiguration;
	//		}
}
