using BlazorAppRegPrestamos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppRegPrestamos.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Moras> Moras { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
