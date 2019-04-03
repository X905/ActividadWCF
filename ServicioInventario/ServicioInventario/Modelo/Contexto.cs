using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicioInventario.Modelo
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public DbSet<Productos> productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
    }
}