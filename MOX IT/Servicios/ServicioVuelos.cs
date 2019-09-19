using MOX_IT.Dao;
using MOX_IT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOX_IT.Servicios
{
    public static class ServicioVuelos
    {
        public static List<Vuelo> obtenerTodos()
        {
            return VuelosDao.traerTodos();
        }

        public static void crearVuelo(VuelosForm vuelo)
        {
            VuelosDao.guardarVuelo(vuelo);
        }

        public static Vuelo obtenerVueloPorID(int id)
        {
            return VuelosDao.traerVueloPorID(id);
        }

        public static void modificarVuelo(VuelosForm vuelo, int id)
        {
            VuelosDao.modificarVuelo(vuelo, id);
        }
    }
}