[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SBAdminMVC.App_Start.Combres), "PreStart")]
namespace SBAdminMVC.App_Start {
	using System.Web.Routing;
	using global::Combres;
	
    public static class Combres {
        public static void PreStart() {
            RouteTable.Routes.AddCombresRoute("Combres");
        }
    }
}