using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitssMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        /*
        public ActionResult Index()
        {
            
            VentaNeg objVentaNeg = new VentaNeg();
            List<Venta> lista = objVentaNeg.findAll();
            return View(lista);
        }*/
    }
}