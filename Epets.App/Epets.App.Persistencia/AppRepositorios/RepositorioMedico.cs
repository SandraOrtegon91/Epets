using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
{
        /// <summary>
        /// Referencia al contexto del Medico
        /// </summary>
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>

        public RepositorioMedico(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Medico
        Medico IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado=_appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un Medico 
        void IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(p => p.Id==IdMedico);

            if (medicoEncontrado==null)
                return ;
            
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas los Medicos
        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext.Medicos;

        }

        //Implementacion metodo Retornar un Medico
        Medico IRepositorioMedico.GetMedico(int IdMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id==IdMedico);

        }

        //Implementacion metodo Actualizar Medico
        Medico IRepositorioMedico.UpdateMedico(Medico medico)
        {

            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(p => p.Id==medico.Id);

            if (medicoEncontrado!=null)
                {
                    medicoEncontrado.Nombre=medico.Nombre;
                    medicoEncontrado.TarjetaProfesional=medico.TarjetaProfesional;
                    medicoEncontrado.EspecialidadVeterinario=medico.EspecialidadVeterinario;

                    _appContext.SaveChanges();
                   
                }
            
            return personaEncontrada;
        }
    }
}
