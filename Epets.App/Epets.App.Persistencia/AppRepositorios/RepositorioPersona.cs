using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        /// <summary>
        /// Referencia al contexto de la Persona
        /// </summary>
        private readonly MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
        ///  
        public RepositorioPersona(MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir persona
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada=_appContext.personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }

        //Implementacion metodo Eliminar una persona 
        void IRepositorioPersona.DeletePersona(int IdPersona)
        {
            var personaEncontrada=_appContext.personas.FirstOrDefault(p => p.Id==IdPersona);

            if (personaEncontrada==null)
                return ;
            
            _appContext.personas.Remove(personaEncontrada);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas las personas
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.personas;

        }

        //Implementacion metodo Retornar una persona
        Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            return _appContext.personas.FirstOrDefault(p => p.Id==IdPersona);

        }

        //Implementacion metodo Actualizar persona
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {

            var personaEncontrada=_appContext.personas.FirstOrDefault(p => p.Id==persona.Id);

            if (personaEncontrada!=null)
                {
                    personaEncontrada.Cedula=persona.Cedula;
                    personaEncontrada.Nombre=persona.Nombre;
                    personaEncontrada.Apellido=persona.Apellido;
                    personaEncontrada.Telefono=persona.Telefono;

                    _appContext.SaveChanges();
                   
                }
            
            return personaEncontrada;
        }
    }
}
