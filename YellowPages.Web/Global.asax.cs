using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace YellowPages.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            /************************************************************/
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new YellowPagesViewEngine());
            /************************************************************/
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}