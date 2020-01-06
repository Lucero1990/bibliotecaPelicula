using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWebMVC5.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bienvenido(string nombre, int ID=1)
        {
            ViewBag.Mensaje = "Hola" + nombre + "!";
            ViewBag.NumVeces = ID;
            return View();
        }
    }
}