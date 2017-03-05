using BookSearchApp.Data.Services;
using BookSearchApp.DI;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace BookSearchApp
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			var container = new UnityContainer();
			container.RegisterType<IBookService, BookXMLService>(new HierarchicalLifetimeManager());
			config.DependencyResolver = new UnityResolver(container);

			config.MapHttpAttributeRoutes();

			config.Formatters.JsonFormatter.SupportedMediaTypes
				.Add(new MediaTypeHeaderValue("text/html"));
		}
	}
}
