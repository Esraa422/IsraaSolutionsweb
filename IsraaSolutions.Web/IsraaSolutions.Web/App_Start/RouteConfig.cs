using IsraaApp.WebMVC.Framework.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace IsraaApp.WebMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("robots.txt");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { controller = "Page", action = "About" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { controller = "Page", action = "Contact" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Jobs",
                url: "Jobs",
                defaults: new { controller = "Page", action = "Jobs" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Team",
                url: "Team",
                defaults: new { controller = "Page", action = "Team" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Project",
                url: "Projects",
                defaults: new { controller = "Page", action = "Project" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Search",
                url: "Search/{term}",
                defaults: new { controller = "Page", action = "Search" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "User",
                url: "User/{username}",
                defaults: new { controller = "User", action = "Index" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            /* Generic Route for Categories & Posts */
            routes.MapGenericPathRoute(
                name: "Slug",
                url: "{SeName}",
                defaults: new { controller = "Home", action = "NotFound" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });
            /* Generic Route for Categories & Posts */


            routes.MapGenericPathRoute(
                name: "PortfolioItem",
                url: "portfolio-item/{PortfolioItem}",
                defaults: new { controller = "Home", action = "NotFound" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapGenericPathRoute(
                name: "JobDetail",
                url: "job-detail/{JobDetail}",
                defaults: new { controller = "Home", action = "NotFound" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapGenericPathRoute(
                name: "PortfolioCategory",
                url: "portfolio-category/{PortfolioCategory}",
                defaults: new { controller = "Home", action = "NotFound" },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "IsraaApp.WebMVC.Controllers" });
        }
    }
}