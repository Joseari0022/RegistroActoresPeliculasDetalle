using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SistemaPeliculasDb : DbContext 
    {
        public SistemaPeliculasDb() : base("name = ConStr")
        {
                
        }

        public virtual DbSet<Actores> Actores { get; set; }
        public virtual DbSet<Peliculas> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peliculas>()
                .HasMany<Actores>(a => a.Actores)
                .WithMany(p => p.Peliculas)
                .Map(ap =>
                {
                    ap.MapLeftKey("PeliculasId");
                    ap.MapRightKey("ActoresId");
                    ap.ToTable("ActoresPeliculas");
                });
        }
    }
}
