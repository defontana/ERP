using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using log4net.Config;

namespace ERP.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Log.Info("--Start Aplication--");
        }

        protected void Application_Error(Object sender, System.EventArgs e)
        {
            //Registramos errores de Aplicaciones en el Log4net.
            HttpContext context = HttpContext.Current;
            Exception ex = Server.GetLastError();
            ERP.Utilities.Log.ErrorCatch.Save(ex);



            //Log.Error(ex);



        }
    }
}
