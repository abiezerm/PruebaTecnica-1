using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Core.Context
{
   public class PruebaDbContext : DbContext
    {
        public PruebaDbContext(DbContextOptions<PruebaDbContext> options) : base (options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<Provincia>Provincias { get; set; }
        public DbSet<Municipio>Municipios { get; set; }
    }
}
