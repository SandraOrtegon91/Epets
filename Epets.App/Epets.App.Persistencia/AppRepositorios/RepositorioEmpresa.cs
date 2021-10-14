using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        /// <summary>
        /// Referencia al contexto de la Empresa
        /// </summary>
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
        ///  
        public RepositorioEmpresa(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir empresa
        Empresa IRepositorioEmpresa.AddEmpresa(Empresa empresa)
        {
            var empresaAdicionada=_appContext.Empresas.Add(empresa);
            _appContext.SaveChanges();
            return empresaAdicionada.Entity;
        }

        //Implementacion metodo Eliminar una Empresa 
        void IRepositorioEmpresa.DeleteEmpresa(int IdEmpresa)
        {
            var empresaEncontrada=_appContext.Empresas.FirstOrDefault(p => p.IdEmpresa==IdEmpresa);

            if (empresaEncontrada==null)
                return ;
            
            _appContext.Empresas.Remove(empresaEncontrada);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas las Empresas
        IEnumerable<Empresa> IRepositorioEmpresa.GetAllEmpresas()
        {
            return _appContext.Empresas;

        }

        //Implementacion metodo Retornar una Empresa
        Empresa IRepositorioEmpresa.GetEmpresa(int IdEmpresa)
        {
            return _appContext.Empresas.FirstOrDefault(p => p.IdEmpresa==IdEmpresa);

        }

        //Implementacion metodo Actualizar Empresa
        Empresa IRepositorioEmpresa.UpdateEmpresa(Empresa empresa)
        {

            var empresaEncontrada=_appContext.Empresas.FirstOrDefault(p => p.IdEmpresa==empresa.IdEmpresa);

            if (empresaEncontrada!=null)
                {
                    empresaEncontrada.NombreEmpresa=empresa.NombreEmpresa;
                    empresaEncontrada.Nit=empresa.Nit;
                    empresaEncontrada.DireccionEmpresa=empresa.DireccionEmpresa;

                    _appContext.SaveChanges();
                   
                }
            
            return empresaEncontrada;
        }
    }
}