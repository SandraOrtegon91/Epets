using System;

namespace Epets.App.Dominio.Entidades

{
     /// <summary>Class <c>SolicitudVisita</c>
    /// Modela la solicitud que realiza el Propietario de la visita
    /// para la mascota
    /// </summary>   
  
    [Table("SolicitudVisitaDb")]
    public class SolicitudVisita
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Mascota")]
        // Identificacion de la mascota
        public Mascota Mascota{get;set;}
        
        [ForeignKey("FechaVisita")]
        /// Fecha y hora en que se agenda la visita       
        public DateTime FechaVisita{get;set;}
        
        [ForeignKey("Propietario")]
        /// Relacion entre el propietario y la solicitud de Visita
        public Propietario Propietario{get;set;}
        
        [ForeignKey("NombreMascota")]
        /// Relacion entre la Mascota y la solicitud de Visita
        public Mascota NombreMascota{get;set;}
        
        [ForeignKey("TipoAnimal")]
        /// Relacion entre el Tipo de Animal y la solicitud de Visita
        public TipoAnimal TipoAnimal{get;set;}
        
        [ForeignKey("Especialidad")]
        /// Relacion entre la Especialidad del Medico y la solicitud de Visita
        public Especialidad Especialidad{get;set;}
    }
}