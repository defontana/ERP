using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace ERP.Presentation.Helpers
{
    public class BaseController : Controller
    {
        // GET: Base
        public IContextService _ContextFactory = null;

        public BaseController()
        {
            _ContextFactory = (IContextService)ContextFactory.ApplicationContext["Presenter"];
        }

        #region Log4net
           /// <summary>
           /// Instancia de logger interno utilizado
           /// </summary>
           protected static readonly ILog logger = LogManager.GetLogger(
               System.Reflection.MethodBase.GetCurrentMethod().DeclaringType
           );

        
        #endregion
    }
}