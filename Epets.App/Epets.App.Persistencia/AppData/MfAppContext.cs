using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    {
        //propiedades del dominio
        public DbSet<Epets.App.Dominio.Entidades.Empresa> Empresa {get;set;}
//        public DbSet<Epets.App.Dominio.Entidades.Especialidad> Especialidad {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Historia> Historias {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Mascota> Mascotas {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Medico> Medicos {get;set;}
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Propietario> Propietarios {get;set;} 
        public DbSet<Epets.App.Dominio.Entidades.RecomendacionesCuidado> RecomendacionesCuidados {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.SignoVital> SignosVitales {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.SolicitudVisita> SolicitudVisitas {get;set;}
//        public DbSet<Epets.App.Dominio.Entidades.TipoAnimal> TipoAnimal {get;set;}
//        public DbSet<Epets.App.Dominio.Entidades.TipSigno> TipoSignos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = EpetsData");
            }
        }
    }
}
