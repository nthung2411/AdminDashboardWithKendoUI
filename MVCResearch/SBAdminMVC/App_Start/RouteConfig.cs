using System.Web.Mvc;
using System.Web.Routing;

namespace SBAdminMVC
{
    public class RouteConfig
    {
        public static void RegisterRoute(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/*pathInfo");
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Dashboard", id = UrlParameter.Optional});
        }
    }
}