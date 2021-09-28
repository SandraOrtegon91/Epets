using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
{
        /// <summary>
        /// Referencia al contexto del Propietario
        /// </summary>
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
     
        public RepositorioPropietario(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Propietario
        Propietario IRepositoriPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado=_appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un Propietario 
        void IRepositorioPropietario.DeletePropietario(int IdPropietario)
        {
            var propietarioEncontrado=_appContext.Propietarios.FirstOrDefault(p => p.Id==IdPropietario);

            if (propietarioEncontrado==null)
                return ;
            
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas los Propietarios
        IEnumerable<Propietario> IRepositorioPropietario.GetAllPersonaPropietarios()
        {
            return _appContext.Propietarios;

        }

        //Implementacion metodo Retornar un Propietario
        Propietario IRepositorioPropietario.GetPropietario(int IdPropietario)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id==IdPropietario);

        }

        //Implementacion metodo Actualizar Propietario
        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {

            var propietarioEncontrado=_appContext.Propietarios.FirstOrDefault(p => p.Id==propietario.Id);

            if (propietarioEncontrado!=null)
                {
                    propietarioEncontrado.Direccion=Propietario.Direccion;

                    _appContext.SaveChanges();
                   
                }
            
            return propietarioEncontrado;
        }
    }
}
