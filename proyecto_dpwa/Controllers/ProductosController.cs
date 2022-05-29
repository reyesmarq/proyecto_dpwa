using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace proyecto_dpwa.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categorias()
        {
            return View();
        }
    }
}