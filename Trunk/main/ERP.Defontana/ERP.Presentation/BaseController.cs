//using ERP.Utilities.Log.Support;
using ERP.Utilities;
using ERP.Services;
using ERP.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Microsoft.Practices.Unity;

namespace ERP.Presentation
{
    //Clase Principal de controlador, 
    //donde pondremos las implementaciones transversales a la 
    //presentación

    public class BaseController : Controller
    {
       public IErrorCatch _error;
       public IClientDAO _DAOCliente;
       public IClientServices _ServiceCliente;

       public BaseController()
       {
           _init();
       }

        private void _init()
        {
            IUnityContainer container = ERP.Presentation.App_Start.UnityConfig.GetConfiguredContainer();
            
            //Inicializamos las dependencias
            _error = container.Resolve<IErrorCatch>();
            _ServiceCliente = container.Resolve<IClientServices>();
            //_DAOCliente = container.Resolve<IClientDAO>();  
        }
        
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }

   
}