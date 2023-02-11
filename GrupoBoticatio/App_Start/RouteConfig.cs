using System.Web.Mvc;
using System.Web.Routing;

namespace GrupoBoticatio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Repository", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RepositoryEdit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Repository", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RepositoryItem",
                url: "{controller}/{action}/{language}/{Id}",
                defaults: new { controller = "RepositoryItem", action = "Index", language = UrlParameter.Optional, Id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "About",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "About", action = "Edit", id = UrlParameter.Optional }
            );
        }


    }
}
