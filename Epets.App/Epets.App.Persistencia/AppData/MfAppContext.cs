using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    
    {
        public DbSet<Persona> personas{get;set;} //propiedad
        public DbSet<Medico> medicos{get;set;} //propiedad
        public DbSet<Propietario> propietarios{get;set;} //propiedad
        public DbSet<Mascota> mascotas{get;set;} //propiedad
        public DbSet<Empresa> empresa{get;set;} //propiedad
        public DbSet<SolicitudVisita> SolicitudVisitas{get;set;}//Propiedad
        public DbSet<Historia> historias{get;set;}//Propiedad
        

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source =(localdb)\\MSSQLLocalDB; Initial Catalog = EPetsData");
//                optionsBuilder.UseSqlServer("Data source =DESKTOP-8UF80R8; Initial Catalog = EPetsData");
            }
        }
    }
}