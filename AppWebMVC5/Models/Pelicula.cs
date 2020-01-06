using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppWebMVC5.Models
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
    }

    public class PeliculaDBContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}