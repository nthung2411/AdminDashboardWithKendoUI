using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoUIBootstrap.Startup))]
namespace KendoUIBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
