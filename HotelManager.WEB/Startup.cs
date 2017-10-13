using HotelManager.API;
using HotelManager.API.Service;
using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Swashbuckle.Application;
using System.Web.Http;

[assembly: OwinStartup(typeof(HotelManagerApi.Startup))]

namespace HotelManagerApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configuration et services API Web

            HttpConfiguration httpConfig = new HttpConfiguration();

            // Itinéraires de l'API Web
            httpConfig.MapHttpAttributeRoutes();

            //httpConfig.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            Container container = new Container();
            container.Register<IRoomService, RoomService>(Lifestyle.Singleton);

            httpConfig.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            httpConfig
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Hotel room manager");
                    c.PrettyPrint();
                })
                .EnableSwaggerUi();

            httpConfig.Routes.MapHttpRoute(
                name: "",
                routeTemplate: "",
                defaults: null,
                handler: new RedirectHandler(SwaggerDocsConfig.DefaultRootUrlResolver, "swagger/ui/index"),
                constraints: null
            );

            app.UseWebApi(httpConfig);
        }
    }
}
