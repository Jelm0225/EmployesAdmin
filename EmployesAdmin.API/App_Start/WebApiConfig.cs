using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace EmployesAdmin.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //Configuracion UTF-8 es requerida para que se pueda leer el json con todos los caracteres.
            Encoding oldDefault = Encoding.GetEncoding("utf-8");
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedEncodings.Clear();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedEncodings.Add(oldDefault);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
