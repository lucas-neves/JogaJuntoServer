using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Web.Http;


namespace webApi
{
	public static class Startup
    {
        public static void Configuration(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
			//Remove formato XML.
			config.Formatters.Remove(config.Formatters.XmlFormatter);
			//Indenta Json
			config.Formatters.JsonFormatter.Indent = true;
        }
    }
}
