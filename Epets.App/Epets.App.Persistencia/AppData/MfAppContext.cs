using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    {
<<<<<<< HEAD
        public DbSet<Persona> personas{get;set;} //propiedad
        public DbSet<Medico> medicos{get;set;} //propiedad
        public DbSet<Propietario> propietarios{get;set;} //propiedad
        public DbSet<Mascota> mascotas{get;set;} //propiedad
        public DbSet<Empresa> empresa{get;set;} //propiedad
=======
        public DbSet<Persona> Personas{get;set;} //propiedad
        public DbSet<Medico> Medicos{get;set;} //propiedad
        public DbSet<Propietario> Propietarios{get;set;} //propiedad
        public DbSet<Mascota> Mascotas{get;set;} //propiedad
        public DbSet<Empresa> Empresa{get;set;} //propiedad
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a

        
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