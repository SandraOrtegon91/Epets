using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoSigno : IRepositorioTipoSigno
    {
        /// <summary>
        /// Referencia al contexto del tipo signo
        /// </summary>
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
        ///  
        public RepositorioTipoSigno(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir los tipos de signos
        TipoSigno IRepositorioTipoSigno.AddTipoSigno(TipoSigno tipoSigno)
        {
            var tipoSignoAdicionado=_appContext.TipoSignos.Add(tipoSigno);
            _appContext.SaveChanges();
            return tipoSignoAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un TipoSigno 
        void IRepositorioTipoSigno.DeleteTipoSigno(int IdTipoSigno)
        {
            var tipoSignoEncontrado=_appContext.TipoSignos.FirstOrDefault(p => p.IdTipoSigno==IdTipoSigno);

            if (tipoSignoEncontrado==null)
                return ;
            
            _appContext.TipoSignos.Remove(tipoSignoEncontrado);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todos los TipoSigno
        IEnumerable<TipoSigno> IRepositorioTipoSigno.GetAllTipoSignos()
        {
            return _appContext.TipoSignos;

        }

        //Implementacion metodo Retornar un TipoSigno
        TipoSigno IRepositorioTipoSigno.GetTipoSigno(int IdTipoSigno)
        {
            return _appContext.TipoSignos.FirstOrDefault(p => p.IdTipoSigno==IdTipoSigno);

        }

        //Implementacion metodo Actualizar TipoSigno
        TipoSigno IRepositorioTipoSigno.UpdateTipoSigno(TipoSigno tipoSigno)
        {

            var tipoSignoEncontrado=_appContext.TipoSignos.FirstOrDefault(p => p.IdTipoSigno==tipoSigno.IdTipoSigno);

            if (tipoSignoEncontrado!=null)
                {
                    tipoSignoEncontrado.Temperatura=tipoSigno.Temperatura;
                    tipoSignoEncontrado.Peso=tipoSigno.Peso;
                    tipoSignoEncontrado.Freuencia_Cardiaca=tipoSigno.Freuencia_Cardiaca;
                    tipoSignoEncontrado.Frecuencia_Respiratoria=tipoSigno.Frecuencia_Respiratoria;
                    tipoSignoEncontrado.EstadoAnimo=tipoSigno.EstadoAnimo;
 
                    _appContext.SaveChanges();
                   
                }
            
            return tipoSignoEncontrado;
        }
    }
}