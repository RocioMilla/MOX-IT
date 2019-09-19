using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MOX_IT.Models;

namespace MOX_IT.Dao
{
    public static class VuelosDao
    {
        public static List<Vuelo> traerTodos()
        {
            VuelosEntities1 ctx = new VuelosEntities1();
            return ctx.Vuelo.ToList();
        }

        public static void guardarVuelo(VuelosForm vuelo)
        {
            using (var ctx = new VuelosEntities1())
            {
                using (var dbContextTransaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        Vuelo v = new Vuelo();
                        v.NumeroDeVuelo = vuelo.numeroDeVuelo;
                        v.HorarioLlegada = vuelo.horaLlegada;
                        v.Demorado = vuelo.demorado;
                        v.IDLineaAerea = vuelo.lineaAerea;
                        ctx.Vuelo.Add(v);
                        ctx.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        throw e;
                    }
                }
            }
        }

        public static void modificarVuelo(VuelosForm vuelo, int id)
        {
            using (var ctx = new VuelosEntities1())
            {
                using (var dbContextTransaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        Vuelo v = traerVueloPorID(id);
                        v.NumeroDeVuelo = vuelo.numeroDeVuelo;
                        v.HorarioLlegada = vuelo.horaLlegada;
                        v.Demorado = vuelo.demorado;
                        v.IDLineaAerea = vuelo.lineaAerea;
                        ctx.Vuelo.Add(v);
                        ctx.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        throw e;
                    }
                }
            }
        }

        public static Vuelo traerVueloPorID(int id)
        {
            VuelosEntities1 ctx = new VuelosEntities1();
            return ctx.Vuelo.Find(id);
        }
    }
}