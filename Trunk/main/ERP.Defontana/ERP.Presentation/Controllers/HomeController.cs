using ERP.DTO;
using ERP.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ERP.Presentation.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            
            SimpleTO usuario = new SimpleTO();

            usuario.name = _ContextFactory.loginUser("Capa Presentacion");

            logger.DebugFormat("resultado Inyeccion : {0}",usuario.name);
            
            return View(usuario);
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