using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico: IRepositorioMedico
    {
        /// <summary>
        /// Referencia al contexto del Medico
        /// </summary>
        private readonly MfAppContext _appContext1;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext1"></param>
        ///  
        public RepositorioMedico(MfAppContext appContext)
        {
            _appContext1=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Medico
        Medico IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado=_appContext1.Medicos.Add(medico);
            _appContext1.SaveChanges();
            return medicoAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un medico 
        void IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoEncontrado=_appContext1.Medicos.FirstOrDefault(p => p.Id==IdMedico);

            if (medicoEncontrado==null)
                return ;
            
            _appContext1.Medicos.Remove(medicoEncontrado);
            _appContext1.SaveChanges();

        }

        //Implementacion metodo retornar todos los medicos
        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext1.Medicos;

        }

        //Implementacion metodo Retornar un medico
        Medico IRepositorioMedico.GetMedico(int IdMedico)
        {
            return _appContext1.Medicos.FirstOrDefault(m => m.Id==IdMedico);

        }

        //Implementacion metodo Actualizar medico
        Medico IRepositorioMedico.UpdateMedico(Medico medico)
        {

            var medicoEncontrado=_appContext1.Medicos.FirstOrDefault(m => m.Id==medico.Id);

            if (medicoEncontrado!=null)
                {
                    medicoEncontrado.TarjetaProfesional=medico.TarjetaProfesional;
                    medicoEncontrado.Especialidad=medico.Especialidad;

                    _appContext1.SaveChanges();
                   
                }
            
            return medicoEncontrado;
        }
    }
}
