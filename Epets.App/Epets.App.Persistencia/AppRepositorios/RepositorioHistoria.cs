using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de la Historia
        /// </summary>
        
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
 
        public RepositorioHistoria(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Historia
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var historiaAdicionada=_appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }

        //Implementacion metodo Eliminar una Historia 
        void IRepositorioHistoria.DeleteHistoria(int IdHistoria)
        {
            var historiaEncontrada=_appContext.Historias.FirstOrDefault(p => p.IdHistoria==IdHistoria);
            if (historiaEncontrada==null)
                return ;
                _appContext.Historias.Remove(historiaEncontrada);
                _appContext.SaveChanges();
        }

        //Implementacion metodo retornar todas las Historia
        IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias()
        {
            return _appContext.Historias;
        }

        //Implementacion metodo Retornar una Historia
        Historia IRepositorioHistoria.GetHistoria(int IdHistoria)
        {
            return _appContext.Historias.FirstOrDefault(p => p.IdHistoria==IdHistoria);
        }

        //Implementacion metodo Actualizar Historia
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var historiaEncontrada=_appContext.Historias.FirstOrDefault(p => p.IdHistoria==historia.IdHistoria);

            if (historiaEncontrada!=null)
                {
                    historiaEncontrada.FechaVisita=historia.FechaVisita;
                    historiaEncontrada.Recomendaciones=historia.Recomendaciones;
                    historiaEncontrada.Medicamento=historia.Medicamento;
                    _appContext.SaveChanges(); 
                }            
            return historiaEncontrada;
        }
    }
}
