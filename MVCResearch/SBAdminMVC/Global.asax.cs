using System;
using System.Web.Routing;

namespace SBAdminMVC
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoute(RouteTable.Routes);
        }
    }
}