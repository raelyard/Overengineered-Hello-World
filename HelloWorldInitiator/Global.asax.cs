using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NServiceBus;
using NServiceBus.Logging;

namespace HelloWorldInitiator
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static ISendOnlyBus Bus { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SetupNServiceBus();
        }

        private void SetupNServiceBus()
        {
            LogManager.Use<DefaultFactory>().Level(LogLevel.Error);
            var busConfiguration = new BusConfiguration();
            Bus = NServiceBus.Bus.CreateSendOnly(busConfiguration);
        }
    }
}
