using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    {
        public DbSet<Persona> Personas{get;set;} //propiedad
        public DbSet<Medico> Medicos{get;set;} //propiedad
        public DbSet<Propietario> Propietarios{get;set;} //propiedad
        public DbSet<Mascota> Mascotas{get;set;} //propiedad
        public DbSet<Empresa> Empresa{get;set;} //propiedad

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source =(localdb)\\MSSQLLocalDB; Initial Catalog = EPetsData");
            }
        }
    }
}