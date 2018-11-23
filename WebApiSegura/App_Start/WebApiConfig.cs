namespace WebApiSegura
{
    using System.Web.Http;

    /// <summary>
    /// Clase que define el código de configuración de la API 
    /// </summary>
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            /// Validamos el tokens para solicitudes utilizando un DelegatingHandler
            config.MessageHandlers.Add(new Controllers.Token.TokenValidationHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
