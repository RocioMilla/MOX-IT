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
                return Redirect("~/Home/Vuelos");
            }
            else {
                TempData["error"] = "Datos incorrectos.";
                return Redirect("~/Home/crear-vuelo");
            }
        }

        [ActionName("editar-vuelo")]
        public ActionResult ModificarVuelo(int id)
        {
            ViewBag.lineasAereas = ServicioLineasAereas.obtenerTodas();
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
                return Redirect("~/Home/Vuelos");
            }
            else {
                return Redirect("~/Home/ModificarVuelo");
            }
        }

        [HttpPost]
        public ActionResult eliminarVuelo(int id)
        {
            ServicioVuelos.eliminar(id);
            TempData["respuesta"] = $"Se eliminó el vuelo correctamente.";
            return Redirect("~/Home/Vuelos");
        }
    }
}