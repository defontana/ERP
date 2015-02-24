using ERP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.DTO;

namespace ERP.Presentation.Controllers
{
    public class HomeController : BaseController
    {

      /*
        public HomeController(IErrorCatch error)
        {
            //this._error = error;
        }
       */

        public ActionResult Index()
        {
            _error.Save(new Exception("Llamando desde presentación"));
            
            //llamamos una capa interna de servicio.-
            string result = _ServiceCliente.loginCliente("Capa Presentación");

            SimpleTO model = new SimpleTO();
            model.description = result;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}