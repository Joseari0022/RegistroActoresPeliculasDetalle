using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class ActoresBll
    {
        public static bool Guardar(Actores act)
        {
            bool re = false;
            try
            {
                SistemaPeliculasDb db = new SistemaPeliculasDb();

                db.Actores.Add(act);
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

        public static Actores Buscar(int id)
        {
            Actores actore = new Actores();
            var db = new SistemaPeliculasDb();
            return actore = db.Actores.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new SistemaPeliculasDb();
            Actores act = db.Actores.Find(id);

            db.Actores.Remove(act);
            db.SaveChanges();
        }

        public static List<Actores> GetLista()
        {
            var lista = new List<Actores>();
            var db = new SistemaPeliculasDb();
            lista = db.Actores.ToList();
            return lista;
        }

        public static List<Actores> GetListaNombre(string aux)
        {
            List<Actores> lista = new List<Actores>();
            var db = new SistemaPeliculasDb();
            lista = db.Actores.Where(a => a.Nombres == aux).ToList();
            return lista;
        }
    }
}
