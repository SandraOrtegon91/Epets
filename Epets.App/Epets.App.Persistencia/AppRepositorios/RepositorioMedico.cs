using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
<<<<<<< HEAD
    public class RepositorioMedico : IRepositorioMedico
{
        /// <summary>
        /// Referencia al contexto del Medico
        /// </summary>
        private readonly MfAppContext _appContext;
=======
    public class RepositorioMedico: IRepositorioMedico
    {
        /// <summary>
        /// Referencia al contexto del Medico
        /// </summary>
        private readonly MfAppContext _appContext1;
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
<<<<<<< HEAD
        /// <param name="appContext"></param>

        public RepositorioMedico(MfAppContext appContext)
        {
            _appContext=appContext;
=======
        /// <param name="appContext1"></param>
        ///  
        public RepositorioMedico(MfAppContext appContext)
        {
            _appContext1=appContext;
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Medico
        Medico IRepositorioMedico.AddMedico(Medico medico)
        {
<<<<<<< HEAD
            var medicoAdicionado=_appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un Medico 
        void IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(p => p.Id==IdMedico);
=======
            var medicoAdicionado=_appContext1.Medicos.Add(medico);
            _appContext1.SaveChanges();
            return medicoAdicionado.Entity;
        }

        //Implementacion metodo Eliminar un medico 
        void IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoEncontrado=_appContext1.Medicos.FirstOrDefault(p => p.Id==IdMedico);
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a

            if (medicoEncontrado==null)
                return ;
            
<<<<<<< HEAD
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
=======
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
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a
        }
    }
}
