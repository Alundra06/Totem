﻿using System;
using System.Collections.Generic;
using System.Linq;
using Totem.Http;

namespace Totem.Runtime
{
	/// <summary>
	/// A call to a Totem web API
	/// </summary>
	public class WebApiCall
	{
		public WebApiCall(HttpLink link, HttpAuthorization authorization, WebApiCallBody body, IViewDb views)
		{
			Link = link;
			Authorization = authorization;
			Body = body;
			Views = views;
		}

		public readonly HttpLink Link;
		public readonly HttpAuthorization Authorization;
		public readonly WebApiCallBody Body;
		public readonly IViewDb Views;

		public override string ToString()
		{
			return Link.ToString();
		}
	}
}