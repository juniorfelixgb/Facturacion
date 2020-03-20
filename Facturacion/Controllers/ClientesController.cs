using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facturacion.Models.ViewModel;
using Facturacion.Data.Repository;

namespace Facturacion.Controllers
{
    public class ClientesController : Controller
    {
        
        // GET: Clientes
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetList()
        {
            FacturacionDbContext DbContext;
            return View();
        }
    }
}