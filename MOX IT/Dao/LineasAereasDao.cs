using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOX_IT.Dao
{
    public static class LineasAereasDao
    {
        public static List<LineaAerea> traerTodas()
        {
            var ctx = new VuelosEntities1();
            return ctx.LineaAerea.ToList();
        }
    }
}