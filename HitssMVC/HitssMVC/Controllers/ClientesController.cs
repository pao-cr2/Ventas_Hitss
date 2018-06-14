using HitssMVC.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitssMVC.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Cliente
        Service1Client cliente = new Service1Client();
        public ActionResult Index()
        {
            List<Cliente> list = cliente.GetClientes().ToList();
            ViewBag.List = list;
            
            return View(list);
        }
        
        public ActionResult InsertCliente()
        {

            return View();
        }
        [HttpPost]
        public ActionResult InsertCliente(Cliente cli)
        {
            cliente.InsertCliente(cli);
            return View();
        }

 
        public ActionResult GetClientesDelimitador()
        {

            return View();
        }
        public ActionResult UpdateCliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateCliente(Cliente pro)
        {
            Cliente cli = new Cliente();
            cliente.UpdateCliente(cli);
            return View();
        }
        [HttpPost]
        public ActionResult BuscarCliente()
        {

            return View();
        }
        public ActionResult BuscarCliente(int id)
        {
            List<Cliente> list = cliente.BuscarCliente(id).ToList();
            ViewBag.List = list;

            return View();
        }

        public ActionResult deleteCliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteCliente(int id)
        {
            cliente.deleteCliente(id);
            return View();
        }

    }
}

