using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    {
        public DbSet<Epets.App.Dominio.Entidades.Persona> Personas{get;set;} //propiedad
        public DbSet<Epets.App.Dominio.Entidades.Medico> Medicos{get;set;} //propiedad
        public DbSet<Epets.App.Dominio.Entidades.Propietario> Propietarios{get;set;} //propiedad
        public DbSet<Epets.App.Dominio.Entidades.Mascota> Mascotas{get;set;} //propiedad
        public DbSet<Epets.App.Dominio.Entidades.Empresa> Empresa{get;set;} //propiedad

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source =(localdb)\\MSSQLLocalDB; Initial Catalog = EPetsData");
            }
        }
    }
}