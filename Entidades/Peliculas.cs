using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculasId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Actores> Actores { get; set; }
        public Peliculas()
        {
            this.Actores = new List<Actores>();
        }

        public Peliculas(int peliculaid, string nombres)
        {
            this.PeliculasId = peliculaid;
            this.Nombres = nombres;
            this.Actores = new List<Actores>();
        }
    }
}
