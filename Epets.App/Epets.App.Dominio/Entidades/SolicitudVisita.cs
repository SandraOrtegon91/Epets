using System;

namespace Epets.App.Dominio.Entidades

{
     /// <summary>Class <c>SolicitudVisita</c>
    /// Modela la solicitud que realiza el Propietario de la visita
    /// para la mascota
    /// </summary>   
  
    public class SolicitudVisita
    {
        public int Id { get; set; }
        
        
        // Identificacion de la mascota
        public Mascota Mascota{get;set;}
        /// Fecha y hora en que se agenda la visita       
        public DateTime FechaVisita{get;set;}
        /// Relacion entre el propietario y la solicitud de Visita
        public Propietario Propietario{get;set;}
        /// Relacion entre la Mascota y la solicitud de Visita
        public Mascota NombreMascota{get;set;}
        /// Relacion entre el Tipo de Animal y la solicitud de Visita
        public TipoAnimal TipoAnimal{get;set;}
        /// Relacion entre la Especialidad del Medico y la solicitud de Visita
        public Especialidad Especialidad{get;set;}
    }
}