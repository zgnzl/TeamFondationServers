using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace weige
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public override void Init() {

            this.PreSendRequestContent += PreSendRequest;
           // this.RequestCompleted += PreSendRequest;
        }
        private void PreSendRequest(object e, System.EventArgs arg)
        {
            string[] VAL = Request.Headers.GetValues("X-Forwarded-For");
            Request.Headers.Set("X-Forwarded-For", "127.0.0.1");
            Request.Headers.Set("User-Agent", "127.0.0.1");
            string[] VAL1 = Request.Headers.GetValues("X-Forwarded-For");
        }
    }
}
