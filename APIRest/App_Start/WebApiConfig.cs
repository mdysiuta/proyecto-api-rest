using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

// (!) hay que importar cors para que funcione
using System.Web.Http.Cors;

namespace APIRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API

            // (!) enablecorsattribute recibe 3 parametros: dominio de donde consumir, tipo de dato q se puede pasar, metodos habilitados (post get delete etc)
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
