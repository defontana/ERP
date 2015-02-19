using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using log4net;
using log4net.Config;
using ERP.Utilities.Log;

namespace ERP.Presentation
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        //protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(Object sender, System.EventArgs e)
        {
            //Registramos errores de Aplicaciones en el Log4net.
            HttpContext context = HttpContext.Current;
            Exception ex = Server.GetLastError();
            ErrorCatch.Save(ex);



                
            //Log.Error(ex);

            

        }
    }
}