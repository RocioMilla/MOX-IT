using MOX_IT.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOX_IT.Servicios
{
    public static class ServicioLineasAereas
    {
        public static List<LineaAerea> obtenerTodas()
        {
            return LineasAereasDao.traerTodas();
        }
    }
}