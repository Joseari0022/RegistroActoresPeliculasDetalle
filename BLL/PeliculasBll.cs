using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class PeliculasBll
    {
        public static bool Guardar(Peliculas pl)
        {
            bool re = false;
            try
            {
                var db = new SistemaPeliculasDb();

                db.Peliculas.Add(pl);
                var p = db.Peliculas.Add(pl);
                foreach (var acto in pl.Actores)
                {
                    db.Entry(acto).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }

        public static Peliculas Buscar(int id)
        {
            Peliculas pelicula = new Peliculas();
            var db = new SistemaPeliculasDb();
            return pelicula = db.Peliculas.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new SistemaPeliculasDb();
            Peliculas gr = db.Peliculas.Find(id);

            db.Peliculas.Remove(gr);
            db.SaveChanges();
        }

        public static List<Peliculas> GetLista()
        {
            var lista = new List<Peliculas>();
            var db = new SistemaPeliculasDb();
            lista = db.Peliculas.ToList();
            return lista;
        }

        public static List<Peliculas> GetListaNombre(string aux)
        {
            List<Peliculas> lista = new List<Peliculas>();
            var db = new SistemaPeliculasDb();
            lista = db.Peliculas.Where(p => p.Nombres == aux).ToList();
            return lista;
        }
    }
}
