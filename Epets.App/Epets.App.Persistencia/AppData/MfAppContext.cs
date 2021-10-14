using System;
using Epets.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Epets.App.Persistencia.AppData
{
    public class MfAppContext:DbContext
    {
        //propiedades del dominio
        public DbSet<Epets.App.Dominio.Entidades.Empresa> Empresas {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Historia> Historias {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Mascota> Mascotas {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Medico> Medicos {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.Propietario> Propietarios {get;set;} 
        public DbSet<Epets.App.Dominio.Entidades.SolicitudVisita> SolicitudVisitas {get;set;}
        public DbSet<Epets.App.Dominio.Entidades.TipoSigno> TipoSignos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Data Source=DESKTOP-ED7AP1K;Initial Catalog=EpetsData;Integrated Security=True
                //optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = EpetsData");
               //Data Source=DESKTOP-ED7AP1K;Initial Catalog=EpetsData;Integrated Security=True
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ED7AP1K;Initial Catalog=EpetsData;Integrated Security=True");
            }
        }
    }
}
