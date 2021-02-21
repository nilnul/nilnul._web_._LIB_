﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;

namespace nilnul.web.svr.app_.api.controller.action.io.binding_
{
	/// <summary>
	/// Reads the Request body into a string/byte[] and
	/// assigns it to the parameter bound.
	/// 
	/// Should only be used with a single parameter on
	/// a Web API method using the [NakedBody] attribute
	/// </summary>
	public class NakedBodyParameterBinding : HttpParameterBinding
	{
		public NakedBodyParameterBinding(HttpParameterDescriptor descriptor)
			: base(descriptor)
		{

		}


		public override Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider,
													HttpActionContext actionContext,
													CancellationToken cancellationToken)
		{
			var binding = actionContext
				.ActionDescriptor
				.ActionBinding;

			if (binding.ParameterBindings.Length > 1 ||
				actionContext.Request.Method == HttpMethod.Get)
				return _nakedBody.task_._EmptyX.Start();

			var type = binding
						.ParameterBindings[0]
						.Descriptor.ParameterType;

			if (type == typeof(string))
			{
				return actionContext.Request.Content
						.ReadAsStringAsync()
						.ContinueWith((task) =>
						{
							var stringResult = task.Result;
							SetValue(actionContext, stringResult);
						});
			}
			else if (type == typeof(byte[]))
			{
				return actionContext.Request.Content
					.ReadAsByteArrayAsync()
					.ContinueWith((task) =>
					{
						byte[] result = task.Result;
						SetValue(actionContext, result);
					});
			}

			throw new InvalidOperationException("Only string and byte[] are supported for [NakedBody] parameters");
		}

		public override bool WillReadBody
		{
			get
			{
				return true;
			}
		}
	}
}
