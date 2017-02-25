using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Actores
    {
        [Key]
        public int ActoresId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Peliculas> Peliculas { get; set; }
        public Actores()
        {
            this.Peliculas = new List<Peliculas>();
        }

        public Actores(int actoresid, string nombres)
        {
            this.ActoresId = actoresid;
            this.Nombres = nombres;
            this.Peliculas = new List<Peliculas>();
        }

    }
}
