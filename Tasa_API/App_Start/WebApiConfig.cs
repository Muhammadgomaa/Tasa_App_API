using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Tasa_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Remove XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //Circular Exception (Self Reference Loop)
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
