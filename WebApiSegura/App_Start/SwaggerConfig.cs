using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;
using WebApiSegura;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApiSegura
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c => { c.SingleApiVersion("v1", "WebApiSegura"); })
                .EnableSwaggerUi(c => { });
        }
    }
}
