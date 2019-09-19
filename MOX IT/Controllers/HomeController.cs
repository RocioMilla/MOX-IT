using MOX_IT.Models;
using MOX_IT.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOX_IT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vuelos()
        {
            ViewBag.vuelos = ServicioVuelos.obtenerTodos();
            return View();
        }

        [ActionName("crear-vuelo")]
        public ActionResult AltaVuelo()
        {
            ViewBag.lineasAereas = ServicioLineasAereas.obtenerTodas();
            return View();
        }

        [HttpPost]
        public ActionResult AltaVuelo(VuelosForm vuelo)
        {
            if (ModelState.IsValid)
            {
                ServicioVuelos.crearVuelo(vuelo);
                TempData["respuesta"] = "Vuelo creado satisfactoriamente.";
                return Redirect("Vuelos");
            }
            else {
                TempData["error"] = "Vuelo creado satisfactoriamente.";
                return Redirect("crear-vuelo");
            }
        }

        public ActionResult ModificarVuelo(int id)
        {
            ViewBag.vuelo = ServicioVuelos.obtenerVueloPorID(id);
            return View();
        }

        [HttpPost]
        public ActionResult ModificarVuelo(VuelosForm vuelo, int id)
        {
            if (ModelState.IsValid)
            {
                ServicioVuelos.modificarVuelo(vuelo, id);
                TempData["respuesta"] = "Vuelo modificado satisfactoriamente.";
                return Redirect("Vuelos");
            }
            else {
                return Redirect("ModificarVuelo");
            }
        }

    }
}