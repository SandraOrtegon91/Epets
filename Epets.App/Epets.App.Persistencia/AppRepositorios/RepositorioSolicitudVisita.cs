using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioSolicitudVisita : IRepositorioSolicitudVisita
    {
        /// <summary>
        /// Referencia al contexto de la SolicitudVisita
        /// </summary>
        
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>

        public RepositorioSolicitudVisita(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir SolicitudVisita
        SolicitudVisita IRepositorioSolicitudVisita.AddSolicitudVisita(SolicitudVisita solicitudVisita)
        {
            var solicitudVisitaAdicionada=_appContext.SolicitudVisitas.Add(solicitudVisita);
            _appContext.SaveChanges();
            return solicitudVisitaAdicionada.Entity;
        }

        //Implementacion metodo Eliminar una SolicitudVisita 
        void IRepositorioSolicitudVisita.DeleteSolicitudVisita(int IdSolicitudVisita)
        {
            var solicitudVisitaEncontrada=_appContext.SolicitudVisitas.FirstOrDefault(p => p.IdSolicitudVisita==IdSolicitudVisita);

            if (solicitudVisitaEncontrada==null)
                return ;
            
            _appContext.SolicitudVisitas.Remove(solicitudVisitaEncontrada);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas las Solicitudes Visitas
        IEnumerable<SolicitudVisita> IRepositorioSolicitudVisita.GetAllSolicitudVisitas()
        {
            return _appContext.SolicitudVisitas;

        }

        //Implementacion metodo Retornar una SolicitudVisita
        SolicitudVisita IRepositorioSolicitudVisita.GetSolicitudVisita(int IdSolicitudVisita)
        {
            return _appContext.SolicitudVisitas.FirstOrDefault(p => p.IdSolicitudVisita==IdSolicitudVisita);

        }

        //Implementacion metodo Actualizar SolicitudVisita
        SolicitudVisita IRepositorioSolicitudVisita.UpdateSolicitudVisita(SolicitudVisita solicitudVisita)
        {

            var solicitudVisitaEncontrada=_appContext.SolicitudVisitas.FirstOrDefault(p => p.IdSolicitudVisita==solicitudVisita.IdSolicitudVisita);

            if (solicitudVisitaEncontrada!=null)
                {
                    solicitudVisitaEncontrada.FechaVisita=solicitudVisita.FechaVisita;
                    _appContext.SaveChanges();        
                }
            
            return solicitudVisitaEncontrada;
        }
    }
}
